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
    public partial class MainForm : Form
    {
        private List<Note> _note = new List<Note>();
        /// <summary>
        /// Список категорий    
        /// </summary>
        public enum Category
        {
            All,
            Home,
            Work,
            Health,
            People,
            Docs,
            Finance,
            Other,
        }
        /// <summary>
        /// Список заметок
        /// </summary>
        public enum NoteListBox
        {
            Example,
        }

        public MainForm()
        {
            InitializeComponent();
            notesCategory.Items.Add(Category.All);
            notesCategory.Items.Add(Category.Home);
            notesCategory.Items.Add(Category.Work);
            notesCategory.Items.Add(Category.Health);
            notesCategory.Items.Add(Category.People);
            notesCategory.Items.Add(Category.Docs);
            notesCategory.Items.Add(Category.Finance);
            notesCategory.Items.Add(Category.Other);
            notesCategory.SelectedIndex = 0;
            //notesListBox.SelectedIndex = 0;
            FillListBoxByTestNote();
        }
        
        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Note newNote = new Note();
            newNote.Name = "Новая заметка";
            newNote.Category = "Other";
            newNote.LastUpdate = DateTime.Now;
            _note.Add(newNote);
            notesListBox.Items.Add(newNote.LastUpdate.ToLongTimeString() + newNote.Name);
        }

        private void editNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
                //Получаем текущую выбранную дату
                var selectedIndex = notesListBox.SelectedIndex;
                var selectedNote = _note[selectedIndex];
                var edit = new EditForm(); //Создаем форму 
                edit.Note = selectedNote; //Передаем форме данные
                edit.ShowDialog(); //Отображаем форму для редактирования
                var updatedNote = edit.Note; //Забираем измененные данные
                //Осталось удалить старые данные по выбранному индексу
                // и заменить их на обновленные
                notesListBox.Items.RemoveAt(selectedIndex);
                _note.RemoveAt(selectedIndex);
                _note.Insert(selectedIndex, updatedNote);
                var time = updatedNote.LastUpdate.ToLongTimeString();
                var text = updatedNote.Text;
                notesListBox.Items.Insert(selectedIndex, time + " " + text);
        }
        private void FillListBoxByTestNote(int noteCount = 3)
        {
            for (int i = 0; i < 3; i++)
            {
                var note = new Note()
                {
                    Text = "Some text" + i,
                    LastUpdate = DateTime.Now
                };
                _note.Add(note);
                var time = note.LastUpdate.ToLongTimeString();
                var text = note.Text;
                notesListBox.Items.Add(time + " " + text);
            }
        }

        private void removeNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var about = new AboutForm(); //Создаем форму About
            about.Show();
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void notesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addPictureBox_Click(object sender, EventArgs e)
        {
            Note newNote = new Note();
            newNote.Name = "Новая заметка";
            newNote.Category = "Other";
            _note.Add(newNote);
            notesListBox.Items.Add(newNote.Name);
        }
        private void editPictureBox_Click(object sender, EventArgs e)
        {
            //Получаем текущую выбранную дату
            var selectedIndex = notesListBox.SelectedIndex;
            var selectedNote = _note[selectedIndex];
            var edit = new EditForm(); //Создаем форму
            edit.Note = selectedNote; //Передаем форме данные
            edit.ShowDialog(); //Отображаем форму для редактирования
            var updatedNote = edit.Note; //Забираем измененные данные
            //Осталось удалить старые данные по выбранному индексу
            // и заменить их на обновленные
            notesListBox.Items.RemoveAt(selectedIndex);
            _note.RemoveAt(selectedIndex);
            _note.Insert(selectedIndex, updatedNote);
            var time = updatedNote.LastUpdate.ToLongTimeString();
            var text = updatedNote.Text;
            notesListBox.Items.Insert(selectedIndex, time + " " + text);
        }

        private void removePictureBox_Click(object sender, EventArgs e)
        {

        }
    }
    
}
