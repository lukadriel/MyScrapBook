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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            Form newEntry = new NewPage(mainCalendar.SelectionStart);
            newEntry.MdiParent = MdiParent;
            newEntry.FormBorderStyle = FormBorderStyle.None;
            newEntry.Dock = DockStyle.Fill;
            Close();
            newEntry.Show();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Form edit = new EditPage();
            edit.MdiParent = MdiParent;
            edit.FormBorderStyle = FormBorderStyle.None;
            edit.Dock = DockStyle.Fill;
            Close();
            edit.Show();
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            Form view = new ViewPage();
            view.MdiParent = MdiParent;
            view.FormBorderStyle = FormBorderStyle.None;
            view.Dock = DockStyle.Fill;
            Close();
            view.Show();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            pageTableAdapter.GetData();
            pageTableAdapter.Fill(databaseDataSet.Page);
            DateTime d = new DateTime();
            foreach(DataRow row in databaseDataSet.Page.Rows)
            {
                d = DateTime.Parse(row["pageDate"].ToString());
                mainCalendar.AddBoldedDate(d);
            }
            mainCalendar.UpdateBoldedDates();
            if(mainCalendar.BoldedDates.Contains(DateTime.Today))
            {
                buttonView.Enabled = true;
                buttonEdit.Enabled = true;
                buttonNew.Enabled = false;
            }
        }

        private void mainCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (mainCalendar.BoldedDates.Contains(mainCalendar.SelectionStart))
            {
                buttonView.Enabled = true;
                buttonEdit.Enabled = true;
                buttonNew.Enabled = false;
            }
            else
            {
                buttonView.Enabled = false;
                buttonEdit.Enabled = false;
                buttonNew.Enabled = true;
            }
        }
    }
}
