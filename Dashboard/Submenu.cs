using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KimtToo.VisualReactive;

namespace Dashboard
{
    public partial class Submenu : UserControl
    {
        public Submenu()
        {
            InitializeComponent();
            if (Program.IsDesignMode()) return;
            pnlHider.Height = 2;

            VSReactive<int>.Subscribe("menu", e => tabControl1.SelectedIndex = e);

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void Submenu_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
