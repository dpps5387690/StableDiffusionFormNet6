using SixLabors.ImageSharp;
using StableDiffusion.ML.OnnxRuntime;
using System.Diagnostics;

namespace StableDiffusionFormNet6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GlobalVariable.RichText_log = richTextBox_Log;
        }


        private void button_Generate_Click(object sender, EventArgs e)
        {
            button_Generate.Enabled = false;
            Thread m_generate = new Thread(() => generate_img());//µ¥«Ý@START_TEST 00 11111111+
            m_generate.IsBackground = true;
            m_generate.Start();
        }

        void generate_img()
        {
            //test how long this takes to execute
            var watch = System.Diagnostics.Stopwatch.StartNew();

            var prompt = textBox_prompt.Text;
            var config = new StableDiffusionConfig
            {
                // Number of denoising steps
                NumInferenceSteps = (int)numericUpDownSteps.Value,
                // Scale for classifier-free guidance
                GuidanceScale = (double)numericUpDown_Scale.Value,
                // Set your preferred Execution Provider. Currently (GPU, DirectML, CPU) are supported in this project.
                // ONNX Runtime supports many more than this. Learn more here: https://onnxruntime.ai/docs/execution-providers/
                // The config is defaulted to CUDA. You can override it here if needed.
                // To use DirectML EP intall the Microsoft.ML.OnnxRuntime.DirectML and uninstall Microsoft.ML.OnnxRuntime.GPU
                ExecutionProviderTarget = StableDiffusionConfig.ExecutionProvider.Cuda,
                // Set GPU Device ID.
                DeviceId = 0,
                // Update paths to your models
                TextEncoderOnnxPath = @".\models\text_encoder\model.onnx",
                UnetOnnxPath = @".\models\unet\model.onnx",
                VaeDecoderOnnxPath = @".\models\vae_decoder\model.onnx",
                SafetyModelPath = @".\models\safety_checker\model.onnx",            
            };
            trackBar_Width.Invoke(new Action(() =>
            {
                config.Width = trackBar_Width.Value;
                config.Height = trackBar_Height.Value;
            }));
            // Inference Stable Diff
            var image = UNet.Inference(prompt, config);
            // If image failed or was unsafe it will return null.
            if (image == null)
            {
                Utility.WriteStatus(GlobalVariable.RichText_log, "Unable to create image, please try again.");
            }

            var imageName = $"sd_image_{DateTime.Now.ToString("yyyyMMddHHmm")}.png";
            image.Save(imageName);
            // Stop the timer
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Utility.WriteStatus(GlobalVariable.RichText_log, "Time taken: " + elapsedMs + "ms");

            var outStream = new MemoryStream();
            image.SaveAsBmp(outStream);

            button_Generate.Invoke(new Action(() =>
            {
                pictureBox1.Image = new System.Drawing.Bitmap(outStream);
                button_Generate.Enabled = true;
            }));
            System.GC.Collect();
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            TrackBar trackBar = (TrackBar)sender;
            Control[] nowtb = Controls.Find(trackBar.Name.Replace("trackBar", "numericUpDown"), true);
            NumericUpDown numericUpDown = (NumericUpDown)nowtb[0];
            numericUpDown.Value = trackBar.Value;
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            if(numericUpDown.Value % 128 != 0)
                numericUpDown.Value = ((int)(numericUpDown.Value / 128) + 1) * 128;
            Control[] nowtb = Controls.Find(numericUpDown.Name.Replace("numericUpDown", "trackBar"), true);
            TrackBar trackBar = (TrackBar)nowtb[0];
            trackBar.Value = (int)numericUpDown.Value;
        }

    }
}