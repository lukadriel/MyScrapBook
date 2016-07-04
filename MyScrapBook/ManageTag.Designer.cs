namespace MyScrapBook
{
    partial class ManageTag
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
            this.dataGridViewTag = new System.Windows.Forms.DataGridView();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTag)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            //
            // dataGridViewTag
            //
            this.dataGridViewTag.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTag.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewTag.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridViewTag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTag.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTag.Name = "dataGridViewTag";
            this.dataGridViewTag.RowTemplate.Height = 24;
            this.dataGridViewTag.Size = new System.Drawing.Size(526, 227);
            this.dataGridViewTag.TabIndex = 0;
            //
            // buttonSave
            //
            this.buttonSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonSave.Location = new System.Drawing.Point(0, 232);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(526, 41);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "保存";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            //
            // panel1
            //
            this.panel1.Controls.Add(this.dataGridViewTag);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 227);
            this.panel1.TabIndex = 2;
            //
            // ManageTag
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 273);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ManageTag";
            this.Text = "タグ管理";
            this.Load += new System.EventHandler(this.ManageTag_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTag)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private void myEvent()
        {

        }

        private System.Windows.Forms.DataGridView dataGridViewTag;
        private System.Windows.Forms.Button buttonSave;
        private System.Data.OleDb.OleDbDataAdapter daTag;
        private System.Data.DataSet dtsDb;
        private System.Windows.Forms.Panel panel1;
    }
}