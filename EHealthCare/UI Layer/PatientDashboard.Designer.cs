namespace EHealthCare.UI_Layer
{
    partial class PatientDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientDashboard));
            this.menuVertical = new System.Windows.Forms.Panel();
            this.labelDisplay = new System.Windows.Forms.Label();
            this.titleBar = new System.Windows.Forms.Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.iconRestore = new System.Windows.Forms.PictureBox();
            this.iconMinimize = new System.Windows.Forms.PictureBox();
            this.iconMaximize = new System.Windows.Forms.PictureBox();
            this.iconClose = new System.Windows.Forms.PictureBox();
            this.btnSlide = new System.Windows.Forms.PictureBox();
            this.btnFeverRecors = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnBpRecords = new System.Windows.Forms.Button();
            this.btnMyHistory = new System.Windows.Forms.Button();
            this.btnAppoinments = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuVertical.SuspendLayout();
            this.titleBar.SuspendLayout();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconRestore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuVertical
            // 
            this.menuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(88)))));
            this.menuVertical.Controls.Add(this.btnFeverRecors);
            this.menuVertical.Controls.Add(this.button2);
            this.menuVertical.Controls.Add(this.button1);
            this.menuVertical.Controls.Add(this.button4);
            this.menuVertical.Controls.Add(this.btnSettings);
            this.menuVertical.Controls.Add(this.btnBpRecords);
            this.menuVertical.Controls.Add(this.btnMyHistory);
            this.menuVertical.Controls.Add(this.btnAppoinments);
            this.menuVertical.Controls.Add(this.btnHome);
            this.menuVertical.Controls.Add(this.labelDisplay);
            this.menuVertical.Controls.Add(this.pictureBox1);
            this.menuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuVertical.Location = new System.Drawing.Point(0, 0);
            this.menuVertical.Margin = new System.Windows.Forms.Padding(2);
            this.menuVertical.Name = "menuVertical";
            this.menuVertical.Size = new System.Drawing.Size(245, 620);
            this.menuVertical.TabIndex = 0;
            // 
            // labelDisplay
            // 
            this.labelDisplay.AutoSize = true;
            this.labelDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(88)))));
            this.labelDisplay.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisplay.ForeColor = System.Drawing.Color.White;
            this.labelDisplay.Location = new System.Drawing.Point(80, 10);
            this.labelDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDisplay.Name = "labelDisplay";
            this.labelDisplay.Size = new System.Drawing.Size(143, 30);
            this.labelDisplay.TabIndex = 1;
            this.labelDisplay.Text = "Dashboard";
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.titleBar.Controls.Add(this.iconRestore);
            this.titleBar.Controls.Add(this.iconMinimize);
            this.titleBar.Controls.Add(this.iconMaximize);
            this.titleBar.Controls.Add(this.iconClose);
            this.titleBar.Controls.Add(this.btnSlide);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(245, 0);
            this.titleBar.Margin = new System.Windows.Forms.Padding(2);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(805, 45);
            this.titleBar.TabIndex = 1;
            this.titleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseDown);
            this.titleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseMove);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelContainer.Controls.Add(this.pictureBox2);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(245, 45);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(805, 575);
            this.panelContainer.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::EHealthCare.Properties.Resources.stay_home;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(805, 575);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // iconRestore
            // 
            this.iconRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconRestore.Image = global::EHealthCare.Properties.Resources.restore_window_32px;
            this.iconRestore.Location = new System.Drawing.Point(737, 10);
            this.iconRestore.Name = "iconRestore";
            this.iconRestore.Size = new System.Drawing.Size(25, 25);
            this.iconRestore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconRestore.TabIndex = 1;
            this.iconRestore.TabStop = false;
            this.iconRestore.Visible = false;
            this.iconRestore.Click += new System.EventHandler(this.iconRestore_Click);
            // 
            // iconMinimize
            // 
            this.iconMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconMinimize.Image = global::EHealthCare.Properties.Resources.minimize_window_32px;
            this.iconMinimize.Location = new System.Drawing.Point(706, 10);
            this.iconMinimize.Name = "iconMinimize";
            this.iconMinimize.Size = new System.Drawing.Size(25, 25);
            this.iconMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconMinimize.TabIndex = 1;
            this.iconMinimize.TabStop = false;
            this.iconMinimize.Click += new System.EventHandler(this.iconMinimize_Click);
            // 
            // iconMaximize
            // 
            this.iconMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconMaximize.Image = global::EHealthCare.Properties.Resources.maximize_window_32px;
            this.iconMaximize.Location = new System.Drawing.Point(737, 10);
            this.iconMaximize.Name = "iconMaximize";
            this.iconMaximize.Size = new System.Drawing.Size(25, 25);
            this.iconMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconMaximize.TabIndex = 1;
            this.iconMaximize.TabStop = false;
            this.iconMaximize.Click += new System.EventHandler(this.iconMaximize_Click);
            // 
            // iconClose
            // 
            this.iconClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconClose.Image = global::EHealthCare.Properties.Resources.close_window_32px;
            this.iconClose.Location = new System.Drawing.Point(768, 10);
            this.iconClose.Name = "iconClose";
            this.iconClose.Size = new System.Drawing.Size(25, 25);
            this.iconClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconClose.TabIndex = 1;
            this.iconClose.TabStop = false;
            this.iconClose.Click += new System.EventHandler(this.iconClose_Click);
            // 
            // btnSlide
            // 
            this.btnSlide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSlide.Image = global::EHealthCare.Properties.Resources.menu_32px;
            this.btnSlide.Location = new System.Drawing.Point(11, 10);
            this.btnSlide.Margin = new System.Windows.Forms.Padding(2);
            this.btnSlide.Name = "btnSlide";
            this.btnSlide.Size = new System.Drawing.Size(25, 25);
            this.btnSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSlide.TabIndex = 0;
            this.btnSlide.TabStop = false;
            this.btnSlide.Click += new System.EventHandler(this.btnSlide_Click);
            // 
            // btnFeverRecors
            // 
            this.btnFeverRecors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(88)))));
            this.btnFeverRecors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFeverRecors.FlatAppearance.BorderSize = 0;
            this.btnFeverRecors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFeverRecors.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeverRecors.ForeColor = System.Drawing.Color.White;
            this.btnFeverRecors.Image = global::EHealthCare.Properties.Resources.thermometer_32px;
            this.btnFeverRecors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFeverRecors.Location = new System.Drawing.Point(11, 256);
            this.btnFeverRecors.Name = "btnFeverRecors";
            this.btnFeverRecors.Size = new System.Drawing.Size(234, 40);
            this.btnFeverRecors.TabIndex = 2;
            this.btnFeverRecors.Text = "     My Fever Records";
            this.btnFeverRecors.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFeverRecors.UseVisualStyleBackColor = false;
            this.btnFeverRecors.Click += new System.EventHandler(this.btnFeverRecors_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(88)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::EHealthCare.Properties.Resources.home_page_3nn2px;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(11, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(234, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "     Home";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(88)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::EHealthCare.Properties.Resources.home_page_3nn2px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(11, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "     Home";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(88)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::EHealthCare.Properties.Resources.home_page_3nn2px;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(11, 395);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(234, 40);
            this.button4.TabIndex = 2;
            this.button4.Text = "     Home";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(88)))));
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = global::EHealthCare.Properties.Resources.settings_32px;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(11, 441);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(234, 40);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "     Settings";
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = false;
            // 
            // btnBpRecords
            // 
            this.btnBpRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(88)))));
            this.btnBpRecords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBpRecords.FlatAppearance.BorderSize = 0;
            this.btnBpRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBpRecords.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBpRecords.ForeColor = System.Drawing.Color.White;
            this.btnBpRecords.Image = global::EHealthCare.Properties.Resources.drop_of_blood_32px;
            this.btnBpRecords.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBpRecords.Location = new System.Drawing.Point(11, 211);
            this.btnBpRecords.Name = "btnBpRecords";
            this.btnBpRecords.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBpRecords.Size = new System.Drawing.Size(234, 40);
            this.btnBpRecords.TabIndex = 2;
            this.btnBpRecords.Text = "     My BP Records";
            this.btnBpRecords.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBpRecords.UseVisualStyleBackColor = false;
            this.btnBpRecords.Click += new System.EventHandler(this.btnBpRecords_Click);
            // 
            // btnMyHistory
            // 
            this.btnMyHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(88)))));
            this.btnMyHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMyHistory.FlatAppearance.BorderSize = 0;
            this.btnMyHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyHistory.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyHistory.ForeColor = System.Drawing.Color.White;
            this.btnMyHistory.Image = global::EHealthCare.Properties.Resources.activity_history_32px;
            this.btnMyHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyHistory.Location = new System.Drawing.Point(11, 165);
            this.btnMyHistory.Name = "btnMyHistory";
            this.btnMyHistory.Size = new System.Drawing.Size(234, 40);
            this.btnMyHistory.TabIndex = 2;
            this.btnMyHistory.Text = "     My History";
            this.btnMyHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMyHistory.UseVisualStyleBackColor = false;
            this.btnMyHistory.Click += new System.EventHandler(this.btnMyHistory_Click);
            // 
            // btnAppoinments
            // 
            this.btnAppoinments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(88)))));
            this.btnAppoinments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAppoinments.FlatAppearance.BorderSize = 0;
            this.btnAppoinments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppoinments.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppoinments.ForeColor = System.Drawing.Color.White;
            this.btnAppoinments.Image = global::EHealthCare.Properties.Resources.appointments_32px;
            this.btnAppoinments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAppoinments.Location = new System.Drawing.Point(11, 119);
            this.btnAppoinments.Name = "btnAppoinments";
            this.btnAppoinments.Size = new System.Drawing.Size(234, 40);
            this.btnAppoinments.TabIndex = 2;
            this.btnAppoinments.Text = "     Appointments";
            this.btnAppoinments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAppoinments.UseVisualStyleBackColor = false;
            this.btnAppoinments.Click += new System.EventHandler(this.btnAppoinments_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(88)))));
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::EHealthCare.Properties.Resources.home_page_3nn2px;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(11, 73);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(234, 40);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "     Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EHealthCare.Properties.Resources.icon_main3;
            this.pictureBox1.Location = new System.Drawing.Point(11, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PatientDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 620);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.titleBar);
            this.Controls.Add(this.menuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PatientDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorDashboard";
            this.menuVertical.ResumeLayout(false);
            this.menuVertical.PerformLayout();
            this.titleBar.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconRestore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuVertical;
        private System.Windows.Forms.Label labelDisplay;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel titleBar;
        private System.Windows.Forms.PictureBox btnSlide;
        private System.Windows.Forms.PictureBox iconClose;
        private System.Windows.Forms.PictureBox iconRestore;
        private System.Windows.Forms.PictureBox iconMinimize;
        private System.Windows.Forms.PictureBox iconMaximize;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnAppoinments;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnFeverRecors;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Button btnBpRecords;
        public System.Windows.Forms.Button btnMyHistory;
    }
}