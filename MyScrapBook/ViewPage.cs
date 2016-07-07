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
        public ViewPage(DataSet dtsDB,OleDbDataAdapter dAdView,DateTime viewDate)
        {
            InitializeComponent();
            date = viewDate;
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
            // TODO: This line of code loads data into the 'databaseDataSet.Page' table. You can move, or remove it, as needed.
          

        }
    }
}
