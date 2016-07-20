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
using System.IO;

namespace MyScrapBook
{
    public partial class ManagePicture : Form
    {

        private DataSet dtsDB;
        private OleDbDataAdapter daPicture;
        List<string> picPath;

        public ManagePicture(DataSet dsDB,OleDbDataAdapter daPicture)
        {
            InitializeComponent();
            myEvents();
            this.daPicture = daPicture;
            dtsDB = dsDB;
            dataGridView.AutoGenerateColumns = true;
            dataGridView.DataSource = dtsDB;
            dataGridView.DataMember = "Picture";
            picPath = new List<string>();
        }



        private void ManagePicture_Load(object sender, EventArgs e)
        {

            imgCol = new DataGridViewImageColumn();
            imgCol.HeaderText = "画像";
            imgCol.Name = "image";
            imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView.Columns["imageName"].HeaderText = "画像名";
            dataGridView.Columns["imageComment"].HeaderText = "コメント";
            dataGridView.Columns["imageNum"].Visible = false;
            dataGridView.Columns["imagePath"].Visible = false;
            imageGridView.Columns.Add(imgCol);
            dataGridView.Columns["imageComment"].ReadOnly = false;
            dataGridView.Columns["imageName"].ReadOnly = false;
            foreach(DataGridViewRow row in dataGridView.Rows)
            {
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(imageGridView);
                r.Height = 100;
                r.SetValues(Image.FromFile(row.Cells["imagePath"].Value.ToString()));
                imageGridView.Rows.Add(r);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            OleDbCommandBuilder objComBld = new OleDbCommandBuilder(daPicture);
            daPicture.Update(dtsDB, "Picture");
            System.Threading.Thread.Sleep(100);
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "画像ファイル|*.jpg;*.png;*.gif;*.bmp";
            ofd.Multiselect = false;
            if(ofd.ShowDialog()==DialogResult.OK)
            {
                string s;
                if (checkBoxCopy.Checked)
                {
                    s = @"image\" + ofd.SafeFileName;
                    File.Copy(ofd.FileName, s);
                    DataRow row = dtsDB.Tables["Picture"].NewRow();
                    row["imageName"] = ofd.SafeFileName;
                    row["imagePath"] = s;
                    dtsDB.Tables["Picture"].Rows.Add(row);
                    DataGridViewRow r = new DataGridViewRow();
                    r.CreateCells(imageGridView);
                    r.Height = 100;
                    r.SetValues(Image.FromFile(ofd.FileName));
                    imageGridView.Rows.Add(r);
                }
                else
                {
                    s = ofd.FileName;
                    DataRow row = dtsDB.Tables["Picture"].NewRow();
                    row["imageName"] = ofd.SafeFileName;
                    row["imagePath"] = s;
                    dtsDB.Tables["Picture"].Rows.Add(row);
                    DataGridViewRow r = new DataGridViewRow();
                    r.CreateCells(imageGridView);
                    r.Height = 100;
                    r.SetValues(Image.FromFile(ofd.FileName));
                    imageGridView.Rows.Add(r);
                }
                picPath.Add(s);
            }
        }


        private void buttonDelImage_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count != 0)
            {
                imageGridView.Rows.RemoveAt(dataGridView.SelectedRows[0].Index);
                picPath.Remove(dataGridView.SelectedRows[0].Cells["imagePath"].Value.ToString());
                dtsDB.Tables["Picture"].Rows[dataGridView.SelectedRows[0].Index].Delete();
            }
            else
                MessageBox.Show("No Rows Selected");
        }

        private void dataGridViewScroll(object sender, EventArgs e)
        {
            imageGridView.FirstDisplayedScrollingRowIndex = dataGridView.FirstDisplayedScrollingRowIndex;
        }

        private void imageGridViewScroll(object sender, EventArgs e)
        {
            dataGridView.FirstDisplayedScrollingRowIndex = imageGridView.FirstDisplayedScrollingRowIndex;
        }
    }
}
