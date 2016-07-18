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
    public partial class Main : Form
    {
        private OleDbConnection objConn;
        private OleDbDataAdapter[] adapters = new OleDbDataAdapter[5];
        private DataSet dsDB;
        private string connexion;

        public Main()
        {
            InitializeComponent();
            connexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DatabaseScrap.accdb";
            objConn = new OleDbConnection(connexion);
            adapters[0] = new OleDbDataAdapter("Select * from Page", objConn);
            adapters[1] = new OleDbDataAdapter("Select * from Tag", objConn);
            adapters[2] = new OleDbDataAdapter("Select * from Picture", objConn);
            adapters[3] = new OleDbDataAdapter("Select * from pageImage", objConn);
            adapters[4] = new OleDbDataAdapter("Select * from pageTag", objConn);
            dsDB = new DataSet();
            adapters[0].FillSchema(dsDB, SchemaType.Source, "Page");
            adapters[1].FillSchema(dsDB, SchemaType.Source, "Tag");
            adapters[2].FillSchema(dsDB, SchemaType.Source, "Picture");
            adapters[3].FillSchema(dsDB, SchemaType.Source, "pageImage");
            adapters[4].FillSchema(dsDB, SchemaType.Source, "pageTag");
            adapters[0].Fill(dsDB, "Page");
            adapters[1].Fill(dsDB, "Tag");
            adapters[2].Fill(dsDB, "Picture");
            adapters[3].Fill(dsDB, "pageImage");
            adapters[4].Fill(dsDB, "pageTag");

        }

        private void Main_Load(object sender, EventArgs e)
        {
            Form start = new MainPage();
            start.MdiParent = this;
            start.FormBorderStyle = FormBorderStyle.None;
            start.Dock = DockStyle.Fill;
            start.Show();
        }
    }
}
