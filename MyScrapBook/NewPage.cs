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
            rowImage= databaseDataSet.Image.NewImageRow();
            rowPage = databaseDataSet.Page.NewPageRow();
            rowTag = databaseDataSet.Tag.NewTagRow();
            rowPageTag = databaseDataSet.pageTag.NewpageTagRow();
            rowPageImage = databaseDataSet.pageImage.NewpageImageRow();
            rowPage["pageDate"] = date;

        }

        private void getData()
        {
            tagTableAdapter.GetData();
            pageTableAdapter.GetData();
            imageTableAdapter.GetData();
            pageTagTableAdapter.GetData();
            pageImageTableAdapter.GetData();
        }

        private void fill()
        {
            tagTableAdapter.Fill(databaseDataSet.Tag);
            pageTableAdapter.Fill(databaseDataSet.Page);
            imageTableAdapter.Fill(databaseDataSet.Image);
            pageTagTableAdapter.Fill(databaseDataSet.pageTag);
            pageImageTableAdapter.Fill(databaseDataSet.pageImage);
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
            getData();
            fill();
            DataTable t = databaseDataSet.Tag;
            foreach(DataRow r in t.Rows)
            {
                checkedListBoxTag.Items.Add(r["tagName"]);
            }

        }

        private void buttonAddImage_Click(object sender, EventArgs e)
        {
            if (firstImage)
            {
                firstImage = false;
            }
            else
            {
                dtImage.Rows.Add(rowImage);
            }
            OpenFileDialog oFile = new OpenFileDialog();

            oFile.Title = "Open Image";
            oFile.Filter = "All images| *.png;*.gif;*.jpg;*.bmp";
            oFile.Multiselect = false;
            if(oFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.Copy(oFile.FileName, @"images\" + oFile.SafeFileName,true);
                    rowImage["imageName"] = oFile.SafeFileName;
                    rowImage["imagePath"] = @"images\" + oFile.SafeFileName;

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            tableAdapterManager.UpdateAll(databaseDataSet);
        }

        private void buttonTagAdd_Click(object sender, EventArgs e)
        {
            String tag = Microsoft.VisualBasic.Interaction.InputBox("new Tag");
            DataRow row = databaseDataSet.Tag.NewTagRow();
            row["tagName"] = tag;
            databaseDataSet.Tag.Rows.Add(row);
            databaseDataSet.Tag.AcceptChanges();
            DataTable t = databaseDataSet.Tag;
            checkedListBoxTag.Items.Clear();
            foreach (DataRow r in t.Rows)
            {
                checkedListBoxTag.Items.Add(r["tagName"]);
            }
        }

        private void comboBoxImage_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                foreach(DataRow r in dtImage.Rows)
                {
                    if(comboBoxImage.SelectedText == r["imageName"].ToString())
                    {
                        rowImage = r;
                    }
                }
                pictureBoxImage.ImageLocation = rowImage["imagePath"].ToString();
                textBoxIComment.Text = rowImage["imageComment"].ToString();
            }
            catch(Exception ex)
            {

            }

        }

        private void textBoxPComment_TextChanged(object sender, EventArgs e)
        {
            rowPage["pageComment"] = textBoxPComment.Text;
        }

        private void textBoxIComment_TextChanged(object sender, EventArgs e)
        {
            rowImage["imageComment"] = textBoxIComment.Text;
        }

        private void checkedListBoxTag_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
