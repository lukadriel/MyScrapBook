namespace MyScrapBook
{
    partial class NewPage
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
            this.textBoxIComment = new System.Windows.Forms.TextBox();
            this.buttonAddImage = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBoxImage = new System.Windows.Forms.ComboBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.textBoxPComment = new System.Windows.Forms.TextBox();
            this.databaseDataSet = new MyScrapBook.DatabaseDataSet();
            this.tableAdapterManager = new MyScrapBook.DatabaseDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxIComment
            // 
            this.textBoxIComment.Location = new System.Drawing.Point(434, 242);
            this.textBoxIComment.Multiline = true;
            this.textBoxIComment.Name = "textBoxIComment";
            this.textBoxIComment.Size = new System.Drawing.Size(406, 77);
            this.textBoxIComment.TabIndex = 0;
            // 
            // buttonAddImage
            // 
            this.buttonAddImage.Location = new System.Drawing.Point(12, 12);
            this.buttonAddImage.Name = "buttonAddImage";
            this.buttonAddImage.Size = new System.Drawing.Size(133, 80);
            this.buttonAddImage.TabIndex = 1;
            this.buttonAddImage.Text = "画像追加";
            this.buttonAddImage.UseVisualStyleBackColor = true;
            this.buttonAddImage.Click += new System.EventHandler(this.buttonAddImage_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 80);
            this.button2.TabIndex = 2;
            this.button2.Text = "タグ追加";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 287);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 80);
            this.button3.TabIndex = 3;
            this.button3.Text = "保存";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // comboBoxImage
            // 
            this.comboBoxImage.FormattingEnabled = true;
            this.comboBoxImage.Location = new System.Drawing.Point(220, 12);
            this.comboBoxImage.Name = "comboBoxImage";
            this.comboBoxImage.Size = new System.Drawing.Size(121, 24);
            this.comboBoxImage.TabIndex = 4;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(12, 373);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(133, 80);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxImage.Location = new System.Drawing.Point(434, 12);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(406, 224);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImage.TabIndex = 6;
            this.pictureBoxImage.TabStop = false;
            // 
            // textBoxPComment
            // 
            this.textBoxPComment.Location = new System.Drawing.Point(434, 349);
            this.textBoxPComment.Multiline = true;
            this.textBoxPComment.Name = "textBoxPComment";
            this.textBoxPComment.Size = new System.Drawing.Size(406, 126);
            this.textBoxPComment.TabIndex = 7;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.ImageTableAdapter = null;
            this.tableAdapterManager.pageImageTableAdapter = null;
            this.tableAdapterManager.PageTableAdapter = null;
            this.tableAdapterManager.pageTagTableAdapter = null;
            this.tableAdapterManager.TagTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MyScrapBook.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // NewPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 487);
            this.Controls.Add(this.textBoxPComment);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.comboBoxImage);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonAddImage);
            this.Controls.Add(this.textBoxIComment);
            this.Name = "NewPage";
            this.Text = "NewPage";
            this.Load += new System.EventHandler(this.NewPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIComment;
        private System.Windows.Forms.Button buttonAddImage;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBoxImage;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.TextBox textBoxPComment;
        private DatabaseDataSet databaseDataSet;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}