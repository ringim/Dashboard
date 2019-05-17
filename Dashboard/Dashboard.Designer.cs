namespace Dashboard
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation9 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.tab1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelMainMenu = new System.Windows.Forms.Panel();
            this.tab6 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tab5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tab4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tab3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tab2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MouseDetect = new System.Windows.Forms.Timer(this.components);
            this.submenu1 = new global::Dashboard.Submenu();
            this.panelMainMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(100)))), ((int)(((byte)(52)))));
            this.tab1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(100)))), ((int)(((byte)(52)))));
            this.tab1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab1.BorderRadius = 0;
            this.tab1.ButtonText = "               Dashboard";
            this.tab1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.tab1, BunifuAnimatorNS.DecorationType.None);
            this.tab1.DisabledColor = System.Drawing.Color.Gray;
            this.tab1.Iconcolor = System.Drawing.Color.Transparent;
            this.tab1.Iconimage = ((System.Drawing.Image)(resources.GetObject("tab1.Iconimage")));
            this.tab1.Iconimage_right = null;
            this.tab1.Iconimage_right_Selected = null;
            this.tab1.Iconimage_Selected = null;
            this.tab1.IconMarginLeft = 0;
            this.tab1.IconMarginRight = 0;
            this.tab1.IconRightVisible = true;
            this.tab1.IconRightZoom = 0D;
            this.tab1.IconVisible = true;
            this.tab1.IconZoom = 40D;
            this.tab1.IsTab = true;
            this.tab1.Location = new System.Drawing.Point(0, 78);
            this.tab1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab1.Name = "tab1";
            this.tab1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(134)))), ((int)(((byte)(52)))));
            this.tab1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(100)))), ((int)(((byte)(52)))));
            this.tab1.OnHoverTextColor = System.Drawing.Color.White;
            this.tab1.selected = true;
            this.tab1.Size = new System.Drawing.Size(227, 59);
            this.tab1.TabIndex = 0;
            this.tab1.Tag = "0";
            this.tab1.Text = "               Dashboard";
            this.tab1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab1.Textcolor = System.Drawing.Color.White;
            this.tab1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab1.Click += new System.EventHandler(this.sideMenu_Click);
            // 
            // panelMainMenu
            // 
            this.panelMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(134)))), ((int)(((byte)(52)))));
            this.panelMainMenu.Controls.Add(this.tab6);
            this.panelMainMenu.Controls.Add(this.tab5);
            this.panelMainMenu.Controls.Add(this.tab4);
            this.panelMainMenu.Controls.Add(this.tab3);
            this.panelMainMenu.Controls.Add(this.tab2);
            this.panelMainMenu.Controls.Add(this.tab1);
            this.bunifuTransition1.SetDecoration(this.panelMainMenu, BunifuAnimatorNS.DecorationType.None);
            this.panelMainMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMainMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMainMenu.Name = "panelMainMenu";
            this.panelMainMenu.Size = new System.Drawing.Size(65, 716);
            this.panelMainMenu.TabIndex = 1;
            this.panelMainMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMainMenu_Paint);
            this.panelMainMenu.MouseHover += new System.EventHandler(this.MouseDetect_Tick);
            // 
            // tab6
            // 
            this.tab6.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(100)))), ((int)(((byte)(52)))));
            this.tab6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(134)))), ((int)(((byte)(52)))));
            this.tab6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab6.BorderRadius = 0;
            this.tab6.ButtonText = "               Help";
            this.tab6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.tab6, BunifuAnimatorNS.DecorationType.None);
            this.tab6.DisabledColor = System.Drawing.Color.Gray;
            this.tab6.Iconcolor = System.Drawing.Color.Transparent;
            this.tab6.Iconimage = ((System.Drawing.Image)(resources.GetObject("tab6.Iconimage")));
            this.tab6.Iconimage_right = null;
            this.tab6.Iconimage_right_Selected = null;
            this.tab6.Iconimage_Selected = null;
            this.tab6.IconMarginLeft = 0;
            this.tab6.IconMarginRight = 0;
            this.tab6.IconRightVisible = true;
            this.tab6.IconRightZoom = 0D;
            this.tab6.IconVisible = true;
            this.tab6.IconZoom = 40D;
            this.tab6.IsTab = true;
            this.tab6.Location = new System.Drawing.Point(0, 413);
            this.tab6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab6.Name = "tab6";
            this.tab6.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(134)))), ((int)(((byte)(52)))));
            this.tab6.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(100)))), ((int)(((byte)(52)))));
            this.tab6.OnHoverTextColor = System.Drawing.Color.White;
            this.tab6.selected = false;
            this.tab6.Size = new System.Drawing.Size(227, 59);
            this.tab6.TabIndex = 0;
            this.tab6.Tag = "5";
            this.tab6.Text = "               Help";
            this.tab6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab6.Textcolor = System.Drawing.Color.White;
            this.tab6.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab6.Click += new System.EventHandler(this.sideMenu_Click);
            // 
            // tab5
            // 
            this.tab5.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(100)))), ((int)(((byte)(52)))));
            this.tab5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(134)))), ((int)(((byte)(52)))));
            this.tab5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab5.BorderRadius = 0;
            this.tab5.ButtonText = "               Settings";
            this.tab5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.tab5, BunifuAnimatorNS.DecorationType.None);
            this.tab5.DisabledColor = System.Drawing.Color.Gray;
            this.tab5.Iconcolor = System.Drawing.Color.Transparent;
            this.tab5.Iconimage = ((System.Drawing.Image)(resources.GetObject("tab5.Iconimage")));
            this.tab5.Iconimage_right = null;
            this.tab5.Iconimage_right_Selected = null;
            this.tab5.Iconimage_Selected = null;
            this.tab5.IconMarginLeft = 0;
            this.tab5.IconMarginRight = 0;
            this.tab5.IconRightVisible = true;
            this.tab5.IconRightZoom = 0D;
            this.tab5.IconVisible = true;
            this.tab5.IconZoom = 40D;
            this.tab5.IsTab = true;
            this.tab5.Location = new System.Drawing.Point(0, 346);
            this.tab5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab5.Name = "tab5";
            this.tab5.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(134)))), ((int)(((byte)(52)))));
            this.tab5.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(100)))), ((int)(((byte)(52)))));
            this.tab5.OnHoverTextColor = System.Drawing.Color.White;
            this.tab5.selected = false;
            this.tab5.Size = new System.Drawing.Size(227, 59);
            this.tab5.TabIndex = 0;
            this.tab5.Tag = "4";
            this.tab5.Text = "               Settings";
            this.tab5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab5.Textcolor = System.Drawing.Color.White;
            this.tab5.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab5.Click += new System.EventHandler(this.sideMenu_Click);
            // 
            // tab4
            // 
            this.tab4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(100)))), ((int)(((byte)(52)))));
            this.tab4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(134)))), ((int)(((byte)(52)))));
            this.tab4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab4.BorderRadius = 0;
            this.tab4.ButtonText = "               Report";
            this.tab4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.tab4, BunifuAnimatorNS.DecorationType.None);
            this.tab4.DisabledColor = System.Drawing.Color.Gray;
            this.tab4.Iconcolor = System.Drawing.Color.Transparent;
            this.tab4.Iconimage = ((System.Drawing.Image)(resources.GetObject("tab4.Iconimage")));
            this.tab4.Iconimage_right = null;
            this.tab4.Iconimage_right_Selected = null;
            this.tab4.Iconimage_Selected = null;
            this.tab4.IconMarginLeft = 0;
            this.tab4.IconMarginRight = 0;
            this.tab4.IconRightVisible = true;
            this.tab4.IconRightZoom = 0D;
            this.tab4.IconVisible = true;
            this.tab4.IconZoom = 40D;
            this.tab4.IsTab = true;
            this.tab4.Location = new System.Drawing.Point(0, 279);
            this.tab4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab4.Name = "tab4";
            this.tab4.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(134)))), ((int)(((byte)(52)))));
            this.tab4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(100)))), ((int)(((byte)(52)))));
            this.tab4.OnHoverTextColor = System.Drawing.Color.White;
            this.tab4.selected = false;
            this.tab4.Size = new System.Drawing.Size(227, 59);
            this.tab4.TabIndex = 0;
            this.tab4.Tag = "3";
            this.tab4.Text = "               Report";
            this.tab4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab4.Textcolor = System.Drawing.Color.White;
            this.tab4.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab4.Click += new System.EventHandler(this.sideMenu_Click);
            // 
            // tab3
            // 
            this.tab3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(100)))), ((int)(((byte)(52)))));
            this.tab3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(134)))), ((int)(((byte)(52)))));
            this.tab3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab3.BorderRadius = 0;
            this.tab3.ButtonText = "               Members";
            this.tab3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.tab3, BunifuAnimatorNS.DecorationType.None);
            this.tab3.DisabledColor = System.Drawing.Color.Gray;
            this.tab3.Iconcolor = System.Drawing.Color.Transparent;
            this.tab3.Iconimage = ((System.Drawing.Image)(resources.GetObject("tab3.Iconimage")));
            this.tab3.Iconimage_right = null;
            this.tab3.Iconimage_right_Selected = null;
            this.tab3.Iconimage_Selected = null;
            this.tab3.IconMarginLeft = 0;
            this.tab3.IconMarginRight = 0;
            this.tab3.IconRightVisible = true;
            this.tab3.IconRightZoom = 0D;
            this.tab3.IconVisible = true;
            this.tab3.IconZoom = 40D;
            this.tab3.IsTab = true;
            this.tab3.Location = new System.Drawing.Point(0, 212);
            this.tab3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab3.Name = "tab3";
            this.tab3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(134)))), ((int)(((byte)(52)))));
            this.tab3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(100)))), ((int)(((byte)(52)))));
            this.tab3.OnHoverTextColor = System.Drawing.Color.White;
            this.tab3.selected = false;
            this.tab3.Size = new System.Drawing.Size(227, 59);
            this.tab3.TabIndex = 0;
            this.tab3.Tag = "2";
            this.tab3.Text = "               Members";
            this.tab3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab3.Textcolor = System.Drawing.Color.White;
            this.tab3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab3.Click += new System.EventHandler(this.sideMenu_Click);
            // 
            // tab2
            // 
            this.tab2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(100)))), ((int)(((byte)(52)))));
            this.tab2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(134)))), ((int)(((byte)(52)))));
            this.tab2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab2.BorderRadius = 0;
            this.tab2.ButtonText = "               Books";
            this.tab2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.tab2, BunifuAnimatorNS.DecorationType.None);
            this.tab2.DisabledColor = System.Drawing.Color.Gray;
            this.tab2.Iconcolor = System.Drawing.Color.Transparent;
            this.tab2.Iconimage = ((System.Drawing.Image)(resources.GetObject("tab2.Iconimage")));
            this.tab2.Iconimage_right = null;
            this.tab2.Iconimage_right_Selected = null;
            this.tab2.Iconimage_Selected = null;
            this.tab2.IconMarginLeft = 0;
            this.tab2.IconMarginRight = 0;
            this.tab2.IconRightVisible = true;
            this.tab2.IconRightZoom = 0D;
            this.tab2.IconVisible = true;
            this.tab2.IconZoom = 40D;
            this.tab2.IsTab = true;
            this.tab2.Location = new System.Drawing.Point(0, 145);
            this.tab2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab2.Name = "tab2";
            this.tab2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(134)))), ((int)(((byte)(52)))));
            this.tab2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(100)))), ((int)(((byte)(52)))));
            this.tab2.OnHoverTextColor = System.Drawing.Color.White;
            this.tab2.selected = false;
            this.tab2.Size = new System.Drawing.Size(227, 59);
            this.tab2.TabIndex = 0;
            this.tab2.Tag = "1";
            this.tab2.Text = "               Books";
            this.tab2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab2.Textcolor = System.Drawing.Color.White;
            this.tab2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab2.Click += new System.EventHandler(this.sideMenu_Click);
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.bunifuTransition1.Cursor = null;
            animation9.AnimateOnlyDifferences = true;
            animation9.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation9.BlindCoeff")));
            animation9.LeafCoeff = 0F;
            animation9.MaxTime = 1F;
            animation9.MinTime = 0F;
            animation9.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation9.MosaicCoeff")));
            animation9.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation9.MosaicShift")));
            animation9.MosaicSize = 1;
            animation9.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation9.RotateCoeff = 0F;
            animation9.RotateLimit = 0F;
            animation9.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation9.ScaleCoeff")));
            animation9.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation9.SlideCoeff")));
            animation9.TimeCoeff = 2F;
            animation9.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.submenu1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(65, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 716);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MouseDetect
            // 
            this.MouseDetect.Enabled = true;
            this.MouseDetect.Tag = "";
            this.MouseDetect.Tick += new System.EventHandler(this.MouseDetect_Tick);
            // 
            // submenu1
            // 
            this.bunifuTransition1.SetDecoration(this.submenu1, BunifuAnimatorNS.DecorationType.None);
            this.submenu1.Location = new System.Drawing.Point(0, 78);
            this.submenu1.Name = "submenu1";
            this.submenu1.Size = new System.Drawing.Size(242, 638);
            this.submenu1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1199, 716);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMainMenu);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMainMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton tab1;
        private System.Windows.Forms.Panel panelMainMenu;
        private Bunifu.Framework.UI.BunifuFlatButton tab5;
        private Bunifu.Framework.UI.BunifuFlatButton tab4;
        private Bunifu.Framework.UI.BunifuFlatButton tab3;
        private Bunifu.Framework.UI.BunifuFlatButton tab2;
        private Bunifu.Framework.UI.BunifuFlatButton tab6;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.Timer MouseDetect;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Submenu submenu1;
    }
}

