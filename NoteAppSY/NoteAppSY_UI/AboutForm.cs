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
            this.Size = new Size(400, 300);
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {

        }
    }
}
