namespace MyScrapBook
{
    partial class EditPage
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonAddImage = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkedListBoxTag = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(426, 294);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(406, 215);
            this.textBox1.TabIndex = 1;
            // 
            // buttonAddImage
            // 
            this.buttonAddImage.Location = new System.Drawing.Point(12, 12);
            this.buttonAddImage.Name = "buttonAddImage";
            this.buttonAddImage.Size = new System.Drawing.Size(133, 80);
            this.buttonAddImage.TabIndex = 2;
            this.buttonAddImage.Text = "画像追加";
            this.buttonAddImage.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 98);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(133, 80);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "保存";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(12, 184);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(133, 80);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "終了";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(426, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(406, 252);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(246, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 6;
            // 
            // checkedListBoxTag
            // 
            this.checkedListBoxTag.FormattingEnabled = true;
            this.checkedListBoxTag.Location = new System.Drawing.Point(246, 98);
            this.checkedListBoxTag.Name = "checkedListBoxTag";
            this.checkedListBoxTag.Size = new System.Drawing.Size(143, 89);
            this.checkedListBoxTag.TabIndex = 7;
            // 
            // EditPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 521);
            this.Controls.Add(this.checkedListBoxTag);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonAddImage);
            this.Controls.Add(this.textBox1);
            this.Name = "EditPage";
            this.Text = "EditPage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonAddImage;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckedListBox checkedListBoxTag;
    }
}