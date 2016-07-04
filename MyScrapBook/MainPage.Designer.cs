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
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainCalendar
            // 
            this.mainCalendar.Location = new System.Drawing.Point(462, 153);
            this.mainCalendar.MaxSelectionCount = 1;
            this.mainCalendar.Name = "mainCalendar";
            this.mainCalendar.TabIndex = 0;
            this.mainCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mainCalendar_DateChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonView);
            this.groupBox1.Controls.Add(this.buttonEdit);
            this.groupBox1.Controls.Add(this.buttonNew);
            this.groupBox1.Location = new System.Drawing.Point(12, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 207);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // buttonView
            // 
            this.buttonView.Enabled = false;
            this.buttonView.Location = new System.Drawing.Point(6, 135);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(115, 52);
            this.buttonView.TabIndex = 2;
            this.buttonView.Text = "ビュー";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Enabled = false;
            this.buttonEdit.Location = new System.Drawing.Point(6, 77);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(115, 52);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "編集";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(6, 21);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(115, 52);
            this.buttonNew.TabIndex = 0;
            this.buttonNew.Text = "新エントリー";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 503);
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
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonNew;
        private System.Data.OleDb.OleDbConnection objConn;
        private System.Data.OleDb.OleDbDataAdapter daPage;
        private System.Data.DataSet dsDB;
        private string connexionString;
    }
}

