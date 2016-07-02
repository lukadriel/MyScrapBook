namespace MyScrapBook
{
    partial class ViewPage
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelComment = new System.Windows.Forms.Label();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(334, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "pageComment";
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(628, 350);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(34, 17);
            this.labelComment.TabIndex = 1;
            this.labelComment.Text = "void";
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Location = new System.Drawing.Point(461, 13);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(381, 275);
            this.pictureBoxImage.TabIndex = 2;
            this.pictureBoxImage.TabStop = false;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(3, 3);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(104, 39);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "編集";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(3, 48);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(104, 39);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "終了";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonEdit);
            this.flowLayoutPanel1.Controls.Add(this.buttonExit);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 119);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(136, 100);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // ViewPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 528);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.comboBox1);
            this.Name = "ViewPage";
            this.Text = "ViewPage";
            this.Load += new System.EventHandler(this.ViewPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelComment;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}