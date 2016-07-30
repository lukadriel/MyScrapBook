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
    public partial class EditPage : Form
    {
        private DataSet dtsDb;
        private OleDbDataAdapter daTag;
        private OleDbDataAdapter daPicture;
        private OleDbDataAdapter daPage;
        private OleDbDataAdapter daImage;//for the selected images
        private OleDbDataAdapter daPTag;// for the selected Tags
        private OleDbDataAdapter daPageImage;
        private OleDbDataAdapter daPageTag;
        private OleDbConnection connexion;
        private string connectionString;
        private System.DateTime date;
        private DataTable tag;
        private DataTable picture;
        OleDbCommandBuilder pageTagComBld;
        OleDbCommandBuilder pageComBld;

        public EditPage(DateTime date)
        {
            InitializeComponent();
            myEventInit();
            this.date = date;
            initDataset();

        }

       private void initDataset()
        {
            connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DatabaseScrap.accdb";
            connexion = new OleDbConnection(connectionString);
            daPTag = new OleDbDataAdapter(@"SELECT Tag.tagNum,Tag.tagName
                            FROM Tag INNER JOIN pageTag ON Tag.tagNum = pageTag.tagNum
                            WHERE pageTag.pageDate=#" + date.ToShortDateString() + "#;", connexion);
            daTag = new OleDbDataAdapter("Select * from Tag", connexion);
            daImage = new OleDbDataAdapter(@"Select Picture.imageNum,Picture.imageName,Picture.imagePath,
                    Picture.imageComment from Picture Inner Join pageImage On Picture.imageNum=pageImage.imageNum
                    Where pageImage.pageDate=#" + date.ToShortDateString() + "#;", connexion);
            daPage = new OleDbDataAdapter("Select * from Page Where Page.pageDate=#" + date.ToShortDateString() + "#;", connexion);
            pageComBld = new OleDbCommandBuilder(daPage);
            daPicture = new OleDbDataAdapter("Select * From Picture", connexion);
            daPageImage = new OleDbDataAdapter("Select * From pageImage", connexion);
            daPageTag = new OleDbDataAdapter("Select * From pageTag", connexion);
            pageTagComBld = new OleDbCommandBuilder(daPageTag);
            dtsDb = new DataSet("Database");
            daPage.FillSchema(dtsDb, SchemaType.Source, "Page");
            daPicture.FillSchema(dtsDb, SchemaType.Source, "Picture");
            daPageImage.FillSchema(dtsDb, SchemaType.Source, "pageImage");
            daPageTag.FillSchema(dtsDb, SchemaType.Source, "pageTag");
            daTag.FillSchema(dtsDb, SchemaType.Source, "Tag");
            daPage.Fill(dtsDb, "Page");
            daPicture.Fill(dtsDb, "Picture");
            daPageImage.Fill(dtsDb, "pageImage");
            daPageTag.Fill(dtsDb, "pageTag");
            daTag.Fill(dtsDb, "Tag");
            tag = new DataTable();
            picture = new DataTable();
            daPTag.Fill(tag);
            daImage.Fill(picture);
        }

        private void EditPage_Load(object sender, EventArgs e)
        {
            load_Tag();
            load_Picture();
            textBoxComment.Text = dtsDb.Tables["Page"].Rows[0]["pageComment"].ToString();
        }

        private void load_Tag()
        {
            foreach (DataRow row in dtsDb.Tables["Tag"].Rows)
            {
                checkedListBoxTag.Items.Add(row["tagName"].ToString());
            }
            foreach (DataRow row in tag.Rows)
            {
                if (checkedListBoxTag.Items.Contains(row["tagName"]))
                    checkedListBoxTag.SetItemChecked(checkedListBoxTag.Items.IndexOf(row["tagName"]), true);
            }
        }
        private void load_Picture()
        {
            int j = 0;
            foreach(DataRow r in picture.Rows)
            {
                imageList.Images.Add(Image.FromFile(r["imagePath"].ToString()));
                ListViewItem item = new ListViewItem();
                item.ImageIndex = j;
                item.Text = r["imageComment"].ToString();
                item.ToolTipText = r["imageName"].ToString();
                item.Tag = r["imageNum"];
                listView.Items.Add(item);
                j++;
            }
            listView.View = View.LargeIcon;
            listView.LargeImageList = imageList;
        }

        private void buttonTagManage_Click(object sender, EventArgs e)
        {
            if(new ManageTag(dtsDb, daTag).ShowDialog()==DialogResult.OK)
            {
                dtsDb.Tables["Tag"].Clear();
                daTag.Fill(dtsDb, "Tag");
                List<Object> checkedItem = new List<object>();
                foreach (object check in checkedListBoxTag.CheckedItems)
                    checkedItem.Add(check);
                checkedListBoxTag.Items.Clear();
                foreach (DataRow r in dtsDb.Tables["Tag"].Rows)
                    checkedListBoxTag.Items.Add(r["tagName"]);
                foreach (object item in checkedItem)
                {
                    for (int i = 0; i < checkedListBoxTag.Items.Count; i++)
                    {
                        if (checkedListBoxTag.Items[i].ToString() == item.ToString())
                            checkedListBoxTag.SetItemChecked(i, true);

                    }
                }
            }
        }

        private void buttonImgManage_Click(object sender, EventArgs e)
        {
            new ManagePicture(dtsDb, daPicture).ShowDialog();
        }

        private void buttonAddImage_Click(object sender, EventArgs e)
        {
            new PictureChoice(dtsDb, daPicture, daPageImage, date).ShowDialog();
            Form edit = new EditPage(date);
            edit.MdiParent = this.MdiParent;
            edit.FormBorderStyle = FormBorderStyle.None;
            edit.Dock = DockStyle.Fill;
            edit.Show();
            this.Close();
        }



        private void buttonExit_Click(object sender, EventArgs e)
        {
            Form view = new ViewPage(dtsDb, date);
            view.MdiParent = MdiParent;
            view.FormBorderStyle = FormBorderStyle.None;
            view.Dock = DockStyle.Fill;
            Close();
            view.Show();
        }

        private void pageTag_save()
        {
            object[] keys = new object[2];
            foreach (DataRow r in dtsDb.Tables["Tag"].Rows)
            {
                DataRow row = dtsDb.Tables["pageTag"].NewRow();
                keys[0] = row[0] = date;
                keys[1] = row[1] = r[0];
                if ((checkedListBoxTag.CheckedItems.Contains(r["tagName"])) && !dtsDb.Tables["pageTag"].Rows.Contains(keys))
                {
                    dtsDb.Tables["pageTag"].Rows.Add(row);
                }
                else if (!(checkedListBoxTag.CheckedItems.Contains(r["tagName"])) && dtsDb.Tables["pageTag"].Rows.Contains(keys))
                {
                    dtsDb.Tables["pageTag"].Rows.Find(keys).Delete();
                }
            }

        }
        private void CheckedListBoxTag_LostFocus(object sender, EventArgs e)
        {
            pageTag_save();
            daPageTag.Update(dtsDb, "pageTag");
        }
        private void TextBoxComment_LostFocus(object sender, EventArgs e)
        {
            dtsDb.Tables["Page"].Rows.Find(date)["pageComment"] = textBoxComment.Text;
            daPage.Update(dtsDb, "Page");
        }

        private void buttonDeleteImage_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 0)
            {
                MessageBox.Show("画像は選択されていません。");
            }
            else
            {
                object[] keys = new object[2];
                keys[0] = date;
                foreach (ListViewItem item in listView.SelectedItems )
                {
                    keys[1] = item.Tag;
                    dtsDb.Tables["pageImage"].Rows.Find(keys).Delete();
                    listView.Items.Remove(item);
                }
                listView.Update();
                OleDbCommandBuilder pageImageComBld = new OleDbCommandBuilder(daPageImage);
                daPageImage.Update(dtsDb, "pageImage");
            }
        }

        private void buttonDelAll_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("このページのすべてを削除しますが、よろしいですか？","削除確認",MessageBoxButtons.YesNo)== DialogResult.Yes)
            {
                dtsDb.Tables["Page"].Rows.Find(date).Delete();
                daPage.Update(dtsDb, "Page");
                Thread.Sleep(500);
                Form main = new MainPage();
                main.MdiParent = MdiParent;
                main.FormBorderStyle = FormBorderStyle.None;
                main.Dock = DockStyle.Fill;
                Close();
                main.Show();
            }
        }
    }
}
