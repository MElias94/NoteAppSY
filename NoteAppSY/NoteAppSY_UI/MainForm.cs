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
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt";
            saveFileDialog.Title = "Сохранить заметки";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Сохранение заметок в текстовый файл
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        foreach (Note note in _note)
                        {
                            // Сохранение всех свойств заметки в одну строку, разделенную символом ';'
                            string noteData = $"{note.Name};{note.Text};{note.Category};{note.LastUpdate.ToString("yyyy-MM-dd HH:mm:ss")};{note.CreateTime.ToString("yyyy-MM-dd HH:mm:ss")}";
                            writer.WriteLine(noteData);
                        }
                    }

                    MessageBox.Show("Заметки успешно сохранены!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при сохранении: " + ex.Message);
                }
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt";
            openFileDialog.Title = "Загрузить заметки";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Очищаем список заметок
                    _note.Clear();

                    // Загрузка заметок из текстового файла
                    using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            // Разделение строки на отдельные значения
                            string[] noteParts = line.Split(';');

                            // Создание новой заметки и инициализация ее свойств
                            Note note = new Note
                            {
                                Name = noteParts[0],
                                Text = noteParts[1],
                                Category = noteParts[2],
                                LastUpdate = DateTime.Parse(noteParts[3]),
                                CreateTime = DateTime.Parse(noteParts[4])
                            };

                            _note.Add(note);
                            UpdateNotesListBox();
                        }
                    }

                    MessageBox.Show("Заметки успешно загружены!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке: " + ex.Message);
                }
            }
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
            newNote.CreateTime = DateTime.Now;
            var edit = new EditForm(); //Создаем форму 
            edit.Note = newNote; //Передаем форме данные
            edit.ShowDialog(); //Отображаем форму для редактирования
            if (edit.DialogResult == DialogResult.OK) //При нажатии ок на форме Edit создаем новую заметку
            {
                var updatedNote = edit.Note;
                _note.Add(updatedNote);
                UpdateNotesListBox();
            }
        }

        private void editNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (notesListBox.SelectedIndex == -1)
            {
                // Если ничего не выбрано, выводим предупреждение
                MessageBox.Show("Select note before editing");
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
        /// <summary>
        /// Код для заполнения формы заметками
        /// </summary>
        private void FillListBoxByTestNote(int noteCount = 3)
        {
            for (int i = 0; i < noteCount; i++)
            {
                var note = new Note()
                {
                    Name = "Some text" + i,
                    LastUpdate = DateTime.Now,
                    Text = i + " Note " + i
                };
                _note.Add(note);
                var name = note.Name;
                var time = note.LastUpdate.ToShortDateString();
                var text = note.Text;
                notesListBox.Items.Add(time + " " + name);
                UpdateNotesListBox();
            }
        }

        private void removeNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Проверяем, что элемент выбран
            if (notesListBox.SelectedIndex != -1)
            {
                DialogResult result = MessageBox.Show("Do you really want to remove this note: " + _filteredNotes[notesListBox.SelectedIndex].Name,
                    "Remove note",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);
                if (result == DialogResult.OK)
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
                    // Перерисовываем список
                    notesListBox.Refresh();
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
                selectedTitleTextBox.Text = _filteredNotes[notesListBox.SelectedIndex].Name;
                noteTextBox.Text = _filteredNotes[notesListBox.SelectedIndex].Text;
                selectedCategoryNameTextBox.Text = _filteredNotes[notesListBox.SelectedIndex].Category;
                lastUpdateSelectedTextBox.Text = _filteredNotes[notesListBox.SelectedIndex].LastUpdate.ToShortDateString();
                createSelectedTextBox.Text = _filteredNotes[notesListBox.SelectedIndex].CreateTime.ToShortDateString();
            }
        }

        private void addPictureBox_Click(object sender, EventArgs e)
        {
            Note newNote = new Note();
            newNote.Name = "Новая заметка";
            newNote.Category = "Other";
            newNote.LastUpdate = DateTime.Now;
            newNote.CreateTime = DateTime.Now;
            var edit = new EditForm(); //Создаем форму 
            edit.Note = newNote; //Передаем форме данные
            edit.ShowDialog(); //Отображаем форму для редактирования
            if (edit.DialogResult == DialogResult.OK) //При нажатии ок на форме Edit создаем новую заметку
            {
                var updatedNote = edit.Note;
                _note.Add(updatedNote);
                UpdateNotesListBox();
            }
        }
        private void editPictureBox_Click(object sender, EventArgs e)
        {
            if (notesListBox.SelectedIndex == -1)
            {
                // Если ничего не выбрано, выводим предупреждение
                MessageBox.Show("Select note before editing");
                return;
            }
            //Получаем текущую выбранную заметку
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
                DialogResult result = MessageBox.Show("Do you really want to remove this note: " + _filteredNotes[notesListBox.SelectedIndex].Name,
                    "Remove note",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);
                if (result == DialogResult.OK)
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
                    // Перерисовываем список
                    notesListBox.Refresh();
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
            // Сортируем заметки по дате изменения (новые сверху)
            _filteredNotes.Sort((x, y) => y.LastUpdate.CompareTo(x.LastUpdate));
            foreach (var note in _filteredNotes)
            {
                string name = note.Name;
                string lastUpdateD = note.LastUpdate.ToString("dd.MM.yyyy");
                string lastUpdateH = note.LastUpdate.ToString("HH:mm");
                notesListBox.Items.Add(lastUpdateD + " " + name);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to save changes?",
                "Exit",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SerializeNotesToFile(@"d:\notes.json"); // Сохраняем данные при закрытии формы
            }
            else if (result == DialogResult.Cancel) // Обработка Cancel
            {
                e.Cancel = true; // Отменяем закрытие формы
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DeserializeNotesFromFile(@"d:\notes.json"); // Загружаем данные при загрузке формы
            notesCategory.SelectedIndex = 0;
        }

        private void selectedCategoryNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void selectedCategoryTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateTimeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastUpdateSelectedTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void selectedTitleNameTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void selectedTitleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void statusGroupBox_Paint(object sender, PaintEventArgs e)
        {

        }

        private void createTimeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void createSelectedTextBox_TextChanged(object sender, EventArgs e)
        {

        }

    }
    
}
