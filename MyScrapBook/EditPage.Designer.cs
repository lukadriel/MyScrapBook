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
            this.buttonTagManage = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.checkedListBoxTag = new System.Windows.Forms.CheckedListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonImgManage = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonTagManage
            // 
            this.buttonTagManage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonTagManage.Location = new System.Drawing.Point(0, 513);
            this.buttonTagManage.Name = "buttonTagManage";
            this.buttonTagManage.Size = new System.Drawing.Size(278, 80);
            this.buttonTagManage.TabIndex = 2;
            this.buttonTagManage.Text = "タグ管理";
            this.buttonTagManage.UseVisualStyleBackColor = true;
            this.buttonTagManage.Click += new System.EventHandler(this.buttonTagManage_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonSave.Location = new System.Drawing.Point(0, 593);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(278, 80);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "保存";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // checkedListBoxTag
            // 
            this.checkedListBoxTag.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.checkedListBoxTag.FormattingEnabled = true;
            this.checkedListBoxTag.Location = new System.Drawing.Point(0, 34);
            this.checkedListBoxTag.Name = "checkedListBoxTag";
            this.checkedListBoxTag.Size = new System.Drawing.Size(278, 276);
            this.checkedListBoxTag.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonImgManage);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.buttonTagManage);
            this.panel2.Controls.Add(this.buttonSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(278, 673);
            this.panel2.TabIndex = 10;
            // 
            // buttonImgManage
            // 
            this.buttonImgManage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonImgManage.Location = new System.Drawing.Point(0, 429);
            this.buttonImgManage.Name = "buttonImgManage";
            this.buttonImgManage.Size = new System.Drawing.Size(278, 84);
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
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(528, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(722, 537);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(528, 555);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(722, 75);
            this.textBox1.TabIndex = 12;
            // 
            // EditPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listView1);
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
        private System.Windows.Forms.Button buttonTagManage;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.CheckedListBox checkedListBoxTag;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonImgManage;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBox1;
    }
}