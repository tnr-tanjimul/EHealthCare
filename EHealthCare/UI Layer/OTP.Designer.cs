namespace EHealthCare.UI_Layer
{
    partial class OTP

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
            this.labelSignup = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxOtp = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.closeIcon = new System.Windows.Forms.PictureBox();
            this.buttonVerify = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelRight = new System.Windows.Forms.Panel();
            this.btnReSend = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iconLogo = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.closeIcon)).BeginInit();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnReSend)).BeginInit();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSignup
            // 
            this.labelSignup.AutoSize = true;
            this.labelSignup.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(88)))));
            this.labelSignup.Location = new System.Drawing.Point(30, 51);
            this.labelSignup.Name = "labelSignup";
            this.labelSignup.Size = new System.Drawing.Size(194, 28);
            this.labelSignup.TabIndex = 0;
            this.labelSignup.Text = "2FA Verification";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(88)))));
            this.labelUsername.Location = new System.Drawing.Point(66, 227);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(45, 21);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "OTP:";
            // 
            // textBoxOtp
            // 
            this.textBoxOtp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.textBoxOtp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxOtp.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBoxOtp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxOtp.HintForeColor = System.Drawing.Color.Empty;
            this.textBoxOtp.HintText = "XXXXXX";
            this.textBoxOtp.isPassword = false;
            this.textBoxOtp.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(88)))));
            this.textBoxOtp.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(88)))));
            this.textBoxOtp.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(88)))));
            this.textBoxOtp.LineThickness = 3;
            this.textBoxOtp.Location = new System.Drawing.Point(94, 249);
            this.textBoxOtp.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOtp.Name = "textBoxOtp";
            this.textBoxOtp.Size = new System.Drawing.Size(206, 27);
            this.textBoxOtp.TabIndex = 1;
            this.textBoxOtp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // closeIcon
            // 
            this.closeIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeIcon.Image = global::EHealthCare.Properties.Resources.icons8_delete_32px;
            this.closeIcon.Location = new System.Drawing.Point(294, 28);
            this.closeIcon.Margin = new System.Windows.Forms.Padding(2);
            this.closeIcon.Name = "closeIcon";
            this.closeIcon.Size = new System.Drawing.Size(22, 24);
            this.closeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeIcon.TabIndex = 2;
            this.closeIcon.TabStop = false;
            this.closeIcon.Click += new System.EventHandler(this.closeIcon_Click);
            // 
            // buttonVerify
            // 
            this.buttonVerify.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(75)))), ((int)(((byte)(79)))));
            this.buttonVerify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(75)))), ((int)(((byte)(79)))));
            this.buttonVerify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonVerify.BorderRadius = 0;
            this.buttonVerify.ButtonText = "Verify";
            this.buttonVerify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVerify.DisabledColor = System.Drawing.Color.Gray;
            this.buttonVerify.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonVerify.Iconimage = null;
            this.buttonVerify.Iconimage_right = null;
            this.buttonVerify.Iconimage_right_Selected = null;
            this.buttonVerify.Iconimage_Selected = null;
            this.buttonVerify.IconMarginLeft = 0;
            this.buttonVerify.IconMarginRight = 0;
            this.buttonVerify.IconRightVisible = true;
            this.buttonVerify.IconRightZoom = 0D;
            this.buttonVerify.IconVisible = true;
            this.buttonVerify.IconZoom = 90D;
            this.buttonVerify.IsTab = false;
            this.buttonVerify.Location = new System.Drawing.Point(112, 321);
            this.buttonVerify.Margin = new System.Windows.Forms.Padding(4);
            this.buttonVerify.Name = "buttonVerify";
            this.buttonVerify.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(75)))), ((int)(((byte)(79)))));
            this.buttonVerify.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(84)))), ((int)(((byte)(83)))));
            this.buttonVerify.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonVerify.selected = false;
            this.buttonVerify.Size = new System.Drawing.Size(188, 37);
            this.buttonVerify.TabIndex = 2;
            this.buttonVerify.Text = "Verify";
            this.buttonVerify.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonVerify.Textcolor = System.Drawing.Color.White;
            this.buttonVerify.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVerify.Click += new System.EventHandler(this.buttonVerify_Click);
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.SystemColors.Control;
            this.panelRight.Controls.Add(this.btnReSend);
            this.panelRight.Controls.Add(this.buttonVerify);
            this.panelRight.Controls.Add(this.closeIcon);
            this.panelRight.Controls.Add(this.textBoxOtp);
            this.panelRight.Controls.Add(this.labelUsername);
            this.panelRight.Controls.Add(this.label3);
            this.panelRight.Controls.Add(this.labelSignup);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(346, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(346, 604);
            this.panelRight.TabIndex = 0;
            this.panelRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelRight_MouseDown);
            this.panelRight.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelRight_MouseMove);
            // 
            // btnReSend
            // 
            this.btnReSend.Image = global::EHealthCare.Properties.Resources.refresh_32px;
            this.btnReSend.Location = new System.Drawing.Point(70, 321);
            this.btnReSend.Name = "btnReSend";
            this.btnReSend.Size = new System.Drawing.Size(30, 30);
            this.btnReSend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnReSend.TabIndex = 3;
            this.btnReSend.TabStop = false;
            this.btnReSend.Click += new System.EventHandler(this.btnReSend_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Colonna MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(77, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 34);
            this.label3.TabIndex = 0;
            this.label3.Text = "OTP Has been send to your \r\nregistered phone number";
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(88)))));
            this.panelLeft.Controls.Add(this.label2);
            this.panelLeft.Controls.Add(this.label1);
            this.panelLeft.Controls.Add(this.iconLogo);
            this.panelLeft.Controls.Add(this.labelTitle);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(346, 604);
            this.panelLeft.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "24/7 HeathCare Service\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // iconLogo
            // 
            this.iconLogo.Image = global::EHealthCare.Properties.Resources.icon_main3;
            this.iconLogo.Location = new System.Drawing.Point(104, 89);
            this.iconLogo.Name = "iconLogo";
            this.iconLogo.Size = new System.Drawing.Size(101, 110);
            this.iconLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconLogo.TabIndex = 2;
            this.iconLogo.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(88)))));
            this.labelTitle.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(62, 227);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(174, 27);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = " EHealthCare";
            // 
            // OTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(692, 604);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelRight);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OTP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.closeIcon)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnReSend)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelSignup;
        private System.Windows.Forms.Label labelUsername;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxOtp;
        private System.Windows.Forms.PictureBox closeIcon;
        private Bunifu.Framework.UI.BunifuFlatButton buttonVerify;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox iconLogo;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox btnReSend;
        private System.Windows.Forms.Label label3;
    }
}

