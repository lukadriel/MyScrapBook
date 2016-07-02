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
        public NewPage()
        {
            InitializeComponent();
        }

        private void getData()
        {
            tableAdapterManager.TagTableAdapter.GetData();
            tableAdapterManager.PageTableAdapter.GetData();
            tableAdapterManager.ImageTableAdapter.GetData();
            tableAdapterManager.pageTagTableAdapter.GetData();
            tableAdapterManager.pageImageTableAdapter.GetData();
        }

        private void fill()
        {
            tableAdapterManager.TagTableAdapter.Fill(databaseDataSet.Tag);
            tableAdapterManager.PageTableAdapter.Fill(databaseDataSet.Page);
            tableAdapterManager.ImageTableAdapter.Fill(databaseDataSet.Image);
            tableAdapterManager.pageTagTableAdapter.Fill(databaseDataSet.pageTag);
            tableAdapterManager.pageImageTableAdapter.Fill(databaseDataSet.pageImage);
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
        }

        private void buttonAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFile = new OpenFileDialog();
            oFile.Title = "Open Image";
            oFile.Filter = "All images| *.png;*.gif;*.jpg";
            oFile.Multiselect = false;
            if(oFile.ShowDialog() == DialogResult.OK)
            {
                try
                {

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
