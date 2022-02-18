using System;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using System.IO;

namespace CTApp_QRScanner_OOP
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevice)
                CmbBxDevice.Items.Add(Device.Name);

            CmbBxDevice.SelectedIndex = 0;
            FinalFrame = new VideoCaptureDevice();
        }

        private void BtnStrt_Click(object sender, EventArgs e)
        {
            FinalFrame = new VideoCaptureDevice(CaptureDevice[CmbBxDevice.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
            Timer_tck.Start();
        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            CamBx.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            if (FinalFrame.IsRunning == true)
                FinalFrame.Stop();
        }

        private void Timer_tck_Tick(object sender, EventArgs e)
        {
            if (CamBx.Image != null)
            {
                BarcodeReader reader = new BarcodeReader();
                Result result = reader.Decode((Bitmap)CamBx.Image);

                if (result != null)
                {
                    StreamWriter Decode;
                    Decode = File.AppendText("QRCfile.txt");
                    Decode.WriteLine("QRcode_Info");
                    Decode.WriteLine("");
                    Decode.WriteLine("Date:" + "" + DateTime.Now.ToString("MM/dd/yyyy"));
                    Decode.WriteLine("Time:" + "" + DateTime.Now.ToString("hh:mm:ss tt"));
                    Decode.WriteLine("");
                    Decode.WriteLine(result.Text);
                    Decode.WriteLine("");
                    Decode.WriteLine("");
                    Decode.Close();
                    MessageBox.Show("QRC Saved");
                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnRead_Click(object sender, EventArgs e)
        {
            Timer_tck.Start();

        }


    }
}
