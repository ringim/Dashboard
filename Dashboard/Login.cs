using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            Data = new AppData();                               // Create the application data object
            Data.OnChange += delegate { ExchangeData(false); }; // Track data changes to keep the form synchronized
            Registrar = new Dashboard(Data);

            Enroller = new EnrollmentForm(Data);
            ExchangeData(false);
        }

        private AppData Data;
        FormControls formcontrol = new FormControls();

        // Simple dialog data exchange (DDX) implementation.
        private void ExchangeData(bool read)
        {
            if (read)
            {   // read values from the form's controls to the data object
                Data.EnrolledFingersMask = formcontrol.EnrolledFingersMask;
                Data.MaxEnrollFingerCount = formcontrol.MaxEnrollFingerCount;
                Data.IsEventHandlerSucceeds = formcontrol.IsEventHandlerSucceeds;
                Data.Update();
            }
            else
            {   // read valuse from the data object to the form's controls

                formcontrol.EnrolledFingersMask = Data.EnrolledFingersMask;
                formcontrol.MaxEnrollFingerCount = Data.MaxEnrollFingerCount;
                formcontrol.IsEventHandlerSucceeds = Data.IsEventHandlerSucceeds;
                // IsFailure.Checked = !IsSuccess.Checked;
                formcontrol.IsFeatureSetMatched = Data.IsFeatureSetMatched;
                formcontrol.FalseAcceptRate = Data.FalseAcceptRate;
                // VerifyButton.Enabled = Data.EnrolledFingersMask > 0;
            }

        }

        //Initializing some Forms might slow their loading because they would be reinitialized onTheForm Loading 
        private EnrollmentForm Enroller;

        private Dashboard Registrar;

        private void button1_Click(object sender, EventArgs e)
        {
            if(bunifuMetroTextbox1.Text == "admin" && bunifuMetroTextbox2.Text == "Xfhe3d1bQ1")
            {
                ExchangeData(true);
                Registrar = new Dashboard(Data);
                Registrar.Show();
                this.Hide();
            }
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.MinimizeBox = true;
        }
    }
}
