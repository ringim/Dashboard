using Ozeki.Camera;
using Ozeki.Media;
using Ozeki.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Dashboard
{
    public partial class Camera : Form
    {

        private OzekiCamera _webCamera;

        //Build the ConnectionParameters for the camera
        private CameraURLBuilderWF _myCameraUrlBuilder;
       
        private DrawingImageProvider _imageProvider;
        private MediaConnector _connector;       
        private SnapshotHandler _snapshotHandler;
        

        public Camera()
        {
            InitializeComponent();

            _imageProvider = new DrawingImageProvider();          
            videoViewerWF1.SetImageProvider(_imageProvider);           

            _connector = new MediaConnector();
            _snapshotHandler = new SnapshotHandler();
            
        }

        
        private void InvokeGuiThread(Action action)
        {
            BeginInvoke(action);
        }

        void _webCamera_CameraStateChanged(object sender, CameraStateEventArgs e)
        {
            InvokeGuiThread(() =>
            {
                switch (e.State)
                {
                    case CameraState.Streaming:
                        btn_Disconnect.Enabled = true;
                        break;
                    case CameraState.Disconnected:
                        btn_Disconnect.Enabled = false;
                        btn_Connect.Enabled = true;
                        break;
                }
            });
        }

        private void btn_Disconnect_Click(object sender, EventArgs e)
        {
             videoViewerWF1.Stop();
            _webCamera.Stop();
            _connector.Disconnect(_webCamera.VideoChannel, _imageProvider);
            _webCamera = null;
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            if (_webCamera != null)
            {
                videoViewerWF1.Stop();
                _webCamera.Stop();
                _connector.Disconnect(_webCamera.VideoChannel, _imageProvider);
            }
            btn_Connect.Enabled = false;

            _webCamera = new OzekiCamera(_myCameraUrlBuilder.CameraURL);
            _webCamera.CameraStateChanged += _webCamera_CameraStateChanged;

            _connector.Connect(_webCamera.VideoChannel, _imageProvider);
            _connector.Connect(_webCamera.VideoChannel, _snapshotHandler);
            

            videoViewerWF1.SetImageProvider(_imageProvider);

            _webCamera.Start();
            videoViewerWF1.Start();
            
        }

        private void btn_capture_Click(object sender, EventArgs e)
        {
            var snapShotImage = _snapshotHandler.TakeSnapshot().ToImage();
            pictureHD.Image = (Bitmap)_snapshotHandler.TakeSnapshot().ToImage();            
        }

       

        private void _capture_OnFrameCaptured1(object sender, Ozeki.Media.Snapshot e)//Snapshot e)
        {
            pictureHD.Image = (Bitmap)e.ToImage();
            var image1 = (Bitmap)e.ToImage();

            image1.Save("/Documents", System.Drawing.Imaging.ImageFormat.Jpeg);
           image1.Save("test" + ".jpg");
        }

        private void CreateSnapShot(string path)
        {
            var date = DateTime.Now.Year + "y-" + DateTime.Now.Month + "m-" + DateTime.Now.Day + "d-" +
                       DateTime.Now.Hour + "h-" + DateTime.Now.Minute + "m-" + DateTime.Now.Second + "s";
            string currentpath;
            if (String.IsNullOrEmpty(path))
                currentpath = date + ".jpg";
            else
                currentpath = path + "\\" + date + ".jpg";
            
        }

        private void SaveSnapshot()
        {
            var path = "/Documents";
            CreateSnapShot(path);
        }



        private void btn_getcamera(object sender, EventArgs e)
        {
            var data = new CameraURLBuilderData { DeviceTypeFilter = DiscoverDeviceType.USB };
            _myCameraUrlBuilder = new CameraURLBuilderWF(data);           
            var result = _myCameraUrlBuilder.ShowDialog();

            if (result != DialogResult.OK)
                return;

            //textBox1.Text = _myCameraUrlBuilder.CameraURL;

            btn_Connect.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Images|*.png;*.bmp;*.jpg";
            ImageFormat format = ImageFormat.Png;
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(sfd.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                }
                pictureHD.Image.Save(sfd.FileName, format);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
