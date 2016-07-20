namespace MyScrapBook
{
    partial class MainPage
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
            this.mainCalendar = new System.Windows.Forms.MonthCalendar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonView = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonManageImage = new System.Windows.Forms.Button();
            this.buttonTagManage = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainCalendar
            // 
            this.mainCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainCalendar.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.mainCalendar.Location = new System.Drawing.Point(362, 171);
            this.mainCalendar.MaximumSize = new System.Drawing.Size(400, 444);
            this.mainCalendar.MaxSelectionCount = 1;
            this.mainCalendar.Name = "mainCalendar";
            this.mainCalendar.TabIndex = 0;
            this.mainCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mainCalendar_DateChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonTagManage);
            this.groupBox1.Controls.Add(this.buttonManageImage);
            this.groupBox1.Controls.Add(this.buttonView);
            this.groupBox1.Controls.Add(this.buttonNew);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 590);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // buttonView
            // 
            this.buttonView.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonView.Enabled = false;
            this.buttonView.Location = new System.Drawing.Point(3, 70);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(194, 52);
            this.buttonView.TabIndex = 2;
            this.buttonView.Text = "ビュー";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonNew.Location = new System.Drawing.Point(3, 18);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(194, 52);
            this.buttonNew.TabIndex = 0;
            this.buttonNew.Text = "新エントリー";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonManageImage
            // 
            this.buttonManageImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonManageImage.Location = new System.Drawing.Point(3, 122);
            this.buttonManageImage.Name = "buttonManageImage";
            this.buttonManageImage.Size = new System.Drawing.Size(194, 56);
            this.buttonManageImage.TabIndex = 2;
            this.buttonManageImage.Text = "画像管理";
            this.buttonManageImage.UseVisualStyleBackColor = true;
            this.buttonManageImage.Click += new System.EventHandler(this.buttonManageImage_Click);
            // 
            // buttonTagManage
            // 
            this.buttonTagManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTagManage.Location = new System.Drawing.Point(3, 178);
            this.buttonTagManage.Name = "buttonTagManage";
            this.buttonTagManage.Size = new System.Drawing.Size(194, 57);
            this.buttonTagManage.TabIndex = 3;
            this.buttonTagManage.Text = "タグ管理";
            this.buttonTagManage.UseVisualStyleBackColor = true;
            this.buttonTagManage.Click += new System.EventHandler(this.buttonTagManage_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 590);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mainCalendar);
            this.Name = "MainPage";
            this.Text = "Start";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mainCalendar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonManageImage;
        private System.Windows.Forms.Button buttonTagManage;
    }
}

