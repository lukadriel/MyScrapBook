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
    public partial class EditPage : Form
    {
        public EditPage()
        {
            InitializeComponent();
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
    }
}
