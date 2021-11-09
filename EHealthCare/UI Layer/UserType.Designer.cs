namespace EHealthCare.UI_Layer
{
    partial class UserType

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserType));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.btnDoctor = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonPatient = new Bunifu.Framework.UI.BunifuFlatButton();
            this.closeIcon = new System.Windows.Forms.PictureBox();
            this.iconLogo = new System.Windows.Forms.PictureBox();
            this.labelSignup = new System.Windows.Forms.Label();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconLogo)).BeginInit();
            this.SuspendLayout();
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
            this.panelLeft.TabIndex = 0;
            this.panelLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLeft_MouseDown);
            this.panelLeft.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelLeft_MouseMove);
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
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.SystemColors.Control;
            this.panelRight.Controls.Add(this.labelSignup);
            this.panelRight.Controls.Add(this.btnDoctor);
            this.panelRight.Controls.Add(this.buttonPatient);
            this.panelRight.Controls.Add(this.closeIcon);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(461, 0);
            this.panelRight.Margin = new System.Windows.Forms.Padding(4);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(462, 743);
            this.panelRight.TabIndex = 0;
            this.panelRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelRight_MouseDown);
            this.panelRight.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelRight_MouseMove);
            // 
            // btnDoctor
            // 
            this.btnDoctor.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(75)))), ((int)(((byte)(79)))));
            this.btnDoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(88)))));
            this.btnDoctor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDoctor.BorderRadius = 0;
            this.btnDoctor.ButtonText = "Doctor";
            this.btnDoctor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoctor.DisabledColor = System.Drawing.Color.Gray;
            this.btnDoctor.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDoctor.Iconimage = null;
            this.btnDoctor.Iconimage_right = null;
            this.btnDoctor.Iconimage_right_Selected = null;
            this.btnDoctor.Iconimage_Selected = null;
            this.btnDoctor.IconMarginLeft = 0;
            this.btnDoctor.IconMarginRight = 0;
            this.btnDoctor.IconRightVisible = true;
            this.btnDoctor.IconRightZoom = 0D;
            this.btnDoctor.IconVisible = true;
            this.btnDoctor.IconZoom = 90D;
            this.btnDoctor.IsTab = false;
            this.btnDoctor.Location = new System.Drawing.Point(255, 366);
            this.btnDoctor.Margin = new System.Windows.Forms.Padding(5);
            this.btnDoctor.Name = "btnDoctor";
            this.btnDoctor.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(88)))));
            this.btnDoctor.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(84)))), ((int)(((byte)(83)))));
            this.btnDoctor.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDoctor.selected = false;
            this.btnDoctor.Size = new System.Drawing.Size(149, 46);
            this.btnDoctor.TabIndex = 5;
            this.btnDoctor.Text = "Doctor";
            this.btnDoctor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDoctor.Textcolor = System.Drawing.Color.White;
            this.btnDoctor.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctor.Click += new System.EventHandler(this.btnDoctor_Click);
            // 
            // buttonPatient
            // 
            this.buttonPatient.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(88)))));
            this.buttonPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(88)))));
            this.buttonPatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPatient.BorderRadius = 0;
            this.buttonPatient.ButtonText = "Patient";
            this.buttonPatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPatient.DisabledColor = System.Drawing.Color.Gray;
            this.buttonPatient.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonPatient.Iconimage = null;
            this.buttonPatient.Iconimage_right = null;
            this.buttonPatient.Iconimage_right_Selected = null;
            this.buttonPatient.Iconimage_Selected = null;
            this.buttonPatient.IconMarginLeft = 0;
            this.buttonPatient.IconMarginRight = 0;
            this.buttonPatient.IconRightVisible = true;
            this.buttonPatient.IconRightZoom = 0D;
            this.buttonPatient.IconVisible = true;
            this.buttonPatient.IconZoom = 90D;
            this.buttonPatient.IsTab = false;
            this.buttonPatient.Location = new System.Drawing.Point(70, 366);
            this.buttonPatient.Margin = new System.Windows.Forms.Padding(5);
            this.buttonPatient.Name = "buttonPatient";
            this.buttonPatient.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(88)))));
            this.buttonPatient.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(84)))), ((int)(((byte)(83)))));
            this.buttonPatient.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonPatient.selected = false;
            this.buttonPatient.Size = new System.Drawing.Size(149, 46);
            this.buttonPatient.TabIndex = 4;
            this.buttonPatient.Text = "Patient";
            this.buttonPatient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonPatient.Textcolor = System.Drawing.Color.White;
            this.buttonPatient.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPatient.Click += new System.EventHandler(this.buttonPatient_Click);
            // 
            // closeIcon
            // 
            this.closeIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeIcon.Image = global::EHealthCare.Properties.Resources.icons8_delete_32px;
            this.closeIcon.Location = new System.Drawing.Point(393, 34);
            this.closeIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeIcon.Name = "closeIcon";
            this.closeIcon.Size = new System.Drawing.Size(29, 30);
            this.closeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeIcon.TabIndex = 2;
            this.closeIcon.TabStop = false;
            this.closeIcon.Click += new System.EventHandler(this.closeIcon_Click);
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
            // labelSignup
            // 
            this.labelSignup.AutoSize = true;
            this.labelSignup.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(88)))));
            this.labelSignup.Location = new System.Drawing.Point(44, 110);
            this.labelSignup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSignup.Name = "labelSignup";
            this.labelSignup.Size = new System.Drawing.Size(155, 37);
            this.labelSignup.TabIndex = 6;
            this.labelSignup.Text = "User Type";
            // 
            // UserType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(923, 743);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox iconLogo;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox closeIcon;
        private Bunifu.Framework.UI.BunifuFlatButton buttonPatient;
        private Bunifu.Framework.UI.BunifuFlatButton btnDoctor;
        private System.Windows.Forms.Label labelSignup;
    }
}

