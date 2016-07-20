namespace MyScrapBook
{
    partial class ManagePicture
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonAddImage = new System.Windows.Forms.Button();
            this.imageGridView = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.checkBoxCopy = new System.Windows.Forms.CheckBox();
            this.buttonDelImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            //
            // dataGridView
            //
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 100;
            this.dataGridView.Size = new System.Drawing.Size(765, 581);
            this.dataGridView.TabIndex = 0;
            //
            // buttonSave
            //
            this.buttonSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonSave.Location = new System.Drawing.Point(0, 0);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(302, 88);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "保存";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            //
            // buttonAddImage
            //
            this.buttonAddImage.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonAddImage.Location = new System.Drawing.Point(952, 0);
            this.buttonAddImage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonAddImage.Name = "buttonAddImage";
            this.buttonAddImage.Size = new System.Drawing.Size(310, 88);
            this.buttonAddImage.TabIndex = 2;
            this.buttonAddImage.Text = "画像追加";
            this.buttonAddImage.UseVisualStyleBackColor = true;
            this.buttonAddImage.Click += new System.EventHandler(this.buttonAddImage_Click);
            //
            // imageGridView
            //
            this.imageGridView.AllowUserToAddRows = false;
            this.imageGridView.AllowUserToDeleteRows = false;
            this.imageGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.imageGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.imageGridView.Dock = System.Windows.Forms.DockStyle.Right;
            this.imageGridView.Location = new System.Drawing.Point(864, 0);
            this.imageGridView.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.imageGridView.Name = "imageGridView";
            this.imageGridView.RowTemplate.Height = 100;
            this.imageGridView.Size = new System.Drawing.Size(398, 581);
            this.imageGridView.TabIndex = 3;
            //
            // splitContainer1
            //
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            //
            // splitContainer1.Panel1
            //
            this.splitContainer1.Panel1.Controls.Add(this.checkBoxCopy);
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView);
            this.splitContainer1.Panel1.Controls.Add(this.imageGridView);
            //
            // splitContainer1.Panel2
            //
            this.splitContainer1.Panel2.Controls.Add(this.buttonDelImage);
            this.splitContainer1.Panel2.Controls.Add(this.buttonAddImage);
            this.splitContainer1.Panel2.Controls.Add(this.buttonSave);
            this.splitContainer1.Size = new System.Drawing.Size(1262, 673);
            this.splitContainer1.SplitterDistance = 581;
            this.splitContainer1.TabIndex = 4;
            //
            // checkBoxCopy
            //
            this.checkBoxCopy.AutoSize = true;
            this.checkBoxCopy.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxCopy.Location = new System.Drawing.Point(770, 557);
            this.checkBoxCopy.Name = "checkBoxCopy";
            this.checkBoxCopy.Size = new System.Drawing.Size(89, 21);
            this.checkBoxCopy.TabIndex = 4;
            this.checkBoxCopy.Text = "画像コピー";
            this.checkBoxCopy.UseVisualStyleBackColor = false;
            //
            // buttonDelImage
            //
            this.buttonDelImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelImage.Location = new System.Drawing.Point(492, -1);
            this.buttonDelImage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonDelImage.Name = "buttonDelImage";
            this.buttonDelImage.Size = new System.Drawing.Size(341, 89);
            this.buttonDelImage.TabIndex = 3;
            this.buttonDelImage.Text = "画像削除";
            this.buttonDelImage.UseVisualStyleBackColor = true;
            this.buttonDelImage.Click += new System.EventHandler(this.buttonDelImage_Click);
            //
            // ManagePicture
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ManagePicture";
            this.Text = "ManagePicture";
            this.Load += new System.EventHandler(this.ManagePicture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageGridView)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private void myEvents()
        {
            dataGridView.Scroll += new System.Windows.Forms.ScrollEventHandler(dataGridViewScroll);
            imageGridView.Scroll += new System.Windows.Forms.ScrollEventHandler(imageGridViewScroll);
        }




        private System.Windows.Forms.DataGridViewImageColumn imgCol;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonAddImage;
        private System.Windows.Forms.DataGridView imageGridView;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonDelImage;
        private System.Windows.Forms.CheckBox checkBoxCopy;
    }
}