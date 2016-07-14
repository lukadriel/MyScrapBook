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
    public partial class ManagePicture : Form
    {
        private DateTime selectedDate;
        private OleDbDataAdapter dtaPageImage;

        public ManagePicture(DataSet dsDB,OleDbDataAdapter daPicture,OleDbDataAdapter daPageImage,DateTime date)
        {
            InitializeComponent();
            dtsDb = dsDB;
            dtsBckUp = new DataSet("Backup");
            dtsBckUp= dsDB.Copy();
            dtaPicture = daPicture;
            dtaPageImage = daPageImage;
            dataGridView.DataSource = dtsBckUp;
            dataGridView.AutoGenerateColumns = true;
            dataGridView.DataMember = "Picture";
            selectedDate = date;
            saved = false;
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
            
        }

       

        private void buttonSave_Click(object sender, EventArgs e)
        {
            dtsDb = dtsBckUp.Copy();
            OleDbCommandBuilder objCmdBldPic = new OleDbCommandBuilder(dtaPicture);
            OleDbCommandBuilder objCmdBldPag = new OleDbCommandBuilder(dtaPageImage);
            dtaPicture.Update(dtsDb,"Picture");
            dtaPageImage.Update(dtsDb, "pageImage");
            DialogResult = DialogResult.OK;
            saved = true;
            Close();
        }

        private void buttonAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "画像ファイル|*.jpg;*.png;*.gif;*.bmp";
            ofd.Multiselect = false;
            if(ofd.ShowDialog()==DialogResult.OK)
            {
                string s = @"images\" + ofd.SafeFileName;
                DataRow row = dtsBckUp.Tables["Picture"].NewRow();
                DataRow imRow = dtsBckUp.Tables["pageImage"].NewRow();
                row["imagePath"] = s;
                row["imageName"] = ofd.SafeFileName;
                imRow["pageDate"] = selectedDate;
                DataGridViewRow r = new DataGridViewRow();
                dtsBckUp.Tables["Picture"].Rows.Add(row);
                imRow["imageNum"] = dtsBckUp.Tables["Picture"].Rows[dtsBckUp.Tables["Picture"].Rows.Count - 1]["imageNum"];
                r.CreateCells(imageGridView);
                dtsBckUp.Tables["pageImage"].Rows.Add(imRow);
                r.Height = 100;
                r.SetValues(Image.FromFile(ofd.FileName));
                imageGridView.Rows.Add(r);
            }
        }

        
        private void buttonDelImage_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count != 0)
            {
                imageGridView.Rows.RemoveAt(dataGridView.SelectedRows[0].Index);
                object[] keys = new object[2] {selectedDate,dataGridView.SelectedRows[0].Cells["imageNum"].Value };
                dtsBckUp.Tables["pageImage"].Rows.Remove(dtsBckUp.Tables["pageImage"].Rows.Find(keys));
                dtsBckUp.Tables["Picture"].Rows.Remove(dtsBckUp.Tables["Picture"].Rows.Find(keys[1]));                
            }
            else
                MessageBox.Show("No Rows Selected");           
        }
    }
}
