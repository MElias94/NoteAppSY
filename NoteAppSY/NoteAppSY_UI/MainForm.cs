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
        ///<summary>
        ///Список заметок
        /// </summary>
        private NoteList _noteList = new NoteList();

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
                        foreach (Note note in _noteList.Notes)
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
                    _noteList.Notes.Clear();

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
                                Id = Guid.NewGuid(),
                                Name = noteParts[0],
                                Text = noteParts[1],
                                Category = noteParts[2],
                                LastUpdate = DateTime.Parse(noteParts[3]),
                                CreateTime = DateTime.Parse(noteParts[4])
                            };

                            _noteList.Notes.Add(note);
                            UpdateNotesListBox();
                            categoryComboBox_SelectedIndexChanged(sender, e);
                            ClearTextForms();

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
            newNote.Id = Guid.NewGuid();
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
                _noteList.Notes.Add(updatedNote);
                UpdateNotesListBox();
                categoryComboBox_SelectedIndexChanged(sender, e);
                notesListBox.SelectedIndex = 0;
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
            //Получаем текущую выбранную заметку
            var selectedIndex = notesListBox.SelectedIndex;
            var selectedNote = _noteList.FilteredNotes[selectedIndex];
            var edit = new EditForm(); //Создаем форму 
            edit.Note = selectedNote; //Передаем форме данные
            edit.ShowDialog(); //Отображаем форму для редактирования
            var updatedNote = edit.Note; //Забираем измененные данные
            //Осталось удалить старые данные по выбранному индексу
            // и заменить их на обновленные
            int originalIndex = _noteList.Notes.IndexOf(selectedNote);
            _noteList.Notes.RemoveAt(originalIndex);
            _noteList.Notes.Insert(originalIndex, updatedNote);
            UpdateNotesListBox();
            categoryComboBox_SelectedIndexChanged(sender, e);
            notesListBox.SelectedIndex = 0;
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
                    Id = Guid.NewGuid(),
                    Name = "Some text" + i,
                    LastUpdate = DateTime.Now,
                    Text = i + " Note " + i
                };
                _noteList.Notes.Add(note);
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
                Note selectedNote = _noteList.FilteredNotes[notesListBox.SelectedIndex];
                DialogResult result = MessageBox.Show("Do you really want to remove this note: " + _noteList.FilteredNotes[notesListBox.SelectedIndex].Name,
                    "Remove note",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    // Находим заметку по Id в основном списке _note
                    int noteIndex = _noteList.Notes.FindIndex(n => n.Id == selectedNote.Id);
                    int selectedIndex = notesListBox.SelectedIndex;

                    if (noteIndex != -1)
                    {
                        _noteList.Notes.RemoveAt(noteIndex); // Удаляем заметку из основного списка _note
                    }

                    // Удаляем заметку из _noteList.FilteredNotes
                    _noteList.FilteredNotes.RemoveAt(notesListBox.SelectedIndex);

                    // Обновляем список заметок
                    UpdateNotesListBox();

                    // Обновляем SelectedIndex, если нужно
                    if (notesListBox.Items.Count > 0)
                    {
                        // Выбираем следующий элемент, если не последний
                        if (selectedIndex < notesListBox.Items.Count)
                        {
                            notesListBox.SelectedIndex = selectedIndex;
                        }
                        // Выбираем предыдущий элемент, если не первый
                        else if (selectedIndex > 0)
                        {
                            notesListBox.SelectedIndex = selectedIndex - 1;
                        }
                        // Если удален единственный элемент, список пуст - ничего не выбираем
                    }
                    else if (notesListBox.Items.Count == 0)
                    {
                        ClearTextForms();
                    }
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var about = new AboutForm(); //Создаем форму About
            about.ShowDialog();
        }

        // Действие при смене категории
        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (notesCategory.SelectedItem != null)
            {
                Category selectedCategory = (Category)notesCategory.SelectedItem;

                // Очищаем _noteList.FilteredNotes
                _noteList.FilteredNotes.Clear();

                // Фильтруем заметки
                switch (selectedCategory)
                {
                    case Category.All:
                        // Заполняем _noteList.FilteredNotes всеми заметками
                        _noteList.FilteredNotes.AddRange(_noteList.Notes); // Важно!
                        break;
                    default:
                        // Фильтруем заметки по категории
                        _noteList.FilteredNotes.AddRange(_noteList.Notes.Where(n =>
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
                        })); // Важно!
                        break;
                }

                // Обновляем список заметок в notesListBox
                UpdateNotesListBox();
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
                selectedTitleTextBox.Text = _noteList.FilteredNotes[notesListBox.SelectedIndex].Name;
                noteTextBox.Text = _noteList.FilteredNotes[notesListBox.SelectedIndex].Text;
                selectedCategoryNameTextBox.Text = _noteList.FilteredNotes[notesListBox.SelectedIndex].Category;
                lastUpdateSelectedTextBox.Text = _noteList.FilteredNotes[notesListBox.SelectedIndex].LastUpdate.ToShortDateString();
                createSelectedTextBox.Text = _noteList.FilteredNotes[notesListBox.SelectedIndex].CreateTime.ToShortDateString();
            }
        }

        private void addPictureBox_Click(object sender, EventArgs e)
        {
            addNoteToolStripMenuItem_Click(sender, e);
        }
        private void addPictureBox_MouseHover(object sender, EventArgs e)
        {
            // Создайте объект ToolTip
            ToolTip toolTip = new ToolTip();
            // Задайте текст подсказки
            toolTip.SetToolTip(addPictureBox, "Добавить заметку");
        }
        private void editPictureBox_Click(object sender, EventArgs e)
        {
            editNoteToolStripMenuItem_Click(sender, e);
        }
        private void editPictureBox_MouseHover(object sender, EventArgs e)
        {
            // Создайте объект ToolTip
            ToolTip toolTip = new ToolTip();
            // Задайте текст подсказки
            toolTip.SetToolTip(editPictureBox, "Изменить заметку");
        }
        private void removePictureBox_Click(object sender, EventArgs e)
        {
            removeNoteToolStripMenuItem_Click(sender, e);
        }
        private void removePictureBox_MouseHover(object sender, EventArgs e)
        {
            // Создайте объект ToolTip
            ToolTip toolTip = new ToolTip();
            // Задайте текст подсказки
            toolTip.SetToolTip(removePictureBox, "Удалить заметку");
        }
        private void noteTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SerializeNotesToFile(string filePath)
        {
            // Сериализация списка заметок в JSON
            string json = JsonConvert.SerializeObject(_noteList.Notes, Formatting.Indented);

            // Запись JSON в файл
            File.WriteAllText(filePath, json);
        }

        private void DeserializeNotesFromFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                var notes = JsonConvert.DeserializeObject<List<Note>>(json);
                _noteList.SetNotes(notes);
                UpdateNotesListBox();
            }
        }

        /// <summary>
        /// Метод для очистки текстовых форм
        /// </summary>
        private void ClearTextForms()
        {
            selectedTitleTextBox.Clear();
            noteTextBox.Clear();
            selectedCategoryNameTextBox.Clear();
            lastUpdateSelectedTextBox.Clear();
            createSelectedTextBox.Clear();
        }
        /// <summary>
        /// Метод для обновления notesListBox
        /// </summary>
        public void UpdateNotesListBox()
        {
            notesListBox.Items.Clear(); // Очищаем ListBox
            // Сортируем заметки по дате изменения (новые сверху)
            _noteList.FilteredNotes.Sort((x, y) => y.LastUpdate.CompareTo(x.LastUpdate));
            foreach (var note in _noteList.FilteredNotes)
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
