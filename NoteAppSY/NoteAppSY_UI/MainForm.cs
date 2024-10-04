using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using NoteAppSY;

namespace NoteAppSY_UI
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Список заметок
        /// </summary>
        private List<Note> _note = new List<Note>();
        /// <summary>
        /// Фильтрованный по категории список заметок   
        /// </summary>
        private List<Note> _filteredNotes = new List<Note>();
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
        
        public MainForm()
        {
            InitializeComponent();
            //notesListBox.SelectedIndex = 0;
            //FillListBoxByTestNote();
            notesCategory.SelectedItem = Category.All;
            foreach (Category category in Enum.GetValues(typeof(Category)))
            {
                notesCategory.Items.Add(category);
            }
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
            notesListBox.Items.Add(newNote.LastUpdate.ToLongTimeString() + " " + newNote.Name);
        }

        private void editNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
                if (notesListBox.SelectedIndex == -1)
                {
                    // Если ничего не выбрано, завершаем обработчик
                    MessageBox.Show("Выберите заметку перед редактированием");
                    return;
                }
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
                var name = updatedNote.Name;
                var time = updatedNote.LastUpdate.ToLongTimeString();
                var text = updatedNote.Text;
                notesListBox.Items.Insert(selectedIndex, time + " " + name);
        }
        private void FillListBoxByTestNote(int noteCount = 3)
        {
            for (int i = 0; i < 3; i++)
            {
                var note = new Note()
                {
                    Name = "Some text" + i,
                    LastUpdate = DateTime.Now
                };
                _note.Add(note);
                var name = note.Name;
                var time = note.LastUpdate.ToLongTimeString();
                var text = note.Text;
                notesListBox.Items.Add(time + " " + name);
            }
        }

        private void removeNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Проверяем, что элемент выбран
            if (notesListBox.SelectedIndex != -1)
            {
                // Удаляем элемент из _note
                int selectedIndex = notesListBox.SelectedIndex;
                _note.RemoveAt(selectedIndex);

                // Удаляем элемент из notesListBox.Items
                notesListBox.Items.RemoveAt(selectedIndex);

                // Обновляем SelectedIndex, если нужно
                if (notesListBox.Items.Count > 0 && selectedIndex >= notesListBox.Items.Count)
                {
                    notesListBox.SelectedIndex = notesListBox.Items.Count - 1;
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var about = new AboutForm(); //Создаем форму About
            about.ShowDialog();
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (notesCategory.SelectedItem != null)
            {
                Category selectedCategory = (Category)notesCategory.SelectedItem;
                notesListBox.Items.Clear();

                switch (selectedCategory)
                {
                    case Category.All:
                        _filteredNotes = _note;
                        break;
                    default:
                        _filteredNotes = _note.Where(n =>
                        {
                            Category category;
                            if (Enum.TryParse<Category>(n.Category, out category))
                            {
                                return category == selectedCategory;
                            }
                            else
                            {
                                // Обработка некорректного значения
                                return false;
                            }
                        }).ToList();
                        break;
                }

                foreach (var note in _filteredNotes)
                {
                    // Получение названия заметки и даты
                    UpdateNotesListBox();
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void notesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Проверяем, что элемент выбран
            if (notesListBox.SelectedIndex != -1)
            {
                noteTextBox.Text = _filteredNotes[notesListBox.SelectedIndex].Text;
            }
        }

        private void addPictureBox_Click(object sender, EventArgs e)
        {
            Note newNote = new Note();
            newNote.Name = "Новая заметка";
            newNote.Category = "Other";
            newNote.LastUpdate = DateTime.Now;
            _note.Add(newNote);
            notesListBox.Items.Add(newNote.LastUpdate.ToLongTimeString() + " " + newNote.Name);
        }
        private void editPictureBox_Click(object sender, EventArgs e)
        {
            if (notesListBox.SelectedIndex == -1)
            {
                // Если ничего не выбрано, завершаем обработчик
                MessageBox.Show("Выберите заметку перед редактированием");
                return;
            }
            //Получаем текущую выбранную дату
            var selectedIndex = notesListBox.SelectedIndex;
            var selectedNote = _filteredNotes[selectedIndex];
            var edit = new EditForm(); //Создаем форму 
            edit.Note = selectedNote; //Передаем форме данные
            edit.ShowDialog(); //Отображаем форму для редактирования
            var updatedNote = edit.Note; //Забираем измененные данные
            //Осталось удалить старые данные по выбранному индексу
            // и заменить их на обновленные
            int originalIndex = _note.IndexOf(selectedNote);
            _note.RemoveAt(originalIndex);
            _note.Insert(originalIndex, updatedNote);
            UpdateNotesListBox();
        }

        private void removePictureBox_Click(object sender, EventArgs e)
        {
            // Проверяем, что элемент выбран
            if (notesListBox.SelectedIndex != -1)
            {
                // Удаляем элемент из _note
                int selectedIndex = notesListBox.SelectedIndex;
                _note.RemoveAt(selectedIndex);

                // Удаляем элемент из notesListBox.Items
                notesListBox.Items.RemoveAt(selectedIndex);

                // Обновляем SelectedIndex, если нужно
                if (notesListBox.Items.Count > 0 && selectedIndex >= notesListBox.Items.Count)
                {
                    notesListBox.SelectedIndex = notesListBox.Items.Count - 1;
                }
            }
        }

        private void noteTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SerializeNotesToFile(string filePath)
        {
            // Сериализация списка заметок в JSON
            string json = JsonConvert.SerializeObject(_note, Formatting.Indented);

            // Запись JSON в файл
            File.WriteAllText(filePath, json);
        }

        private void DeserializeNotesFromFile(string filePath)
        {
            // Проверка существования файла
            if (File.Exists(filePath))
            {
                // Чтение JSON из файла
                string json = File.ReadAllText(filePath);

                // Десериализация JSON в список заметок
                _note = JsonConvert.DeserializeObject<List<Note>>(json);

                // Обновление ListBox (если нужно)
                UpdateNotesListBox();
            }
        }

        // Метод для обновления ListBox
        private void UpdateNotesListBox()
        {
            notesListBox.Items.Clear(); // Очищаем ListBox
            foreach (var note in _filteredNotes) // Используйте _note, а не _filteredNotes
            {
                string name = note.Name;
                string lastUpdate = note.LastUpdate.ToString("dd.MM.yyyy");
                notesListBox.Items.Add(lastUpdate + " " + name);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SerializeNotesToFile(@"d:\notes.json"); // Сохраняем данные при закрытии формы
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DeserializeNotesFromFile(@"d:\notes.json"); // Загружаем данные при загрузке формы
            notesCategory.SelectedIndex = 0;
        }
    }
    
}
