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
        private DateTime selectedDate;
        private OleDbDataAdapter dtaPageImage;
        private DataTable dtPageImage;
        private List<string> picPath;
        private OleDbDataAdapter dtapagePicture;
        private DataSet dtsTest;
        private DataSet dtsDb;
        private DataSet dtsBckUp;
        private OleDbDataAdapter dtaPicture;
        private OleDbDataAdapter dtaPage;
        private string connexion;
        private OleDbConnection conn;

        public ManagePicture(DataSet dsDB,OleDbDataAdapter daPicture,OleDbDataAdapter daPageImage,DateTime date)
        {
            InitializeComponent();
            myEvents();
            dtsDb = dsDB;
            dtsBckUp = new DataSet("Backup");
            //dtsBckUp= dsDB.Copy();
            dtsTest = new DataSet("Database");
            //dtaPicture = daPicture;
            dtapagePicture = daPicture;
            //dtaPageImage = daPageImage;
            dtapagePicture.SelectCommand.CommandText = @"SELECT Picture.imageNum, Picture.imagePath, Picture.imageName, Picture.imageComment
                FROM Picture INNER JOIN pageImage ON Picture.imageNum = pageImage.imageNum
                WHERE(((pageImage.pageDate) =#"+date.ToShortDateString()+"#));";
            dtapagePicture.FillSchema(dtsTest, SchemaType.Source, "Picture");
            dtapagePicture.Fill(dtsTest, "Picture");
            dataGridView.DataSource = dtsTest;//dtsBckUp;
            dataGridView.AutoGenerateColumns = true;
            dataGridView.DataMember = "Picture";
            selectedDate = date;
            //dtPageImage = dtsDb.Tables["Picture"].Clone();
            saved = false;
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

        private void update_pageImage()
        {
            connexion= "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DatabaseScrap.accdb";
            conn = new OleDbConnection(connexion);
            conn.Open();
            dtaPageImage = new OleDbDataAdapter("Select * from pageImage", conn);
            dtaPicture = new OleDbDataAdapter("Select * from Picture", conn);
            dtaPage = new OleDbDataAdapter("Select * from Page", conn);
            //dtaPage.FillSchema(dtsBckUp, SchemaType.Source, "Page");
            dtaPageImage.FillSchema(dtsBckUp, SchemaType.Source, "pageImage");
            dtaPicture.FillSchema(dtsBckUp, SchemaType.Source, "Picture");
            dtaPicture.Fill(dtsBckUp,"Picture");
            dtaPageImage.Fill(dtsBckUp, "pageImage");
            //dtaPage.Fill(dtsBckUp, "Page");
            //DataRow ro = dtsBckUp.Tables["Page"].NewRow();

            foreach(string path in picPath)
            {
                foreach(DataRow r in dtsBckUp.Tables["Picture"].Rows)
                {
                    if(r["imagePath"].ToString()==path)
                    {
                        DataRow row = dtsBckUp.Tables["pageImage"].NewRow();
                        row[0] = selectedDate;
                        row[1] = r["imageNum"];
                        dtsBckUp.Tables["pageImage"].Rows.Add(row);
                        //break;
                    }
                }
            }
            OleDbCommandBuilder objCmdBldPagImg = new OleDbCommandBuilder(dtaPageImage);
            OleDbCommandBuilder objCmdBldPag = new OleDbCommandBuilder(dtaPage);
            dtaPageImage.Update(dtsBckUp, "pageImage");
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //dtsDb = dtsBckUp.Copy();
            OleDbCommandBuilder objCmdBldPic = new OleDbCommandBuilder(dtaPicture);
            //OleDbCommandBuilder objCmdBldPag = new OleDbCommandBuilder(dtaPageImage);
            //dtaPicture.Update(dtsDb,"Picture");
            OleDbCommandBuilder objCmdBldPag = new OleDbCommandBuilder(dtapagePicture);
            dtapagePicture.Update(dtsTest, "Picture");
            update_pageImage();
            //update_pageImage();
            //dtaPageImage.Update(dtsDb, "pageImage");
            DialogResult = DialogResult.OK;
            saved = true;
            conn.Close();
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
                    s = @"images\" + ofd.SafeFileName;
                    File.Copy(ofd.FileName, s,true);
                    DataRow row = dtsTest.Tables["Picture"].NewRow();//dtsBckUp.Tables["Picture"].NewRow();
                    row["imagePath"] = s;
                    row["imageName"] = ofd.SafeFileName;
                    DataGridViewRow r = new DataGridViewRow();
                    dtsTest.Tables["Picture"].Rows.Add(row);//dtsBckUp.Tables["Picture"].Rows.Add(row);
                    r.CreateCells(imageGridView);
                    r.Height = 100;
                    r.SetValues(Image.FromFile(ofd.FileName));
                    imageGridView.Rows.Add(r);
                }
                else
                {
                    s = ofd.FileName;
                    DataRow row = dtsTest.Tables["Picture"].NewRow();//dtsBckUp.Tables["Picture"].NewRow();
                    row["imagePath"] = s;
                    row["imageName"] = ofd.SafeFileName;
                    DataGridViewRow r = new DataGridViewRow();
                    dtsTest.Tables["Picture"].Rows.Add(row);//dtsBckUp.Tables["Picture"].Rows.Add(row);
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
                object[] keys = new object[2] {selectedDate,dataGridView.SelectedRows[0].Cells["imageNum"].Value };
                picPath.Remove(dataGridView.SelectedRows[0].Cells["imagePath"].Value.ToString());
                dtsTest.Tables["Picture"].Rows.Remove(dtsTest.Tables["Picture"].Rows.Find(keys[1]));//dtsBckUp.Tables["Picture"].Rows.Remove(dtsBckUp.Tables["Picture"].Rows.Find(keys[1]));
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
