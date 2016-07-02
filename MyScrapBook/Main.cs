using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyScrapBook
{
    public partial class Main : Form
    {


        public Main()
        {
            InitializeComponent();
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
