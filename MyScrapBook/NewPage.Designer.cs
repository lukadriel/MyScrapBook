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
            this.components = new System.ComponentModel.Container();
            this.buttonManageImage = new System.Windows.Forms.Button();
            this.buttonTagManage = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxPComment = new System.Windows.Forms.TextBox();
            this.checkedListBoxTag = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.buttonAddImage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonManageImage
            // 
            this.buttonManageImage.Location = new System.Drawing.Point(12, 12);
            this.buttonManageImage.Name = "buttonManageImage";
            this.buttonManageImage.Size = new System.Drawing.Size(133, 80);
            this.buttonManageImage.TabIndex = 1;
            this.buttonManageImage.Text = "画像管理";
            this.buttonManageImage.UseVisualStyleBackColor = true;
            this.buttonManageImage.Click += new System.EventHandler(this.buttonManageImage_Click);
            // 
            // buttonTagManage
            // 
            this.buttonTagManage.Location = new System.Drawing.Point(12, 98);
            this.buttonTagManage.Name = "buttonTagManage";
            this.buttonTagManage.Size = new System.Drawing.Size(133, 80);
            this.buttonTagManage.TabIndex = 2;
            this.buttonTagManage.Text = "タグ管理";
            this.buttonTagManage.UseVisualStyleBackColor = true;
            this.buttonTagManage.Click += new System.EventHandler(this.buttonTagManage_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 287);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(133, 80);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "保存";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
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
            // textBoxPComment
            // 
            this.textBoxPComment.Location = new System.Drawing.Point(591, 506);
            this.textBoxPComment.Multiline = true;
            this.textBoxPComment.Name = "textBoxPComment";
            this.textBoxPComment.Size = new System.Drawing.Size(406, 74);
            this.textBoxPComment.TabIndex = 7;
            this.textBoxPComment.Text = "<<No Comment>>";
            this.textBoxPComment.TextChanged += new System.EventHandler(this.textBoxPComment_TextChanged);
            // 
            // checkedListBoxTag
            // 
            this.checkedListBoxTag.CheckOnClick = true;
            this.checkedListBoxTag.FormattingEnabled = true;
            this.checkedListBoxTag.Location = new System.Drawing.Point(217, 98);
            this.checkedListBoxTag.Name = "checkedListBoxTag";
            this.checkedListBoxTag.Size = new System.Drawing.Size(159, 174);
            this.checkedListBoxTag.Sorted = true;
            this.checkedListBoxTag.TabIndex = 8;
            this.checkedListBoxTag.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxTag_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "タグ選択";
            // 
            // listView
            // 
            this.listView.LargeImageList = this.imageList;
            this.listView.Location = new System.Drawing.Point(474, 11);
            this.listView.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.ShowItemToolTips = true;
            this.listView.Size = new System.Drawing.Size(522, 399);
            this.listView.TabIndex = 10;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(100, 100);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // buttonAddImage
            // 
            this.buttonAddImage.Location = new System.Drawing.Point(474, 417);
            this.buttonAddImage.Name = "buttonAddImage";
            this.buttonAddImage.Size = new System.Drawing.Size(121, 36);
            this.buttonAddImage.TabIndex = 11;
            this.buttonAddImage.Text = "画像追加";
            this.buttonAddImage.UseVisualStyleBackColor = true;
            // 
            // NewPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 590);
            this.Controls.Add(this.buttonAddImage);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBoxTag);
            this.Controls.Add(this.textBoxPComment);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonTagManage);
            this.Controls.Add(this.buttonManageImage);
            this.Name = "NewPage";
            this.Text = "NewPage";
            this.Load += new System.EventHandler(this.NewPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void myEventInit()
        {

        }
        private System.Windows.Forms.Button buttonManageImage;
        private System.Windows.Forms.Button buttonTagManage;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBoxPComment;
        private System.Windows.Forms.CheckedListBox checkedListBoxTag;
        private System.Windows.Forms.Label label1;
        private System.Data.DataRow rowImage;
        private System.Data.DataRow rowPage;
        private System.Data.DataRow rowTag;
        private System.Data.DataRow rowPageTag;
        private System.Data.DataRow rowPageImage;
        private System.Data.DataTable dtImage;
        private System.Data.DataTable dtTag;
        private System.Data.DataTable dtPageTag;
        private System.Data.DataTable dtPage;
        private System.Data.DataTable dtPageImage;
        private bool firstImage = true;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ImageList imageList;
        private string connexionString;
        private System.Data.OleDb.OleDbConnection objConn;
        private System.Data.OleDb.OleDbDataAdapter daTag;
        private System.Data.OleDb.OleDbDataAdapter daImage;
        private System.Data.OleDb.OleDbDataAdapter daPage;
        private System.Data.OleDb.OleDbDataAdapter daPageTag;
        private System.Data.OleDb.OleDbDataAdapter daPageImage;
        private System.DateTime selectedDate;
        private System.Data.DataSet dsDB;
        private System.Windows.Forms.Button buttonAddImage;
    }
}