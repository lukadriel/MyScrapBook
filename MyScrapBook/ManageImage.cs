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
    public partial class ManageImage : Form
    {
        public ManageImage(OpenFileDialog ofd, DataTable dtImg)
        {
            InitializeComponent();
            image = ofd;
            dtMain = dtImg;
            pictureBox.ImageLocation = ofd.FileName;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            DataRow row = dtMain.NewRow();
            row[1] = @"images\" + image.SafeFileName;
            row[2] = image.SafeFileName;
            row[3] = textBoxComment.Text;
            dtMain.Rows.Add(row);
        }
    }
}
