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
using System.Threading;

namespace MyScrapBook
{
    public partial class NewPage : Form
    {
        private string sqlPicPage;
        private OleDbDataAdapter adptPicPage;
        private DataTable picPage;
        public NewPage(DateTime date)
        {
            InitializeComponent();
            sqlPicPage = @"SELECT Picture.imageName, Picture.imagePath, Picture.imageComment
                                FROM Picture INNER JOIN pageImage ON Picture.imageNum = pageImage.imageNum
                                WHERE (((pageImage.imageNum)=[Picture].[imageNum]) AND ((pageImage.pageDate)=#" + date.ToShortDateString() + "#));";
            connexionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DatabaseScrap.accdb";
            objConn = new OleDbConnection(connexionString);
            objConn.Open();
            adptPicPage = new OleDbDataAdapter(sqlPicPage, objConn);
            picPage = new DataTable();
            daTag = new OleDbDataAdapter("Select * from Tag", objConn);
            daImage = new OleDbDataAdapter("Select * from Picture", objConn);
            daPage = new OleDbDataAdapter("Select * from Page", objConn);
            daPageTag = new OleDbDataAdapter("Select * from pageTag", objConn);
            daPageImage = new OleDbDataAdapter("Select * from pageImage", objConn);
            dsDB = new DataSet("DataBase");
            daTag.FillSchema(dsDB, SchemaType.Source, "Tag");
            daImage.FillSchema(dsDB, SchemaType.Source, "Picture");
            daPage.FillSchema(dsDB, SchemaType.Source, "Page");
            daPageImage.FillSchema(dsDB, SchemaType.Source, "pageImage");
            daPageTag.FillSchema(dsDB, SchemaType.Source, "pageTag");
            daTag.Fill(dsDB, "Tag");
            daImage.Fill(dsDB, "Picture");
            daPage.Fill(dsDB, "Page");
            daPageImage.Fill(dsDB, "pageImage");
            daPageTag.Fill(dsDB, "pageTag");
            selectedDate = date;
            dtImage = dsDB.Tables["Picture"].Clone();
            rowPage = dsDB.Tables["Page"].NewRow();
            DataRow row = dsDB.Tables["Page"].NewRow();
            row["pageDate"] = selectedDate;
            dsDB.Tables["Page"].Rows.Add(row);
            OleDbCommandBuilder pageComBld = new OleDbCommandBuilder(daPage);
            daPage.Update(dsDB, "Page");
        }

        private void pageTag_save()
        {
            foreach(DataRow r in dsDB.Tables["Tag"].Rows)
            {
                if(checkedListBoxTag.CheckedItems.Contains(r["tagName"]))
                {
                    DataRow row = dsDB.Tables["pageTag"].NewRow();
                    row[0] = selectedDate;
                    row[1] = r[0];
                    dsDB.Tables["pageTag"].Rows.Add(row);
                }
            }
        }

        /*private void page_save()
        {
            DataRow row = dsDB.Tables["Page"].NewRow();
            row[0] = selectedDate;
            row[1] = true;
            row[2] = textBoxPComment.Text;
            dsDB.Tables["Page"].Rows.Add(row);
        }*/
        /*private void pageImage_save()//pageImage save Problem
        {
            foreach(DataRow r in dtImage.Rows)
            {
                DataRow row = dsDB.Tables["pageImage"].NewRow();
                row[0] = selectedDate;
                foreach(DataRow rw in dsDB.Tables["Picture"].Rows)
                {
                    if(r["imagePath"]== rw["imagePath"])
                        row[1] = rw[0];
                }
                dsDB.Tables["pageImage"].Rows.Add(row);
            }
        }*/

        /*private void image_save()
        {
            foreach (DataRow r in dtImage.Rows)
            {
                DataRow row = dsDB.Tables["Picture"].NewRow();
                row[1] = r[1];
                row[2] = r[2];
                row[3] = r[3];
                dsDB.Tables["Picture"].Rows.Add(row);
            }
        }*/

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Form page = new MainPage();
            page.MdiParent = MdiParent;
            page.FormBorderStyle = FormBorderStyle.None;
            page.Dock = DockStyle.Fill;
            page.Show();
            Close();
        }

        private void NewPage_Load(object sender, EventArgs e)
        {
            foreach (DataRow r in dsDB.Tables["Tag"].Rows)
                checkedListBoxTag.Items.Add(r["tagName"]);
        }

        private void buttonManageImage_Click(object sender, EventArgs e)
        {
            Thread.Sleep(500);
            if(new ManagePicture(dsDB, daImage).ShowDialog()==DialogResult.OK)
            {
                daImage.Fill(dsDB, "Picture");
            }
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            //page_save();
            //image_save();
            //pageImage_save();
            pageTag_save();
            OleDbCommandBuilder pageComBld = new OleDbCommandBuilder(daPage);
            OleDbCommandBuilder imageComBld = new OleDbCommandBuilder(daImage);
            OleDbCommandBuilder pageTagComBld = new OleDbCommandBuilder(daPageTag);
            OleDbCommandBuilder pageImageComBld = new OleDbCommandBuilder(daPageImage);
            daImage.Update(dsDB, "Picture");
            daPage.Update(dsDB, "Page");
            //daPageImage.Update(dsDB, "pageImage");
            daPageTag.Update(dsDB, "pageTag");
        }

        private void buttonTagManage_Click(object sender, EventArgs e)
        {
            Thread.Sleep(100);
            if(new ManageTag(dsDB,daTag).ShowDialog()==DialogResult.OK)
            {
                dsDB.Tables["Tag"].Clear();
                daTag.Fill(dsDB, "Tag");
                List<Object> checkedItem = new List<object>();
                foreach (object check in checkedListBoxTag.CheckedItems)
                    checkedItem.Add(check);
                checkedListBoxTag.Items.Clear();
                foreach (DataRow r in dsDB.Tables[0].Rows)
                    checkedListBoxTag.Items.Add(r["tagName"]);
                foreach(object item in checkedItem)
                {
                    for(int i = 0; i<checkedListBoxTag.Items.Count;i++)
                    {
                        if (checkedListBoxTag.Items[i].ToString() == item.ToString())
                            checkedListBoxTag.SetItemChecked(i, true);

                    }
                }
            }

        }



        private void textBoxPComment_TextChanged(object sender, EventArgs e)
        {
            dsDB.Tables["Page"].Rows.Find(selectedDate)["pageComment"] = textBoxPComment.Text;
        }



        private void checkedListBoxTag_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddImage_Click(object sender, EventArgs e)
        {
            new PictureChoice(dsDB, daImage, daPageImage, selectedDate).ShowDialog();
        }
    }
}
