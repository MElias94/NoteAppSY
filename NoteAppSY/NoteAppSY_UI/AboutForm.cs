using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteAppSY_UI
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            this.Text = "About";
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            aboutMainTextBox.SelectionStart = 0;
        }

        private void aboutMainTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void aboutTitleTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
