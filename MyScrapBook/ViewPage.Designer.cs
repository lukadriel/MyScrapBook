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
            this.components = new System.ComponentModel.Container();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.listViewImage = new System.Windows.Forms.ListView();
            this.labelComment = new System.Windows.Forms.Label();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.flowLayoutPanelTag = new System.Windows.Forms.FlowLayoutPanel();
            this.labelLayoutTag = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(3, 3);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(127, 93);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "編集";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(3, 102);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(127, 100);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "終了";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonEdit);
            this.flowLayoutPanel1.Controls.Add(this.buttonExit);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(136, 590);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.listViewImage);
            this.flowLayoutPanel2.Controls.Add(this.labelComment);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(136, 94);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(870, 496);
            this.flowLayoutPanel2.TabIndex = 9;
            // 
            // listViewImage
            // 
            this.listViewImage.Location = new System.Drawing.Point(2, 3);
            this.listViewImage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listViewImage.Name = "listViewImage";
            this.listViewImage.ShowItemToolTips = true;
            this.listViewImage.Size = new System.Drawing.Size(869, 384);
            this.listViewImage.TabIndex = 0;
            this.listViewImage.UseCompatibleStateImageBehavior = false;
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelComment.Location = new System.Drawing.Point(2, 390);
            this.labelComment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(57, 20);
            this.labelComment.TabIndex = 1;
            this.labelComment.Text = "label1";
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList.ImageSize = new System.Drawing.Size(250, 250);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // flowLayoutPanelTag
            // 
            this.flowLayoutPanelTag.Location = new System.Drawing.Point(142, 33);
            this.flowLayoutPanelTag.Name = "flowLayoutPanelTag";
            this.flowLayoutPanelTag.Size = new System.Drawing.Size(864, 58);
            this.flowLayoutPanelTag.TabIndex = 10;
            // 
            // labelLayoutTag
            // 
            this.labelLayoutTag.AutoSize = true;
            this.labelLayoutTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLayoutTag.Location = new System.Drawing.Point(142, 3);
            this.labelLayoutTag.Name = "labelLayoutTag";
            this.labelLayoutTag.Size = new System.Drawing.Size(50, 29);
            this.labelLayoutTag.TabIndex = 11;
            this.labelLayoutTag.Text = "タグ";
            // 
            // ViewPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 590);
            this.Controls.Add(this.labelLayoutTag);
            this.Controls.Add(this.flowLayoutPanelTag);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ViewPage";
            this.Text = "ViewPage";
            this.Load += new System.EventHandler(this.ViewPage_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.ListView listViewImage;
        private System.Windows.Forms.Label labelComment;
        private System.Data.DataSet dtsDB;
        private System.Data.OleDb.OleDbDataAdapter dtaDB;
        private System.DateTime date;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTag;
        private System.Windows.Forms.Label labelLayoutTag;
    }
}