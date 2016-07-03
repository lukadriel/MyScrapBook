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
    public partial class AddTag : Form
    {
        public AddTag()
        {
            InitializeComponent();
        }

        private void AddTag_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Tag' table. You can move, or remove it, as needed.
            tagTableAdapter.GetData();
            tagTableAdapter.Fill(databaseDataSet.Tag);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.Validate();

        }
    }
}
