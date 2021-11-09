namespace EHealthCare.UI_Layer
{
    partial class PatientRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientRegistration));
            this.panelRight = new System.Windows.Forms.Panel();
            this.dateTimePickerDOB = new Bunifu.Framework.UI.BunifuDatepicker();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.checkboxTerms = new Bunifu.Framework.UI.BunifuCheckbox();
            this.textBoxMobileNo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAddress = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.textBoxFullName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelMobileNo = new System.Windows.Forms.Label();
            this.labelFullName = new System.Windows.Forms.Label();
            this.labelSignup = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.iconLogo = new System.Windows.Forms.PictureBox();
            this.closeIcon = new System.Windows.Forms.PictureBox();
            this.panelRight.SuspendLayout();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.SystemColors.Control;
            this.panelRight.Controls.Add(this.dateTimePickerDOB);
            this.panelRight.Controls.Add(this.buttonRegister);
            this.panelRight.Controls.Add(this.checkboxTerms);
            this.panelRight.Controls.Add(this.closeIcon);
            this.panelRight.Controls.Add(this.textBoxMobileNo);
            this.panelRight.Controls.Add(this.label3);
            this.panelRight.Controls.Add(this.textBoxAddress);
            this.panelRight.Controls.Add(this.textBoxFullName);
            this.panelRight.Controls.Add(this.label4);
            this.panelRight.Controls.Add(this.labelAddress);
            this.panelRight.Controls.Add(this.labelMobileNo);
            this.panelRight.Controls.Add(this.labelFullName);
            this.panelRight.Controls.Add(this.labelSignup);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(462, 0);
            this.panelRight.Margin = new System.Windows.Forms.Padding(4);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(461, 743);
            this.panelRight.TabIndex = 0;
            this.panelRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelRight_MouseDown);
            this.panelRight.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelRight_MouseMove);
            // 
            // dateTimePickerDOB
            // 
            this.dateTimePickerDOB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(88)))));
            this.dateTimePickerDOB.BorderRadius = 0;
            this.dateTimePickerDOB.ForeColor = System.Drawing.Color.White;
            this.dateTimePickerDOB.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePickerDOB.FormatCustom = null;
            this.dateTimePickerDOB.Location = new System.Drawing.Point(71, 430);
            this.dateTimePickerDOB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerDOB.Name = "dateTimePickerDOB";
            this.dateTimePickerDOB.Size = new System.Drawing.Size(352, 36);
            this.dateTimePickerDOB.TabIndex = 11;
            this.dateTimePickerDOB.Value = new System.DateTime(2020, 5, 18, 13, 40, 4, 395);
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(88)))));
            this.buttonRegister.Enabled = false;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.ForeColor = System.Drawing.Color.White;
            this.buttonRegister.Location = new System.Drawing.Point(157, 550);
            this.buttonRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(156, 46);
            this.buttonRegister.TabIndex = 9;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // checkboxTerms
            // 
            this.checkboxTerms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.checkboxTerms.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkboxTerms.Checked = false;
            this.checkboxTerms.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.checkboxTerms.ForeColor = System.Drawing.Color.White;
            this.checkboxTerms.Location = new System.Drawing.Point(71, 496);
            this.checkboxTerms.Margin = new System.Windows.Forms.Padding(5);
            this.checkboxTerms.Name = "checkboxTerms";
            this.checkboxTerms.Size = new System.Drawing.Size(20, 20);
            this.checkboxTerms.TabIndex = 8;
            this.checkboxTerms.OnChange += new System.EventHandler(this.checkboxTerms_OnChange);
            // 
            // textBoxMobileNo
            // 
            this.textBoxMobileNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.textBoxMobileNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxMobileNo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBoxMobileNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxMobileNo.HintForeColor = System.Drawing.Color.Empty;
            this.textBoxMobileNo.HintText = "Mobile No";
            this.textBoxMobileNo.isPassword = false;
            this.textBoxMobileNo.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.textBoxMobileNo.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(75)))), ((int)(((byte)(79)))));
            this.textBoxMobileNo.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(75)))), ((int)(((byte)(79)))));
            this.textBoxMobileNo.LineThickness = 3;
            this.textBoxMobileNo.Location = new System.Drawing.Point(71, 270);
            this.textBoxMobileNo.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxMobileNo.Name = "textBoxMobileNo";
            this.textBoxMobileNo.Size = new System.Drawing.Size(352, 33);
            this.textBoxMobileNo.TabIndex = 2;
            this.textBoxMobileNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(88)))));
            this.label3.Location = new System.Drawing.Point(119, 493);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Accept Tems and Conditions\r\n";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.textBoxAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxAddress.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBoxAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxAddress.HintForeColor = System.Drawing.Color.Empty;
            this.textBoxAddress.HintText = "Address";
            this.textBoxAddress.isPassword = false;
            this.textBoxAddress.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.textBoxAddress.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(75)))), ((int)(((byte)(79)))));
            this.textBoxAddress.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(75)))), ((int)(((byte)(79)))));
            this.textBoxAddress.LineThickness = 3;
            this.textBoxAddress.Location = new System.Drawing.Point(71, 351);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(352, 33);
            this.textBoxAddress.TabIndex = 3;
            this.textBoxAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.textBoxFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxFullName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBoxFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxFullName.HintForeColor = System.Drawing.Color.Empty;
            this.textBoxFullName.HintText = "Full Name";
            this.textBoxFullName.isPassword = false;
            this.textBoxFullName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.textBoxFullName.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(75)))), ((int)(((byte)(79)))));
            this.textBoxFullName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(75)))), ((int)(((byte)(79)))));
            this.textBoxFullName.LineThickness = 3;
            this.textBoxFullName.Location = new System.Drawing.Point(71, 193);
            this.textBoxFullName.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(352, 33);
            this.textBoxFullName.TabIndex = 1;
            this.textBoxFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(88)))));
            this.label4.Location = new System.Drawing.Point(55, 403);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "DOB:";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(88)))));
            this.labelAddress.Location = new System.Drawing.Point(55, 324);
            this.labelAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(93, 23);
            this.labelAddress.TabIndex = 0;
            this.labelAddress.Text = "Address:";
            // 
            // labelMobileNo
            // 
            this.labelMobileNo.AutoSize = true;
            this.labelMobileNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMobileNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(88)))));
            this.labelMobileNo.Location = new System.Drawing.Point(55, 243);
            this.labelMobileNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMobileNo.Name = "labelMobileNo";
            this.labelMobileNo.Size = new System.Drawing.Size(114, 23);
            this.labelMobileNo.TabIndex = 0;
            this.labelMobileNo.Text = "Mobile No:";
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(88)))));
            this.labelFullName.Location = new System.Drawing.Point(55, 166);
            this.labelFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(114, 23);
            this.labelFullName.TabIndex = 0;
            this.labelFullName.Text = "Full Name:";
            // 
            // labelSignup
            // 
            this.labelSignup.AutoSize = true;
            this.labelSignup.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(88)))));
            this.labelSignup.Location = new System.Drawing.Point(21, 27);
            this.labelSignup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSignup.Name = "labelSignup";
            this.labelSignup.Size = new System.Drawing.Size(292, 37);
            this.labelSignup.TabIndex = 0;
            this.labelSignup.Text = "Patient Registration";
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
            this.panelLeft.Margin = new System.Windows.Forms.Padding(4);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(461, 743);
            this.panelLeft.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(39, 395);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "24/7 HeathCare Service\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 395);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 3;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(88)))));
            this.labelTitle.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(83, 279);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(217, 35);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = " EHealthCare";
            // 
            // iconLogo
            // 
            this.iconLogo.Image = global::EHealthCare.Properties.Resources.icon_main3;
            this.iconLogo.Location = new System.Drawing.Point(139, 110);
            this.iconLogo.Margin = new System.Windows.Forms.Padding(4);
            this.iconLogo.Name = "iconLogo";
            this.iconLogo.Size = new System.Drawing.Size(135, 135);
            this.iconLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconLogo.TabIndex = 2;
            this.iconLogo.TabStop = false;
            // 
            // closeIcon
            // 
            this.closeIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeIcon.Image = global::EHealthCare.Properties.Resources.icons8_delete_32px;
            this.closeIcon.Location = new System.Drawing.Point(392, 34);
            this.closeIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeIcon.Name = "closeIcon";
            this.closeIcon.Size = new System.Drawing.Size(29, 30);
            this.closeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeIcon.TabIndex = 2;
            this.closeIcon.TabStop = false;
            this.closeIcon.Click += new System.EventHandler(this.closeIcon_Click);
            // 
            // PatientRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(923, 743);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelRight);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PatientRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Label labelSignup;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxFullName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxMobileNo;
        private System.Windows.Forms.Label labelMobileNo;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.PictureBox closeIcon;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxAddress;
        private System.Windows.Forms.Button buttonRegister;
        private Bunifu.Framework.UI.BunifuCheckbox checkboxTerms;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox iconLogo;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuDatepicker dateTimePickerDOB;
    }
}

