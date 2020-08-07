namespace EvryDay
{
    partial class Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExpand = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabCamera = new System.Windows.Forms.TabPage();
            this.defaultPic = new System.Windows.Forms.PictureBox();
            this.tlpShutter = new System.Windows.Forms.TableLayoutPanel();
            this.btnShutter = new System.Windows.Forms.Button();
            this.camera = new System.Windows.Forms.PictureBox();
            this.tabHistory = new System.Windows.Forms.TabPage();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.cmbCameras = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabCamera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.defaultPic)).BeginInit();
            this.tlpShutter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.camera)).BeginInit();
            this.tabSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnExpand);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 30);
            this.panel1.TabIndex = 0;
            this.panel1.DoubleClick += new System.EventHandler(this.Expand_Click);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Interface_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Interface_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Interface_MouseUp);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Gold;
            this.btnMinimize.BackgroundImage = global::EvryDay.Properties.Resources.minimize;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(406, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(25, 22);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.Tag = "minimize";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.Min_Click);
            this.btnMinimize.MouseLeave += new System.EventHandler(this.ToolTipOff);
            this.btnMinimize.MouseHover += new System.EventHandler(this.ToolTipOn);
            // 
            // btnExpand
            // 
            this.btnExpand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExpand.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnExpand.BackgroundImage = global::EvryDay.Properties.Resources.maximize;
            this.btnExpand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExpand.FlatAppearance.BorderSize = 0;
            this.btnExpand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpand.Location = new System.Drawing.Point(437, 4);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(25, 22);
            this.btnExpand.TabIndex = 2;
            this.btnExpand.Tag = "maximize";
            this.btnExpand.UseVisualStyleBackColor = false;
            this.btnExpand.Click += new System.EventHandler(this.Expand_Click);
            this.btnExpand.MouseLeave += new System.EventHandler(this.ToolTipOff);
            this.btnExpand.MouseHover += new System.EventHandler(this.ToolTipOn);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Coral;
            this.btnClose.BackgroundImage = global::EvryDay.Properties.Resources.close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(468, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 22);
            this.btnClose.TabIndex = 1;
            this.btnClose.Tag = "close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.Close_Click);
            this.btnClose.MouseLeave += new System.EventHandler(this.ToolTipOff);
            this.btnClose.MouseHover += new System.EventHandler(this.ToolTipOn);
            // 
            // tabMain
            // 
            this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMain.Controls.Add(this.tabCamera);
            this.tabMain.Controls.Add(this.tabHistory);
            this.tabMain.Controls.Add(this.tabSettings);
            this.tabMain.Location = new System.Drawing.Point(5, 35);
            this.tabMain.Margin = new System.Windows.Forms.Padding(0);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Drawing.Point(0, 0);
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(488, 388);
            this.tabMain.TabIndex = 1;
            this.tabMain.SelectedIndexChanged += new System.EventHandler(this.ChangeTab);
            // 
            // tabCamera
            // 
            this.tabCamera.BackColor = System.Drawing.Color.Gainsboro;
            this.tabCamera.Controls.Add(this.defaultPic);
            this.tabCamera.Controls.Add(this.tlpShutter);
            this.tabCamera.Controls.Add(this.camera);
            this.tabCamera.Location = new System.Drawing.Point(4, 22);
            this.tabCamera.Margin = new System.Windows.Forms.Padding(0);
            this.tabCamera.Name = "tabCamera";
            this.tabCamera.Padding = new System.Windows.Forms.Padding(3);
            this.tabCamera.Size = new System.Drawing.Size(480, 362);
            this.tabCamera.TabIndex = 0;
            this.tabCamera.Tag = "camera";
            this.tabCamera.Text = "Camera";
            // 
            // defaultPic
            // 
            this.defaultPic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.defaultPic.BackColor = System.Drawing.Color.Transparent;
            this.defaultPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.defaultPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.defaultPic.Location = new System.Drawing.Point(0, 0);
            this.defaultPic.Margin = new System.Windows.Forms.Padding(0);
            this.defaultPic.MinimumSize = new System.Drawing.Size(480, 320);
            this.defaultPic.Name = "defaultPic";
            this.defaultPic.Size = new System.Drawing.Size(480, 320);
            this.defaultPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.defaultPic.TabIndex = 3;
            this.defaultPic.TabStop = false;
            this.defaultPic.Visible = false;
            // 
            // tlpShutter
            // 
            this.tlpShutter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpShutter.ColumnCount = 3;
            this.tlpShutter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpShutter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpShutter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpShutter.Controls.Add(this.btnShutter, 1, 0);
            this.tlpShutter.Location = new System.Drawing.Point(0, 323);
            this.tlpShutter.Name = "tlpShutter";
            this.tlpShutter.RowCount = 1;
            this.tlpShutter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpShutter.Size = new System.Drawing.Size(480, 40);
            this.tlpShutter.TabIndex = 2;
            // 
            // btnShutter
            // 
            this.btnShutter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShutter.BackgroundImage = global::EvryDay.Properties.Resources.camera_shutter;
            this.btnShutter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShutter.FlatAppearance.BorderSize = 0;
            this.btnShutter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnShutter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnShutter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShutter.Location = new System.Drawing.Point(190, 0);
            this.btnShutter.Margin = new System.Windows.Forms.Padding(0);
            this.btnShutter.MaximumSize = new System.Drawing.Size(100, 40);
            this.btnShutter.MinimumSize = new System.Drawing.Size(100, 40);
            this.btnShutter.Name = "btnShutter";
            this.btnShutter.Size = new System.Drawing.Size(100, 40);
            this.btnShutter.TabIndex = 1;
            this.btnShutter.UseVisualStyleBackColor = true;
            this.btnShutter.Click += new System.EventHandler(this.BtnShutter_Click);
            this.btnShutter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnShutter_MouseDown);
            this.btnShutter.MouseEnter += new System.EventHandler(this.BtnShutter_MouseEnter);
            this.btnShutter.MouseLeave += new System.EventHandler(this.BtnShutter_MouseLeave);
            this.btnShutter.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnShutter_MouseUp);
            // 
            // camera
            // 
            this.camera.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.camera.BackColor = System.Drawing.Color.White;
            this.camera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.camera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.camera.Location = new System.Drawing.Point(0, 0);
            this.camera.MinimumSize = new System.Drawing.Size(480, 320);
            this.camera.Name = "camera";
            this.camera.Size = new System.Drawing.Size(480, 320);
            this.camera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.camera.TabIndex = 0;
            this.camera.TabStop = false;
            // 
            // tabHistory
            // 
            this.tabHistory.Location = new System.Drawing.Point(4, 22);
            this.tabHistory.Name = "tabHistory";
            this.tabHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabHistory.Size = new System.Drawing.Size(480, 362);
            this.tabHistory.TabIndex = 1;
            this.tabHistory.Tag = "history";
            this.tabHistory.Text = "History";
            this.tabHistory.UseVisualStyleBackColor = true;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.cmbCameras);
            this.tabSettings.Controls.Add(this.label1);
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(480, 362);
            this.tabSettings.TabIndex = 2;
            this.tabSettings.Tag = "settings";
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // cmbCameras
            // 
            this.cmbCameras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCameras.FormattingEnabled = true;
            this.cmbCameras.Location = new System.Drawing.Point(87, 7);
            this.cmbCameras.Name = "cmbCameras";
            this.cmbCameras.Size = new System.Drawing.Size(201, 21);
            this.cmbCameras.Sorted = true;
            this.cmbCameras.TabIndex = 1;
            this.cmbCameras.SelectedIndexChanged += new System.EventHandler(this.CmbCameras_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Camera";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 428);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(498, 425);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabCamera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.defaultPic)).EndInit();
            this.tlpShutter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.camera)).EndInit();
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabCamera;
        private System.Windows.Forms.TabPage tabHistory;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.Button btnExpand;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.PictureBox camera;
        private System.Windows.Forms.Button btnShutter;
        private System.Windows.Forms.TableLayoutPanel tlpShutter;
        private System.Windows.Forms.PictureBox defaultPic;
        private System.Windows.Forms.ComboBox cmbCameras;
        private System.Windows.Forms.Label label1;
    }
}

