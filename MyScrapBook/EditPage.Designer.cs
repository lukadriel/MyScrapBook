using System;

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
            this.components = new System.ComponentModel.Container();
            this.buttonTagManage = new System.Windows.Forms.Button();
            this.checkedListBoxTag = new System.Windows.Forms.CheckedListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonDeleteImage = new System.Windows.Forms.Button();
            this.buttonAddImage = new System.Windows.Forms.Button();
            this.buttonImgManage = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.buttonDelAll = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonTagManage
            // 
            this.buttonTagManage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonTagManage.Location = new System.Drawing.Point(0, 629);
            this.buttonTagManage.Name = "buttonTagManage";
            this.buttonTagManage.Size = new System.Drawing.Size(278, 44);
            this.buttonTagManage.TabIndex = 2;
            this.buttonTagManage.Text = "タグ管理";
            this.buttonTagManage.UseVisualStyleBackColor = true;
            this.buttonTagManage.Click += new System.EventHandler(this.buttonTagManage_Click);
            // 
            // checkedListBoxTag
            // 
            this.checkedListBoxTag.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.checkedListBoxTag.FormattingEnabled = true;
            this.checkedListBoxTag.Location = new System.Drawing.Point(0, 51);
            this.checkedListBoxTag.Name = "checkedListBoxTag";
            this.checkedListBoxTag.Size = new System.Drawing.Size(278, 259);
            this.checkedListBoxTag.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonExit);
            this.panel2.Controls.Add(this.buttonDeleteImage);
            this.panel2.Controls.Add(this.buttonAddImage);
            this.panel2.Controls.Add(this.buttonImgManage);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.buttonTagManage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(278, 673);
            this.panel2.TabIndex = 10;
            // 
            // buttonExit
            // 
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonExit.Location = new System.Drawing.Point(0, 437);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(278, 48);
            this.buttonExit.TabIndex = 13;
            this.buttonExit.Text = "終了";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonDeleteImage
            // 
            this.buttonDeleteImage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonDeleteImage.Location = new System.Drawing.Point(0, 485);
            this.buttonDeleteImage.Name = "buttonDeleteImage";
            this.buttonDeleteImage.Size = new System.Drawing.Size(278, 46);
            this.buttonDeleteImage.TabIndex = 12;
            this.buttonDeleteImage.Text = "画像削除";
            this.buttonDeleteImage.UseVisualStyleBackColor = true;
            this.buttonDeleteImage.Click += new System.EventHandler(this.buttonDeleteImage_Click);
            // 
            // buttonAddImage
            // 
            this.buttonAddImage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonAddImage.Location = new System.Drawing.Point(0, 531);
            this.buttonAddImage.Name = "buttonAddImage";
            this.buttonAddImage.Size = new System.Drawing.Size(278, 47);
            this.buttonAddImage.TabIndex = 11;
            this.buttonAddImage.Text = "画像追加";
            this.buttonAddImage.UseVisualStyleBackColor = true;
            this.buttonAddImage.Click += new System.EventHandler(this.buttonAddImage_Click);
            // 
            // buttonImgManage
            // 
            this.buttonImgManage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonImgManage.Location = new System.Drawing.Point(0, 578);
            this.buttonImgManage.Name = "buttonImgManage";
            this.buttonImgManage.Size = new System.Drawing.Size(278, 51);
            this.buttonImgManage.TabIndex = 10;
            this.buttonImgManage.Text = "画像管理";
            this.buttonImgManage.UseVisualStyleBackColor = true;
            this.buttonImgManage.Click += new System.EventHandler(this.buttonImgManage_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.checkedListBoxTag);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(278, 310);
            this.panel3.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "タグ";
            // 
            // listView
            // 
            this.listView.Location = new System.Drawing.Point(468, 12);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(782, 537);
            this.listView.TabIndex = 11;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(468, 555);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(782, 75);
            this.textBoxComment.TabIndex = 12;
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList.ImageSize = new System.Drawing.Size(220, 200);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // buttonDelAll
            // 
            this.buttonDelAll.Location = new System.Drawing.Point(284, 636);
            this.buttonDelAll.Name = "buttonDelAll";
            this.buttonDelAll.Size = new System.Drawing.Size(272, 37);
            this.buttonDelAll.TabIndex = 14;
            this.buttonDelAll.Text = "完全削除";
            this.buttonDelAll.UseVisualStyleBackColor = true;
            this.buttonDelAll.Click += new System.EventHandler(this.buttonDelAll_Click);
            // 
            // EditPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.buttonDelAll);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.panel2);
            this.Name = "EditPage";
            this.Text = "EditPage";
            this.Load += new System.EventHandler(this.EditPage_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private void myEventInit()
        {
            this.checkedListBoxTag.LostFocus += CheckedListBoxTag_LostFocus;
            this.textBoxComment.LostFocus += TextBoxComment_LostFocus;
        }

       

        private System.Windows.Forms.Button buttonTagManage;
        private System.Windows.Forms.CheckedListBox checkedListBoxTag;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonImgManage;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Button buttonAddImage;
        private System.Windows.Forms.Button buttonDeleteImage;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonDelAll;
    }
}