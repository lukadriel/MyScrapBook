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
        bool saved;
        OleDbCommandBuilder pageComBld;
        public NewPage(DateTime date)
        {
            InitializeComponent();
            myEventInit();
            selectedDate = date;
            load_data();
            DataRow row = dsDB.Tables["Page"].NewRow();
            pageComBld = new OleDbCommandBuilder(daPage);
            saved = false;
        }

        private void load_data()
        {
            sqlPicPage = @"SELECT Picture.imageNum,Picture.imageName, Picture.imagePath, Picture.imageComment
                                FROM Picture INNER JOIN pageImage ON Picture.imageNum = pageImage.imageNum
                                WHERE  ((pageImage.pageDate)=#" + selectedDate.ToShortDateString() + "#);";
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
        }
        private void pageTag_save()
        {
            object[] keys = new object[2];
            foreach(DataRow r in dsDB.Tables["Tag"].Rows)
            {
                DataRow row = dsDB.Tables["pageTag"].NewRow();
                keys[0] = row[0] = selectedDate;
                keys[1] = row[1] = r[0];
                if ((checkedListBoxTag.CheckedItems.Contains(r["tagName"])) && !dsDB.Tables["pageTag"].Rows.Contains(keys))
                {
                    dsDB.Tables["pageTag"].Rows.Add(row);
                }
                if (!(checkedListBoxTag.CheckedItems.Contains(r["tagName"])) && dsDB.Tables["pageTag"].Rows.Contains(keys))
                {
                    dsDB.Tables["pageTag"].Rows.Find(keys).Delete();
                }
            }

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if(!saved)
            {
                dsDB.Tables["Page"].Rows.Find(selectedDate.ToShortDateString()).Delete();
                try
                {
                    daPage.Update(dsDB, "Page");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message + " : " + ex.ToString());
                }
            }
            daPage.Update(dsDB, "Page");
            Thread.Sleep(500);
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
        private void CheckedListBoxTag_LostFocus(object sender, System.EventArgs e)
        {
            pageTag_save();
            OleDbCommandBuilder pageTagComBld = new OleDbCommandBuilder(daPageTag);
            daPageTag.Update(dsDB, "pageTag");
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saved = true;

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
        private void buttonAddImage_Click(object sender, EventArgs e)
        {
            new PictureChoice(dsDB, daImage, daPageImage, selectedDate).ShowDialog();
            update_listview();
        }

        private void buttonDeleteImage_Click(object sender, EventArgs e)
        {
            if(listView.SelectedItems.Count==0)
            {
                MessageBox.Show("削除する写真を選択してください。");
            }
            else
            {
                foreach(ListViewItem item in listView.SelectedItems)
                {
                    object[] key = { selectedDate, item.Tag };
                    dsDB.Tables["pageImage"].Rows.Find(key).Delete();
                    listView.Items.Remove(item);
                }
                OleDbCommandBuilder pageImageComBld = new OleDbCommandBuilder(daPageImage);
                daPageImage.Update(dsDB, "pageImage");
                listView.Update();

            }
        }
        private void update_listview()
        {
            Thread.Sleep(50);
            listView.Items.Clear();
            picPage.Clear();
            daPageImage.Fill(dsDB, "pageImage");
            adptPicPage.Fill(picPage);
            imageList.Images.Clear();
            int j = 0;
            foreach (DataRow r in picPage.Rows)
            {
                imageList.Images.Add(Image.FromFile(r["imagePath"].ToString()));
                ListViewItem item = new ListViewItem();
                item.ImageIndex = j;
                item.Text = r["imageName"].ToString();
                item.ToolTipText = r["imageComment"].ToString();
                item.Tag = r["imageNum"];
                listView.Items.Add(item);
                j++;
            }
            listView.View = View.LargeIcon;
            listView.LargeImageList = imageList;
            listView.Update();
        }
        private void TextBoxComment_LostFocus(object sender, System.EventArgs e)
        {
            try
            {
                dsDB.Tables["Page"].Rows.Find(selectedDate.ToShortDateString())["pageComment"] = textBoxComment.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " : " + ex.ToString());
            }

        }
    }
}
