using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Bunifu.Framework.Lib;
using BunifuAnimatorNS;
using KimtToo.VisualReactive;
using WebCam_Capture;
using System.IO;
using DPFP;
using DPFP.Capture;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing.Printing;

using System.Diagnostics;
using Microsoft.Reporting.WinForms;

namespace Dashboard
{
    public partial class Dashboard : Form, DPFP.Capture.EventHandler
    {

        WebCam cam = new WebCam();

        

        public Dashboard(AppData data)
        {
            InitializeComponent();
            cam.InitializeWebCam(ref pictureBox2);

            Data = new AppData();                               // Create the application data object
            Data.OnChange += delegate { ExchangeData(false); }; // Track data changes to keep the form synchronized
            Enroller = new EnrollmentForm(Data);


            ExchangeData(false);
        }

       

        //declare event handler for printing in constructor
        //printdoc1.PrintPage += new PrintPageEventHandler(printdoc1_PrintPage);
        


        #region DPFP functions here
        //DPFP Functions
        private DPFP.Capture.Capture Capturer;
        //private DPFP.Template Templates;
        private DPFP.Verification.Verification Verificator;
        #endregion


        #region 
        protected void SetStatus(string status)
        {
            this.Invoke(new Function(delegate () {
                StatusLine.Text = status;
            }));
        }

        protected void SetPrompt(string prompt)
        {
            Prompt.Text = prompt;
        }

        protected void MakeReport(string message)
        {
            this.Invoke(new Function(delegate () {
                StatusText.AppendText(message + "\r\n");
            }));
        }


        protected void fullNames(string message)
        {
            this.Invoke(new Function(delegate () {
                label61.Text = message + " \r\n";
                rName = message;
            }));
        }
         
        protected void DateOfBirth(string message)
        {
            
            this.Invoke(new Function(delegate () {
                label59.Text = message + " \r\n";                
                rDateOfBirth = Convert.ToDateTime(message);

            }));
        }
        protected void contactTown(string message)
        {
            this.Invoke(new Function(delegate () {
                label57.Text = message + " \r\n";
                rTown = message;
            }));
        }
        protected void contactWard(string message)
        {
            this.Invoke(new Function(delegate () {
                label55.Text = message + " \r\n";
                rWard = message; 
            }));
        }
        protected void contactNumber(string message)
        {
            this.Invoke(new Function(delegate () {
                label53.Text = message + " \r\n";
                rContactNo = message;
            }));
        }
        protected void contactAddress(string message)
        {
            this.Invoke(new Function(delegate () {
                label51.Text = message + " \r\n";
                rAddress = message;
            }));
        }
        protected void businessType(string message)
        {
            this.Invoke(new Function(delegate () {
                label50.Text = message + " \r\n";
                rBiztype = message;
            }));
        }
        protected void BiznessAmount(string message)
        {
            this.Invoke(new Function(delegate () {
                label48.Text = message + " \r\n";
                rGrant = message;
            }));
        }

        //I created because its giving me  Cross Thread Error "Thread it was created on"
        protected void HideControl(Panel pan)
        {
            this.Invoke(new Function(delegate () {
                pan.Hide();
            }));
        }

        protected void ShowControls(Panel pan)
        {
            this.Invoke(new Function(delegate () {
                pan.Show();
            }));
        }

        #endregion


        #region Event Handlers


        delegate void Function();   // a simple delegate for marshalling calls from event handlers to the GUI thread


        // AppData Data; //Let me figure out where i should use this one

        public void OnFingerGone(object Capture, string ReaderSerialNumber)
        {
            MakeReport("The finger was removed from the fingerprint reader.");
        }

        public void OnFingerTouch(object Capture, string ReaderSerialNumber)
        {
            MakeReport("The fingerprint reader was touched.");
        }

        public void OnReaderConnect(object Capture, string ReaderSerialNumber)
        {
            MakeReport("The fingerprint reader was connected.");

        }

        public void OnReaderDisconnect(object Capture, string ReaderSerialNumber)
        {
            MakeReport("The fingerprint reader was disconnected.");
        }

        public void OnSampleQuality(object Capture, string ReaderSerialNumber, DPFP.Capture.CaptureFeedback CaptureFeedback)
        {
            if (CaptureFeedback == DPFP.Capture.CaptureFeedback.Good)
                MakeReport("The quality of the fingerprint sample is good.");
            else
                MakeReport("The quality of the fingerprint sample is poor.");
        }

        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream stream = new MemoryStream(byteArrayIn))
            {
                Image returnImage = Image.FromStream(stream);
                return returnImage;
            }
        }

        #endregion

        public static object ByteArrayToObject(byte[] arrBytes)
        {
            using (var memstream = new MemoryStream())
            {
                var binForm = new BinaryFormatter();
                memstream.Write(arrBytes, 0, arrBytes.Length);
                memstream.Seek(0, SeekOrigin.Begin);
                var obj = binForm.Deserialize(memstream);
                return obj;
            }
        }

        FormControls formcontrols = new FormControls();
        // Simple dialog data exchange (DDX) implementation.
        private void ExchangeData(bool read)
        {
            if (read)
            {   // read values from the form's controls to the data object
                Data.EnrolledFingersMask = formcontrols.EnrolledFingersMask;
                Data.MaxEnrollFingerCount = formcontrols.MaxEnrollFingerCount;
                Data.IsEventHandlerSucceeds = formcontrols.IsEventHandlerSucceeds;
                Data.Update();
            }
            else
            {// read valuse from the data object to the form's controls

                formcontrols.EnrolledFingersMask = Data.EnrolledFingersMask;
                formcontrols.MaxEnrollFingerCount = Data.MaxEnrollFingerCount;
                formcontrols.IsEventHandlerSucceeds = Data.IsEventHandlerSucceeds;
                // IsFailure.Checked = !IsSuccess.Checked;
                formcontrols.IsFeatureSetMatched = Data.IsFeatureSetMatched;
                formcontrols.FalseAcceptRate = Data.FalseAcceptRate;
                // VerifyButton.Enabled = Data.EnrolledFingersMask > 0;
            }
        }

        //Application SDK functions
       // delegate void Function();   // a simple delegate for marshalling calls from event handlers to the GUI thread
        private EnrollmentForm Enroller;
        public delegate void OnTemplateEventHandler(DPFP.Template template);



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        bool menuExpanded = false;
        private void MouseDetect_Tick(object sender, EventArgs e)
        {
            if (!bunifuTransition1.IsCompleted) return;
            if (panelMainMenu.ClientRectangle.Contains(PointToClient(Control.MousePosition)))
            {
                if (!menuExpanded)
                {
                    menuExpanded = true;                    
                    panelMainMenu.Width = 172;
                  
                }
            }
            else
            {
                if (menuExpanded)
                {
                    menuExpanded = false;
                    panelMainMenu.Visible = false;
                    panelMainMenu.Width = 48;
                    bunifuTransition1.Show(panelMainMenu);
                }

            }
        }

      

        private void sideMenu_Click(object sender, EventArgs e)
        {
            VSReactive<int>.SetState("menu", int.Parse(((Control)sender).Tag.ToString()));
        }

        private void submenu1_Load(object sender, EventArgs e)
        {

        }

        private void panelMainMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            cam.Start();
            btnCapture.Enabled = true;
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
          
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = (tabControl1.SelectedIndex + 1 < tabControl1.TabCount) ?
                             tabControl1.SelectedIndex + 1 : tabControl1.SelectedIndex;
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = (tabControl1.SelectedIndex + 1 < tabControl1.TabCount) ?
                             tabControl1.SelectedIndex + 1 : tabControl1.SelectedIndex;
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = (tabControl1.SelectedIndex + 1 < tabControl1.TabCount) ?
                             tabControl1.SelectedIndex + 1 : tabControl1.SelectedIndex;
        }

        private void bunifuThinButton29_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = (tabControl1.SelectedIndex - 1 < tabControl1.TabCount) ?
                             tabControl1.SelectedIndex - 1 : tabControl1.SelectedIndex;
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = (tabControl1.SelectedIndex + 1 < tabControl1.TabCount) ?
                             tabControl1.SelectedIndex + 1 : tabControl1.SelectedIndex;
        }

        private void bunifuThinButton28_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = (tabControl1.SelectedIndex - 1 < tabControl1.TabCount) ?
                             tabControl1.SelectedIndex - 1 : tabControl1.SelectedIndex;
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = (tabControl1.SelectedIndex + 1 < tabControl1.TabCount) ?
                             tabControl1.SelectedIndex + 1 : tabControl1.SelectedIndex;
        }

        private void bunifuThinButton212_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = (tabControl1.SelectedIndex + 1 < tabControl1.TabCount) ?
                             tabControl1.SelectedIndex + 1 : tabControl1.SelectedIndex;

            //get summary of all the filed boxes
            getSummaryOfDetails();

        }

        private void bunifuThinButton211_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = (tabControl1.SelectedIndex - 1 < tabControl1.TabCount) ?
                             tabControl1.SelectedIndex - 1 : tabControl1.SelectedIndex;
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = (tabControl1.SelectedIndex - 1 < tabControl1.TabCount) ?
                             tabControl1.SelectedIndex - 1 : tabControl1.SelectedIndex;
        }

        private void bunifuThinButton210_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = (tabControl1.SelectedIndex - 1 < tabControl1.TabCount) ?
                             tabControl1.SelectedIndex - 1 : tabControl1.SelectedIndex;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ////cam.Start();
            ////btnCapture.Enabled = true;
            Camera cam = new Camera();
            cam.ShowDialog();

        }

        private void btnCapture_Click_1(object sender, EventArgs e)
        {
            pictureBox2.Image = pictureBox2.Image;
            cam.Stop();
            btnCapture.Enabled = false;
        }

        
        private void bunifuThinButton215_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "JPG Files(*.jpg) | *.jpg| PNG Files (*.png) |*.png | ALL Files(*.*)| *.* "; ;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = null;
                pictureBox2.Image = Image.FromFile(fd.FileName);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 1:
                    bunifuCheckbox1.Checked = bunifuCheckbox1.Checked = true;
                    label17.ForeColor = Color.DarkOrange;
                    break;
                case 2:
                    bunifuCheckbox2.Checked = bunifuCheckbox1.Checked = true;
                    label18.ForeColor = Color.DarkOrange;
                    break;
                case 3:
                    bunifuCheckbox3.Checked = bunifuCheckbox1.Checked = true;
                    label19.ForeColor = Color.DarkOrange;
                    break;
                //case 4:
                //    bunifuCheckbox4.Checked = bunifuCheckbox1.Checked = true;
                //    label20.ForeColor = Color.DarkOrange;
                //    break;
                case 4:
                    bunifuCheckbox6.Checked = bunifuCheckbox1.Checked = true;
                    label34.ForeColor = Color.DarkOrange;
                    break;
                case 5:
                    bunifuCheckbox5.Checked = bunifuCheckbox1.Checked = true;
                    label21.ForeColor = Color.DarkOrange;
                    break;
                
                
            }
        }

        private void bunifuCheckbox7_OnChange(object sender, EventArgs e)
        {
            if (checkBoxTraining.Checked)
            {
                bunifuCheckbox8.Checked = false;

                dropBizType1.Enabled = true;
                txtGrant1.Enabled = true;

                dropBizType2.Enabled = false;
                txtGrant2.Enabled = true;
            }
            
        }

        private void bunifuCheckbox8_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox8.Checked)
            {
                checkBoxTraining.Checked = false;               

                dropBizType2.Enabled = true;
                txtGrant2.Enabled = true;

                dropBizType1.Enabled = false;
                txtGrant1.Enabled = false;
            }
            
        }

        private void getSummaryOfDetails()
        {
            try
            {
                laNames.Text = txtFirstName.Text + " " + txtLastName.Text;
                laDOB.Text = dateTimePicker1.Value.ToShortDateString(); ;
                laContact.Text = txtContact1.Text + ", " + txtContact2.Text;
                laTown.Text = dropTown.selectedValue;
                laWard.Text = txtWard.Text;
                laBiznesstype.Text = (checkBoxTraining.Checked == true) ? dropBizType1.selectedValue : dropBizType2.selectedValue;
                laGrant.Text = (checkBoxTraining.Checked == true) ? txtGrant1.Text : txtGrant2.Text;
                laAddress.Text = txtPartyAddress.Text;

                pictureBox3.Image = pictureBox2.Image;
            }
            catch
            {
                MessageBox.Show("Kindly check your inputs...");
            }
            

        }

        private AppData Data;
        private async void bunifuThinButton26_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                using (YouthEmpowermentEntities context = new YouthEmpowermentEntities())
                {
                    // Set stream for array of bytes
                    MemoryStream ms = new MemoryStream();
                    //save Details and template in the Database
                    context.Database.Connection.Open();

                    byte[] pic;
                    MemoryStream stream = new MemoryStream();
                    pictureBox2.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    pic = stream.ToArray();


                    tblFingerprint fingers = new tblFingerprint
                    {
                        fingerTemplate = Data.Datum
                    };

                    
                    tblBusiness bizness = new tblBusiness()
                    {

                        Training = (checkBoxTraining.Checked == true) ? "Training & Vocational Skills" : "Skills Acquisition Programmes",
                        IntroducedBy = txtIntroducedBy.Text,
                        BusinessType = (checkBoxTraining.Checked == true) ? dropBizType1.selectedValue : dropBizType2.selectedValue,
                        Amount = (checkBoxTraining.Checked == true) ? txtGrant1.Text : txtGrant2.Text,
                        NatureofBusiness = txtNatureBusiness.Text

                    };

                    tblContact contact = new tblContact()
                    {
                        Town = dropTown.selectedValue,
                        Ward = txtWard.Text,
                        LGA = dropLGA.selectedValue,
                        ContactNum1 = txtContact1.Text,
                        ContactNum2 = txtContact2.Text,
                        PartyAddress = txtPartyAddress.Text,
                        

                    };

                    var dat = dateTimePicker1.Value.ToShortDateString();
                    tblPersonalDetail personalDetail = new tblPersonalDetail()
                    {
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        Occupation = txtOccupation.Text,
                        Picture = pic,

                        ContactID = contact.ID,
                        BusinessID = bizness.ID,
                        //AccountID = account.ID,
                        FingerID = fingers.ID,

                        DOB = DateTime.ParseExact(dat, "dd/MM/yyyy", null)
                    };

                    context.Configuration.AutoDetectChangesEnabled = true;
                    //context.tblAccounts.Add(account);
                    context.tblBusinesses.Add(bizness);
                    context.tblContacts.Add(contact);
                    context.tblFingerprints.Add(fingers);
                    context.tblPersonalDetails.Add(personalDetail);

                    int x = await context.SaveChangesAsync();

                    if (context.ChangeTracker.HasChanges() || x > 0)
                    {
                        MessageBox.Show("Information saved successfully");
                        //ClearBoxes(); //This clear all controls
                        ResetFingers(); //This will reset fingerMasks
                    }
                }

                tabControl1.SelectedIndex = (tabControl1.SelectedIndex + 1 < tabControl1.TabCount) ?
                                   tabControl1.SelectedIndex + 1 : tabControl1.SelectedIndex;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ResetFingers()
        {
            for (int i = 0; i < 10; i++)
            {
                Data.Templates[i] = null;
                formcontrols.Templates[i] = null;
            }
            Data.EnrolledFingersMask = 0;
            formcontrols.EnrolledFingersMask = 0;

            ExchangeData(true);
        }

        private void tab2_Click(object sender, EventArgs e)
        {
            panelRegister.BringToFront();
            panelRegister.Dock = DockStyle.Fill;
            panelDashboard.SendToBack();

            panelMainMenu.Width = 48;
        }

        private void tab1_Click(object sender, EventArgs e)
        {
            panelDashboard.BringToFront();
            panelDashboard.Dock = DockStyle.Fill;
            panelRegister.SendToBack();

            panelMainMenu.Width = 48;
        }

        private void bunifuThinButton28_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = (tabControl1.SelectedIndex - 1 < tabControl1.TabCount) ?
                            tabControl1.SelectedIndex - 1 : tabControl1.SelectedIndex;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ExchangeData(true);     // transfer values from the main form to the data object
                Enroller.ShowDialog();  // process enrollment

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void panelAuthenticate_Paint(object sender, PaintEventArgs e)
        {

        }

        protected Bitmap ConvertSampleToBitmap(DPFP.Sample Sample)
        {
            DPFP.Capture.SampleConversion Convertor = new DPFP.Capture.SampleConversion();  // Create a sample convertor.
            Bitmap bitmap = null;                                                           // TODO: the size doesn't matter
            Convertor.ConvertToPicture(Sample, ref bitmap);                                 // TODO: return bitmap as a result
            return bitmap;
        }

        private void DrawPicture(Bitmap bitmap)
        {
            Picture.Image = new Bitmap(bitmap, Picture.Size);   // fit the image into the picture box           
        }

        protected DPFP.FeatureSet ExtractFeatures(DPFP.Sample Sample, DPFP.Processing.DataPurpose Purpose)
        {
            DPFP.Processing.FeatureExtraction Extractor = new DPFP.Processing.FeatureExtraction();  // Create a feature extractor
            DPFP.Capture.CaptureFeedback feedback = DPFP.Capture.CaptureFeedback.None;
            DPFP.FeatureSet features = new DPFP.FeatureSet();
            Extractor.CreateFeatureSet(Sample, Purpose, ref feedback, ref features);            // TODO: return features as a result?
            if (feedback == DPFP.Capture.CaptureFeedback.Good)
                return features;
            else
                return null;
        }

        protected virtual void Init()
        {
            try
            {
                Capturer = new DPFP.Capture.Capture();				// Create a capture operation.

                if (null != Capturer)
                    Capturer.EventHandler = this;					// Subscribe for capturing events.
                else
                    SetPrompt("Can't initiate capture operation!");
            }
            catch
            {
                MessageBox.Show("Can't initiate capture operation!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Verificator = new DPFP.Verification.Verification();		// Create a fingerprint template verificator
            }
        }

        protected void Start()
        {
            if (null != Capturer)
            {
                try
                {
                    Capturer.StartCapture();
                    SetPrompt("Using the fingerprint reader, scan your fingerprint.");
                }
                catch
                {
                    SetPrompt("Can't initiate capture!");
                }
            }
        }

        protected void Stop()
        {
            if (null != Capturer)
            {
                try
                {
                    Capturer.StopCapture();
                }
                catch
                {
                    SetPrompt("Can't terminate capture!");
                }
            }
        }

        public void OnComplete(object Capture, string ReaderSerialNumber, Sample Sample)
        {
            // Draw fingerprint sample image.
            DrawPicture(ConvertSampleToBitmap(Sample));

            DPFP.Verification.Verification.Result res = new DPFP.Verification.Verification.Result();
            // Process the sample and create a feature set for the enrollment purpose.
            DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification);

            using (YouthEmpowermentEntities context = new YouthEmpowermentEntities())
            {
                var table = (from a in context.tblPersonalDetails
                             select a).ToList();


                if (features != null)
                {
                    foreach (var row in table)
                    {
                        Template tem = new Template();
                        tem.DeSerialize(row.tblFingerprint.fingerTemplate);
                       
                        if (tem != null)
                        {
                            // Compare feature set with particular template.
                            Verificator.Verify(features, tem, ref res);

                            if (res.Verified)
                            {
                                SetStatus("Verified)");
                                fullNames(row.FirstName + row.LastName);
                                DateOfBirth(row.DOB.Value.ToShortDateString());
                                contactTown(row.tblContact.Town);
                                contactWard(row.tblContact.Ward);
                                contactNumber(row.tblContact.ContactNum1 + ", " + row.tblContact.ContactNum2);
                                contactAddress(row.tblContact.PartyAddress);
                                businessType(row.tblBusiness.BusinessType);
                                BiznessAmount(row.tblBusiness.Amount);
                                pictureBox5.Image = ByteArrayToImage(row.Picture);

                                //using (SaveFileDialog dlg = new SaveFileDialog() { Filter = "JPG |*.jpg", ValidateNames = true })
                                //{
                                //    Zen.Barcode.Code128BarcodeDraw Encorder = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;

                                //    pictureBox4.Image = Encorder.Draw(String.Format("Name: {0} Phone Number: {1} ", label61.Text + Environment.NewLine, label53.Text), 250);

                                //}

                                using (SaveFileDialog dlg = new SaveFileDialog() { Filter = "JPG |*.jpg", ValidateNames = true })
                                {
                                    MessagingToolkit.QRCode.Codec.QRCodeEncoder Encorder = new MessagingToolkit.QRCode.Codec.QRCodeEncoder();
                                    Encorder.QRCodeScale = 4;
                                    Bitmap bitmap = Encorder.Encode(String.Format("Name: {0} ContactNumber {1} ", label61.Text + Environment.NewLine, label53.Text));
                                    pictureBox4.Image = bitmap;
                                }

                                Capturer.StopCapture();
                                break; // success  
                            }


                        }

                        if (!res.Verified)
                            SetStatus("Not Registered !!!");
                    }


                }
            }

        }

        private void bunifuThinButton213_Click(object sender, EventArgs e)
        {
            Init();
            Start();
        }

        PrintDocument printdoc1 = new PrintDocument();

        PrintPreviewDialog previewdlg = new PrintPreviewDialog();
        Panel pannel = null;
        Bitmap MemoryImage;
        public void GetPrintArea(Panel pnl)
        {
            MemoryImage = new Bitmap(pnl.Width, pnl.Height);
            Rectangle rect = new Rectangle(0, 0, pnl.Width, pnl.Height);
            pnl.DrawToBitmap(MemoryImage, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (MemoryImage != null)
            {
                e.Graphics.DrawImage(MemoryImage, 0, 0);
                base.OnPaint(e);
            }
        }

        void printdoc1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(MemoryImage, (pagearea.Width / 2) - (pannel.Width / 2), pannel.Location.Y);
        }

        public void Print(Panel pnl)
        {
            printdoc1.PrintPage += new PrintPageEventHandler(printdoc1_PrintPage);

            pannel = pnl;
            GetPrintArea(pnl);
            previewdlg.Document = printdoc1;
            previewdlg.ShowDialog();
        }

        private void Printdoc1_PrintPage(object sender, PrintPageEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void tab3_Click(object sender, EventArgs e)
        {
            panelAuthenticate.BringToFront();
            panelAuthenticate.Dock = DockStyle.Fill;

            panelDashboard.SendToBack();
            

            panelMainMenu.Width = 48;
        }


        string rName, rTown, rWard, rContactNo, rAddress, rBiztype, rReference, rGrant;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton25_Click_1(object sender, EventArgs e)
        {
            Camera _Cam = new Camera();
            _Cam.ShowDialog();

            pictureBox1.Image = _Cam.pictureHD.Image;

        }

        DateTime rDateOfBirth, rDate;

        private void button2_Click(object sender, EventArgs e)
        {
            //Print(this.panelAuthenticate);
            ReportParameter[] param = new ReportParameter[]
            {
                new ReportParameter("rNames", rName),
                new ReportParameter("rDateOfBirth", rDateOfBirth.ToShortDateString()),
                new ReportParameter("rTown", rTown),
                new ReportParameter("rWard", rWard),
                new ReportParameter("rContactNo", rContactNo),
                new ReportParameter("rAddress", rAddress),
                new ReportParameter("rBizType", rBiztype),
                new ReportParameter("rReference", rReference),
                new ReportParameter("rGrantAmount", rGrant),
                //new ReportParameter("rDate", rDate.ToShortDateString())
                //new ReportParameter("", )
            };

            this.reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            string exeFolder = System.IO.Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
            
            this.reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = "../../Report1.rdlc";
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "../../Report1.rdlc";            

            this.reportViewer1.LocalReport.SetParameters(param);
            this.reportViewer1.RefreshReport();
        }

        private void printDocument1_BeginPrint(object sender, PrintEventArgs e)
        {

        }
    }
}
