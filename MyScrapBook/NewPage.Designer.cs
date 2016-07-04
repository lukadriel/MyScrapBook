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
            this.textBoxIComment = new System.Windows.Forms.TextBox();
            this.imageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new MyScrapBook.DatabaseDataSet();
            this.buttonAddImage = new System.Windows.Forms.Button();
            this.buttonTagAdd = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxPComment = new System.Windows.Forms.TextBox();
            this.tableAdapterManager = new MyScrapBook.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.checkedListBoxTag = new System.Windows.Forms.CheckedListBox();
            this.tagBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tagTableAdapter = new MyScrapBook.DatabaseDataSetTableAdapters.TagTableAdapter();
            this.imageTableAdapter = new MyScrapBook.DatabaseDataSetTableAdapters.ImageTableAdapter();
            this.pageImageTableAdapter = new MyScrapBook.DatabaseDataSetTableAdapters.pageImageTableAdapter();
            this.pageTableAdapter = new MyScrapBook.DatabaseDataSetTableAdapters.PageTableAdapter();
            this.pageTagTableAdapter = new MyScrapBook.DatabaseDataSetTableAdapters.pageTagTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxIComment
            // 
            this.textBoxIComment.Location = new System.Drawing.Point(739, 483);
            this.textBoxIComment.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxIComment.Multiline = true;
            this.textBoxIComment.Name = "textBoxIComment";
            this.textBoxIComment.Size = new System.Drawing.Size(506, 52);
            this.textBoxIComment.TabIndex = 0;
            this.textBoxIComment.Text = "<<No Comment>>";
            this.textBoxIComment.TextChanged += new System.EventHandler(this.textBoxIComment_TextChanged);
            // 
            // imageBindingSource
            // 
            this.imageBindingSource.DataMember = "Image";
            this.imageBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonAddImage
            // 
            this.buttonAddImage.Location = new System.Drawing.Point(15, 14);
            this.buttonAddImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAddImage.Name = "buttonAddImage";
            this.buttonAddImage.Size = new System.Drawing.Size(166, 90);
            this.buttonAddImage.TabIndex = 1;
            this.buttonAddImage.Text = "画像追加";
            this.buttonAddImage.UseVisualStyleBackColor = true;
            this.buttonAddImage.Click += new System.EventHandler(this.buttonAddImage_Click);
            // 
            // buttonTagAdd
            // 
            this.buttonTagAdd.Location = new System.Drawing.Point(15, 110);
            this.buttonTagAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonTagAdd.Name = "buttonTagAdd";
            this.buttonTagAdd.Size = new System.Drawing.Size(166, 90);
            this.buttonTagAdd.TabIndex = 2;
            this.buttonTagAdd.Text = "タグ管理";
            this.buttonTagAdd.UseVisualStyleBackColor = true;
            this.buttonTagAdd.Click += new System.EventHandler(this.buttonTagAdd_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(15, 323);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(166, 90);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "保存";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(15, 420);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(166, 90);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // textBoxPComment
            // 
            this.textBoxPComment.Location = new System.Drawing.Point(739, 569);
            this.textBoxPComment.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxPComment.Multiline = true;
            this.textBoxPComment.Name = "textBoxPComment";
            this.textBoxPComment.Size = new System.Drawing.Size(506, 83);
            this.textBoxPComment.TabIndex = 7;
            this.textBoxPComment.Text = "<<No Comment>>";
            this.textBoxPComment.TextChanged += new System.EventHandler(this.textBoxPComment_TextChanged);
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
            // checkedListBoxTag
            // 
            this.checkedListBoxTag.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tagBindingSource, "tagName", true));
            this.checkedListBoxTag.FormattingEnabled = true;
            this.checkedListBoxTag.Location = new System.Drawing.Point(271, 110);
            this.checkedListBoxTag.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkedListBoxTag.Name = "checkedListBoxTag";
            this.checkedListBoxTag.Size = new System.Drawing.Size(198, 84);
            this.checkedListBoxTag.Sorted = true;
            this.checkedListBoxTag.TabIndex = 8;
            this.checkedListBoxTag.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxTag_SelectedIndexChanged);
            // 
            // tagBindingSource
            // 
            this.tagBindingSource.DataMember = "Tag";
            this.tagBindingSource.DataSource = this.databaseDataSet;
            // 
            // tagTableAdapter
            // 
            this.tagTableAdapter.ClearBeforeFill = true;
            // 
            // imageTableAdapter
            // 
            this.imageTableAdapter.ClearBeforeFill = true;
            // 
            // pageImageTableAdapter
            // 
            this.pageImageTableAdapter.ClearBeforeFill = true;
            // 
            // pageTableAdapter
            // 
            this.pageTableAdapter.ClearBeforeFill = true;
            // 
            // pageTagTableAdapter
            // 
            this.pageTagTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "タグ選択";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(593, 12);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(652, 448);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // NewPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBoxTag);
            this.Controls.Add(this.textBoxPComment);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonTagAdd);
            this.Controls.Add(this.buttonAddImage);
            this.Controls.Add(this.textBoxIComment);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "NewPage";
            this.Text = "NewPage";
            this.Load += new System.EventHandler(this.NewPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void myEventInit()
        {

        }
        private System.Windows.Forms.TextBox textBoxIComment;
        private System.Windows.Forms.Button buttonAddImage;
        private System.Windows.Forms.Button buttonTagAdd;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBoxPComment;
        private DatabaseDataSet databaseDataSet;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.CheckedListBox checkedListBoxTag;
        private System.Windows.Forms.BindingSource tagBindingSource;
        private DatabaseDataSetTableAdapters.TagTableAdapter tagTableAdapter;
        private DatabaseDataSetTableAdapters.ImageTableAdapter imageTableAdapter;
        private DatabaseDataSetTableAdapters.pageImageTableAdapter pageImageTableAdapter;
        private DatabaseDataSetTableAdapters.PageTableAdapter pageTableAdapter;
        private DatabaseDataSetTableAdapters.pageTagTableAdapter pageTagTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource imageBindingSource;
        private System.Data.DataRow rowImage;
        private System.Data.DataRow rowPage;
        private System.Data.DataRow rowTag;
        private System.Data.DataRow rowPageTag;
        private System.Data.DataRow rowPageImage;
        private System.Data.DataTable dtImage;
        private System.Data.DataTable dtTag;
        private System.Data.DataTable dtPageTag;
        private bool firstImage = true;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageList;
    }
}