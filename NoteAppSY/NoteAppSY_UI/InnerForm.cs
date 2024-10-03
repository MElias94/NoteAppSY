using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteAppSY;

namespace NoteAppSY_UI
{
    public partial class InnerForm : Form
    {
        private Note _note;
        public Note Note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
                if (_note != null)
                {
                    NoteTextBox.Text = _note.Text;
                }
            }
        }
        public InnerForm()
        {
            InitializeComponent();
        }
        private void NoteTextBox_TextChanged(object sender, EventArgs e)
        {
            _note.Text = NoteTextBox.Text;
            _note.LastUpdate = DateTime.Now;
        }
        private void OkButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
        private void InnerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
