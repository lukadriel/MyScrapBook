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
        public EditPage(DateTime date)
        {
            InitializeComponent();
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
            daPicture = new OleDbDataAdapter("Select * From Picture", connexion);
            daPageImage = new OleDbDataAdapter("Select * From pageImage", connexion);
            daPageTag = new OleDbDataAdapter("Select * From pageTag", connexion);
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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Form page = new ViewPage(dtsDb,date);
            page.MdiParent = MdiParent;
            page.FormBorderStyle = FormBorderStyle.None;
            page.Dock = DockStyle.Fill;
            page.Show();
            Close();
        }

        private void EditPage_Load(object sender, EventArgs e)
        {
            load_Tag();
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
                foreach (DataRow r in dtsDb.Tables[0].Rows)
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
            new ManagePicture(dtsDb, daPicture, daPageImage, date).ShowDialog();
        }
    }
}
