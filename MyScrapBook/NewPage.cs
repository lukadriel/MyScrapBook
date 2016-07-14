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
    public partial class NewPage : Form
    {
        public NewPage(DateTime date)
        {
            InitializeComponent();
            connexionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DatabaseScrap.accdb";
            objConn = new OleDbConnection(connexionString);
            objConn.Open();
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

        private void page_save()
        {
            DataRow row = dsDB.Tables["Page"].NewRow();
            row[0] = selectedDate;
            row[1] = true;
            row[2] = textBoxPComment.Text;
            dsDB.Tables["Page"].Rows.Add(row);
        }
        private void pageImage_save()//pageImage save Problem
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
        }

        private void image_save()
        {
            foreach (DataRow r in dtImage.Rows)
            {
                DataRow row = dsDB.Tables["Picture"].NewRow();
                row[1] = r[1];
                row[2] = r[2];
                row[3] = r[3];
                dsDB.Tables["Picture"].Rows.Add(row);
            }
        }

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

        private void buttonAddImage_Click(object sender, EventArgs e)
        {
            new ManagePicture(dsDB, daImage,daPageImage,selectedDate).ShowDialog();
            //OpenFileDialog ofd = new OpenFileDialog();
            //ofd.Filter = "画像ファイル|*.jpg;*.png;*.gif;*.bmp";
            //ofd.Multiselect = false;
            //if(ofd.ShowDialog()==DialogResult.OK)
            //{
            //    new ManageImage(ofd, dtImage).ShowDialog();
            //    try
            //    {
            //        imageList.Images.Add(Image.FromFile(ofd.FileName));
            //        listView.Items.Add(ofd.SafeFileName, imageList.Images.Count - 1);
            //    }
            //    catch(Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
                //string s = @"images\" + ofd.SafeFileName;
                //try
                //{
                //    //File.Copy(ofd.FileName, s); //to be added later
                //    rowImage = dtImage.NewRow();
                //    rowImage["imagePath"] = s;
                //    rowImage["imageName"] = ofd.SafeFileName;
                //    imageList.Images.Add(Image.FromFile(ofd.FileName));
                //    listView.Items.Add(ofd.SafeFileName, imageList.Images.Count - 1);

                //}
                //catch(Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}
            }
        

        private void buttonSave_Click(object sender, EventArgs e)
        {
            page_save();
            image_save();
            pageImage_save();
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
            if(new ManageTag(dsDB,daTag).ShowDialog()==DialogResult.OK)
            {
                dsDB.Tables["Tag"].Clear();
                daTag.Fill(dsDB, "Tag");
                checkedListBoxTag.Items.Clear();
                foreach (DataRow r in dsDB.Tables[0].Rows)
                    checkedListBoxTag.Items.Add(r["tagName"]);
            }

        }



        private void textBoxPComment_TextChanged(object sender, EventArgs e)
        {
            rowPage["pageComment"] = textBoxPComment.Text;
        }



        private void checkedListBoxTag_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(DataRow r in dtImage.Rows)
            {
                if(r["imageName"].ToString()==listView.SelectedItems[0].ToString())
                {
                    labelCommentImage.Text = r["commentImage"].ToString();
                }
            }
        }
    }
}
