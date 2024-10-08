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
                    editNotesCategory.Text = _note.Category;
                    createSelectedTextBox.Text = _note.CreateTime.ToShortDateString();
                    lastUpdateSelectedTextBox.Text = _note.LastUpdate.ToShortDateString();
                }
            }
        }
        public EditForm()
        {
            InitializeComponent();
            this.Text = "Редактор";
            foreach (Category category in Enum.GetValues(typeof(Category)))
            {
                editNotesCategory.Items.Add(category);
            }
            editNotesCategory.SelectedIndex = 0; // Установка начального значения
        }
        private void NoteTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void OkButton_Click(object sender, EventArgs e)
        {
            if (noteNameTextBox.Text.Length > 25)
            {
                MessageBox.Show("Note title symbols should not except 25");
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                _note.Name = noteNameTextBox.Text;
                _note.Text = NoteTextBox.Text;
                _note.LastUpdate = DateTime.Now;
                _note.Category = editNotesCategory.Text;
                this.Close();
            }
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (NoteTextBox.Text.Length > 0)
            {
                DialogResult result = MessageBox.Show("Close without saving?",
                    "Close",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    DialogResult = DialogResult.Cancel; // Закрытие формы
                    this.Close(); // Закрытие формы
                }
                else if (result == DialogResult.Cancel) // Обработка Cancel
                {
                    return; // Выходим из обработчика, чтобы не закрывать форму
                }
            }

            DialogResult = DialogResult.Cancel; // Закрытие формы
            this.Close(); // Закрытие формы
        }
        private void EditForm_Load(object sender, EventArgs e)
        {
            NoteTextBox.SelectionStart = NoteTextBox.Text.Length;
        }

        private void noteNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void enterNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void selectCategoryTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void editNotesCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void createTimeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateTimeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void createSelectedTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastUpdateSelectedTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
