using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace MyScrapBook
{
    public partial class ManageTag : Form
    {
        public ManageTag(DataSet dsDB, OleDbDataAdapter daTag)
        {
            InitializeComponent();
            this.daTag = daTag;
            this.dtsDb = dsDB;
            dataGridViewTag.AutoGenerateColumns = true;
            dataGridViewTag.DataSource = dtsDb;
            dataGridViewTag.DataMember = "Tag";
        }

        private void ManageTag_Load(object sender, EventArgs e)
        {

            dataGridViewTag.Columns[1].HeaderText = "タグ名";
            dataGridViewTag.Columns.Remove("tagNum");
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            OleDbCommandBuilder objcombld = new OleDbCommandBuilder(daTag);
            daTag.Update(dtsDb, "Tag");
            System.Threading.Thread.Sleep(100);
            this.DialogResult = DialogResult.OK;
            Close();

        }
    }
}
