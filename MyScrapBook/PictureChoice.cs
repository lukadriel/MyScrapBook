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
    public partial class PictureChoice : Form
    {
        DataSet dtsDB;
        OleDbDataAdapter daPicture;
        OleDbDataAdapter daPageImage;
        DateTime selectedDate;
        public PictureChoice(DataSet dsDB, OleDbDataAdapter daPicture,OleDbDataAdapter daPageImage,DateTime date)
        {
            InitializeComponent();
            this.daPicture = daPicture;
            this.daPageImage = daPageImage;
            dtsDB = dsDB;
            selectedDate = date;
            
        }

        private void PictureChoice_Load(object sender, EventArgs e)
        {
            int j = 0;
            foreach(DataRow r in dtsDB.Tables["Picture"].Rows)
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
            listView.View = View.Tile;
            listView.SmallImageList = imageList;
            listView.LargeImageList = imageList;
            listView.Update();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(listView.SelectedItems.Count==0)
            {
                MessageBox.Show("追加する画像は選択されていません。");
            }
            else
            {
                foreach(ListViewItem item in listView.SelectedItems)
                {
                    DataRow r = dtsDB.Tables["pageImage"].NewRow();
                    r["pageDate"] = selectedDate;
                    r["imageNum"] = item.Tag;
                    dtsDB.Tables["pageImage"].Rows.Add(r);
                }
            }
            OleDbCommandBuilder cmdBld = new OleDbCommandBuilder(daPageImage);
            daPageImage.Update(dtsDB, "pageImage");
        }
    }
}
