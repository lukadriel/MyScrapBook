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
    public partial class ViewPage : Form
    {
        private string sqlPicture;
        private string sqlTag;
        private string sqlPage;
        private string connexion;
        private DataSet dsDB;
        private OleDbDataAdapter adptPic;
        private OleDbDataAdapter adptTag;
        private OleDbDataAdapter adptPage;
        private OleDbConnection objConn;
        public ViewPage(DataSet dtsDB,OleDbDataAdapter dAdView,DateTime viewDate)
        {
            InitializeComponent();
            dsDB = new DataSet();
            sqlPicture = @"SELECT Picture.imageName, Picture.imagePath, Picture.imageComment
                                FROM Picture INNER JOIN pageImage ON Picture.imageNum = pageImage.imageNum
                                WHERE (((pageImage.imageNum)=[Picture].[imageNum]) AND ((pageImage.pageDate)=#" + viewDate.ToShortDateString() + "#));";
            sqlTag = @"SELECT Tag.tagName
                          FROM Tag INNER JOIN pageTag ON Tag.tagNum = pageTag.tagNum
                          WHERE (((pageTag.pageDate)=#" + viewDate.ToShortDateString() + "#));";
            sqlPage = @"SELECT Page.pageComment, Page.pageDate
                            FROM Page
                            WHERE (((Page.pageDate)=#" + viewDate.ToShortDateString() + "#));";
            date = viewDate;
            connexion= "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DatabaseScrap.accdb";
            objConn = new OleDbConnection(connexion);
            objConn.Open();
            adptPic = new OleDbDataAdapter(sqlPicture, objConn);
            adptTag = new OleDbDataAdapter(sqlTag, objConn);
            adptPage = new OleDbDataAdapter(sqlPage, objConn);
            adptTag.Fill(dsDB);
            dsDB.Tables[0].TableName = "Tag";
            adptPic.Fill(dsDB);
            dsDB.Tables[1].TableName = "Picture";
            adptPage.Fill(dsDB);
            dsDB.Tables[2].TableName = "Page";
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

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Form edit = new EditPage(date);
            edit.MdiParent = MdiParent;
            edit.FormBorderStyle = FormBorderStyle.None;
            edit.Dock = DockStyle.Fill;
            Close();
            edit.Show();
        }

        private void ViewPage_Load(object sender, EventArgs e)
        {
            int j = 0;
            foreach(DataRow r in dsDB.Tables[1].Rows)
            {
                imageList.Images.Add(Image.FromFile(r["imagePath"].ToString()));
                ListViewItem item = new ListViewItem();
                item.ImageIndex = j;
                item.Text = r["imageComment"].ToString();
                item.ToolTipText = r["imageName"].ToString();
                listViewImage.Items.Add(item);
                j++;
            }
            listViewImage.View = View.LargeIcon;
            listViewImage.LargeImageList = imageList;
            foreach (DataRow r in dsDB.Tables[0].Rows)
            {
                Label text = new Label();
                text.Text = r[0].ToString();
                flowLayoutPanelTag.Controls.Add(text);
            }
            labelComment.Text = dsDB.Tables[2].Rows[0][0].ToString();

        }
    }
}
