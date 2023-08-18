using Microsoft.ML.OnnxRuntime.Tensors;
using Microsoft.ML.OnnxRuntime;
using System.Diagnostics;
using StableDiffusionFormNet6;

namespace StableDiffusion.ML.OnnxRuntime
{
    public static class TextProcessing
    {
        public static DenseTensor<float> PreprocessText(String prompt, StableDiffusionConfig config, out DenseTensor<float> textembedsTensor)
        {
            // Load the tokenizer and text encoder to tokenize and encode the text.
            var textTokenized1 = TokenizeText(prompt, config);
            var textPromptEmbeddings1 = TextEncoder(textTokenized1, config).ToArray();

            // Create uncond_input of blank tokens
            var uncondInputTokens1 = CreateUncondInput();
            var uncondEmbedding1 = TextEncoder(uncondInputTokens1, config).ToArray();

            // Load the tokenizer and text encoder to tokenize and encode the text.
            var textTokenized2 = CreateUncondInput64();//TokenizeText64("", config);
            var textPromptEmbeddings2 = TextEncoder2(textTokenized2, config,out textembedsTensor).ToArray();

            // Create uncond_input of blank tokens
            var uncondInputTokens2 = CreateUncondInput64();
            DenseTensor<float> textembedsTensor1;
            var uncondEmbedding2 = TextEncoder2(uncondInputTokens2, config,out textembedsTensor1).ToArray();


            float[] textPromptEmbeddings = textPromptEmbeddings1.Concat(textPromptEmbeddings2).ToArray();
            float[] uncondEmbedding = uncondEmbedding1.Concat(uncondEmbedding2).ToArray();

            // Concant textEmeddings and uncondEmbedding
            DenseTensor<float> textEmbeddings = new DenseTensor<float>(new[] { 1, 77, config.CrossAttentionDimension });

            for (var i = 0; i < textPromptEmbeddings.Length; i++)
            {
                //textEmbeddings[0, i / config.CrossAttentionDimension, i % config.CrossAttentionDimension] = uncondEmbedding[i];
                textEmbeddings[0, i / config.CrossAttentionDimension, i % config.CrossAttentionDimension] = textPromptEmbeddings[i];
            }
            return textEmbeddings;
        }
        public static int[] TokenizeText(string text, StableDiffusionConfig config)
        {
            // Create session options for custom op of extensions
            var sessionOptions = new SessionOptions();
            sessionOptions.RegisterOrtExtensions();
            
            // Create an InferenceSession from the onnx clip tokenizer.
            var tokenizeSession = new InferenceSession(config.TokenizerOnnxPath, sessionOptions);
            var inputTensor = new DenseTensor<string>(new string[] { text }, new int[] { 1 });
            var inputString = new List<NamedOnnxValue> { NamedOnnxValue.CreateFromTensor<string>("string_input", inputTensor) };
            // Run session and send the input data in to get inference output. 
            var tokens = tokenizeSession.Run(inputString);


            var inputIds = (tokens.ToList().First().Value as IEnumerable<long>).ToArray();
            Utility.WriteStatus(GlobalVariable.RichText_log, String.Join(" ", inputIds));

            // Cast inputIds to Int32
            var InputIdsInt = inputIds.Select(x => (int)x).ToArray();

            var modelMaxLength = 77;
            // Pad array with 49407 until length is modelMaxLength
            if (InputIdsInt.Length < modelMaxLength)
            {
                var pad = Enumerable.Repeat(49407, 77 - InputIdsInt.Length).ToArray();
                InputIdsInt = InputIdsInt.Concat(pad).ToArray();
            }

            return InputIdsInt;

        }

        public static Int64[] TokenizeText64(string text, StableDiffusionConfig config)
        {
            // Create session options for custom op of extensions
            var sessionOptions = new SessionOptions();
            sessionOptions.RegisterOrtExtensions();

            // Create an InferenceSession from the onnx clip tokenizer.
            var tokenizeSession = new InferenceSession(config.TokenizerOnnxPath, sessionOptions);
            var inputTensor = new DenseTensor<string>(new string[] { text }, new int[] { 1 });
            var inputString = new List<NamedOnnxValue> { NamedOnnxValue.CreateFromTensor<string>("string_input", inputTensor) };
            // Run session and send the input data in to get inference output. 
            var tokens = tokenizeSession.Run(inputString);


            var inputIds = (tokens.ToList().First().Value as IEnumerable<long>).ToArray();
            Utility.WriteStatus(GlobalVariable.RichText_log, String.Join(" ", inputIds));

            // Cast inputIds to Int32
            var InputIdsInt = inputIds.Select(x => (Int64)x).ToArray();

            var modelMaxLength = 77;
            // Pad array with 49407 until length is modelMaxLength
            if (InputIdsInt.Length < modelMaxLength)
            {
                var pad = Enumerable.Repeat((Int64)49407, 77 - InputIdsInt.Length).ToArray();
                InputIdsInt = InputIdsInt.Concat(pad).ToArray();
            }

            return InputIdsInt;

        }

        public static int[] CreateUncondInput()
        {
            // Create an array of empty tokens for the unconditional input.
            var blankTokenValue = 49407;
            var modelMaxLength = 77;
            var inputIds = new List<Int32>();
            inputIds.Add(49406);
            var pad = Enumerable.Repeat(blankTokenValue, modelMaxLength - inputIds.Count()).ToArray();
            inputIds.AddRange(pad);

            return inputIds.ToArray();
        }

        public static Int64[] CreateUncondInput64()
        {
            // Create an array of empty tokens for the unconditional input.
            Int64 blankTokenValue = 49407;
            var modelMaxLength = 77;
            var inputIds = new List<Int64>();
            inputIds.Add(49406);
            var pad = Enumerable.Repeat(blankTokenValue, modelMaxLength - inputIds.Count()).ToArray();
            inputIds.AddRange(pad);

            return inputIds.ToArray();
        }

        public static DenseTensor<float> TextEncoder(int[] tokenizedInput, StableDiffusionConfig config)
        {
            // Create input tensor.
            var input_ids = TensorHelper.CreateTensor(tokenizedInput, new[] { 1, tokenizedInput.Count() });

            var input = new List<NamedOnnxValue> { NamedOnnxValue.CreateFromTensor<int>("input_ids", input_ids) };

            // Set CUDA EP
            var sessionOptions = config.GetSessionOptionsForEp();

            var encodeSession = new InferenceSession(config.TextEncoderOnnxPath, sessionOptions);
            // Run inference.
            var encoded = encodeSession.Run(input);
            int Dimensions = encodeSession.OutputMetadata["last_hidden_state"].Dimensions[2];
            var lastHiddenState = (encoded.ToList().First().Value as IEnumerable<float>).ToArray();
            var lastHiddenStateTensor = TensorHelper.CreateTensor(lastHiddenState.ToArray(), new[] { 1, 77, Dimensions });

            return lastHiddenStateTensor;

        }

        public static DenseTensor<float> TextEncoder2(Int64[] tokenizedInput, StableDiffusionConfig config, out DenseTensor<float> textembedsTensor)
        {
            // Create input tensor.
            var input_ids = TensorHelper.CreateTensor(tokenizedInput, new[] { 1, tokenizedInput.Count() });

            var input = new List<NamedOnnxValue> { NamedOnnxValue.CreateFromTensor<Int64>("input_ids", input_ids) };

            // Set CUDA EP
            var sessionOptions = config.GetSessionOptionsForEp();

            var encodeSession = new InferenceSession(config.TextEncoderOnnxPath2, sessionOptions);
            // Run inference.
            var encoded = encodeSession.Run(input);
            int Dimensions = encodeSession.OutputMetadata["last_hidden_state"].Dimensions[2];

            var textembeds = (encoded.ToList().FindLast(x => x.Name == "text_embeds").Value as IEnumerable<float>).ToArray();
            textembedsTensor = TensorHelper.CreateTensor(textembeds.ToArray(), new[] { 1, Dimensions });

            var lastHiddenState = (encoded.ToList().FindLast(x => x.Name == "last_hidden_state").Value as IEnumerable<float>).ToArray();
            var lastHiddenStateTensor = TensorHelper.CreateTensor(lastHiddenState.ToArray(), new[] { 1, 77, Dimensions });

            return lastHiddenStateTensor;

        }
    }
}