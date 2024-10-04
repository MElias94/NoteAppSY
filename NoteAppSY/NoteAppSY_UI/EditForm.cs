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
    public partial class EditForm : Form
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
                    noteNameTextBox.Text = _note.Name;
                    NoteTextBox.Text = _note.Text;
                }
            }
        }
        public EditForm()
        {
            InitializeComponent();
            this.Text = "Редактор";
            this.Size = new Size(400, 300);
        }
        private void NoteTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void OkButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            _note.Name = noteNameTextBox.Text;
            _note.Text = NoteTextBox.Text;
            _note.LastUpdate = DateTime.Now;
            this.Close();
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void InnerForm_Load(object sender, EventArgs e)
        {

        }

        private void noteNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void enterNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
