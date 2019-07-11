//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;
using System.Threading.Tasks;

using System.IO;
using System.Text;
using WebCam_Capture;

	//Design by Pongsakorn Poosankam
	internal class WebCam
	{
		private WebCamCapture webcam;
		private System.Windows.Forms.PictureBox _FrameImage;
		private int FrameNumber = 30;
		public void InitializeWebCam(ref System.Windows.Forms.PictureBox ImageControl)
		{
			webcam = new WebCamCapture();
			webcam.FrameNumber = Convert.ToUInt64((0));
			webcam.TimeToCapture_milliseconds = FrameNumber;
			webcam.ImageCaptured += webcam_ImageCaptured;
			_FrameImage = ImageControl;
		}

		private void webcam_ImageCaptured(object source, WebcamEventArgs e)
		{
			_FrameImage.Image = e.WebCamImage;
		}

		public void Start()
		{
			webcam.TimeToCapture_milliseconds = FrameNumber;
			webcam.Start(0);
		}

		public void Stop()
		{
			webcam.Stop();
		}

		public void Continue()
		{
			// change the capture time frame
			webcam.TimeToCapture_milliseconds = FrameNumber;

			// resume the video capture from the stop
			webcam.Start(this.webcam.FrameNumber);
		}

		public void ResolutionSetting()
		{
			webcam.Config();
		}

		public void AdvanceSetting()
		{
			webcam.Config2();
		}

	}

