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
            connexionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DatabaseScrap.accdb";
            objConn = new OleDbConnection(connexionString);
            objConn.Open();
            dsDB = new DataSet();
            daPage = new OleDbDataAdapter("Select * from Page", objConn);
            daPage.FillSchema(dsDB, SchemaType.Source, "Page");
            daPage.Fill(dsDB, "Page");
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

       

        private void buttonView_Click(object sender, EventArgs e)
        {
            Form view = new ViewPage(dsDB, daPage, mainCalendar.SelectionStart);
            view.MdiParent = MdiParent;
            view.FormBorderStyle = FormBorderStyle.None;
            view.Dock = DockStyle.Fill;
            Close();
            view.Show();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

            DateTime d = new DateTime();
            foreach(DataRow row in dsDB.Tables["Page"].Rows)
            {
                d = DateTime.Parse(row["pageDate"].ToString());
                mainCalendar.AddBoldedDate(d);
            }
            mainCalendar.UpdateBoldedDates();
            if(mainCalendar.BoldedDates.Contains(DateTime.Today))
            {
                buttonView.Enabled = true;                
                buttonNew.Enabled = false;
            }
        }

        private void mainCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (mainCalendar.BoldedDates.Contains(mainCalendar.SelectionStart))
            {
                buttonView.Enabled = true;                
                buttonNew.Enabled = false;
            }
            else
            {
                buttonView.Enabled = false;                
                buttonNew.Enabled = true;
            }
        }
    }
}
