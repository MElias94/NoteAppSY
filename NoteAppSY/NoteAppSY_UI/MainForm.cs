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
        private readonly NoteList _noteList = new NoteList();

        private readonly NoteFileManager _fileManager = new NoteFileManager();

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
            ExportNotes();
        }

        /// <summary>
        /// Экспорт заметок
        /// </summary>
        public void ExportNotes()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|JSON файлы (*.json)|*.json";
            saveFileDialog.Title = "Сохранить заметки";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    switch (saveFileDialog.FilterIndex)
                    {
                        case 1: // Текстовый файл (.txt)
                            using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                            {
                                foreach (Note note in _noteList.Notes)
                                {
                                    // Сохраняем каждую заметку в виде одной строки, разделенной символом ';'
                                    string noteData = $"{note.Name};{note.Text};{note.Category};{note.LastUpdate.ToString("yyyy-MM-dd HH:mm:ss")};{note.CreateTime.ToString("yyyy-MM-dd HH:mm:ss")}";
                                    writer.WriteLine(noteData);
                                }
                            }
                            break;

                        case 2: // JSON файл (.json)
                            var notesJson = JsonConvert.SerializeObject(_noteList.Notes, Formatting.Indented); // Предполагает использование Newtonsoft.Json
                            File.WriteAllText(saveFileDialog.FileName, notesJson);
                            break;

                        default:
                            throw new NotSupportedException($"Неизвестный формат файла: {saveFileDialog.FilterIndex}");
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
            ImportNotes();
        }
        /// <summary>
        /// Импорт заметок
        /// </summary>
        public void ImportNotes()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|JSON файлы (*.json)|*.json";
            openFileDialog.Title = "Загрузить заметки";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Очищаем список заметок
                    _noteList.Notes.Clear();

                    switch (openFileDialog.FilterIndex)
                    {
                        case 1: // Текстовый файл (.txt)
                            using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                            {
                                string line;
                                while ((line = reader.ReadLine()) != null)
                                {
                                    // Разделение строки на отдельные значения
                                    string[] noteParts = line.Split(';');

                                    // Проверка, что количество элементов соответствует ожидаемому
                                    if (noteParts.Length < 5)
                                    {
                                        throw new FormatException("Неверное количество полей в строке");
                                    }

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
                                    CategoryChange();
                                    ClearTextForms();
                                }
                            }
                            break;

                        case 2: // JSON файл (.json)
                            List<Note> importedNotes = JsonConvert.DeserializeObject<List<Note>>(File.ReadAllText(openFileDialog.FileName));
                            foreach (var note in importedNotes)
                            {
                                note.Id = Guid.NewGuid(); // Обновляем GUID для новых заметок
                                _noteList.Notes.Add(note);
                                UpdateNotesListBox();
                                CategoryChange();
                                ClearTextForms();
                            }
                            break;

                        default:
                            throw new NotSupportedException($"Неизвестный формат файла: {openFileDialog.FilterIndex}");
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
            AddNote();
        }

        private void editNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditNote();
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
            RemoveNote();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var about = new AboutForm(); //Создаем форму About
            about.ShowDialog();
        }

        // Действие при смене категории
        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CategoryChange();
        }

        /// <summary>
        /// Создать заметку
        /// </summary>
        public void AddNote()
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
                CategoryChange();
                notesListBox.SelectedIndex = 0;
            }
        }
        /// <summary>
        /// Редактировать заметку
        /// </summary>
        public void EditNote()
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
            if (edit.DialogResult == DialogResult.OK) //При нажатии ок на форме Edit обновляем список
            {
                var updatedNote = edit.Note; //Забираем измененные данные
                //Осталось удалить старые данные по выбранному индексу
                // и заменить их на обновленные
                int originalIndex = _noteList.Notes.IndexOf(selectedNote);
                _noteList.Notes.RemoveAt(originalIndex);
                _noteList.Notes.Insert(originalIndex, updatedNote);
                UpdateNotesListBox();
                CategoryChange();
                notesListBox.SelectedIndex = 0;
            }
            else notesListBox.SelectedIndex = selectedIndex;
        }
        /// <summary>
        /// Удалить заметку
        /// </summary>
        public void RemoveNote()
        {
            // Получаем индексы выбранных заметок
            List<int> selectedIndices = notesListBox.SelectedIndices.Cast<int>().ToList();

            if (!selectedIndices.Any())
            {
                return; // Ничего не выбрано, выход из функции
            }

            // Формируем сообщение в зависимости от количества выбранных заметок
            string message = selectedIndices.Count == 1
                ? $"Do you really want to remove this note: {_noteList.FilteredNotes[selectedIndices[0]].Name}?"
                : $"Are you sure you want to delete {selectedIndices.Count} notes?";

            DialogResult result = MessageBox.Show(message, "Delete Notes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Сортируем индексы в обратном порядке, чтобы удаление не влияло на последующие индексы
                selectedIndices.Sort((a, b) => b.CompareTo(a));

                // Проходимся по всем выбранным заметкам и удаляем их из обоих списков
                foreach (int index in selectedIndices)
                {
                    Note note = _noteList.FilteredNotes[index]; // Получаем заметку по индексу из FilteredNotes

                    // Находим заметку по Id в основном списке _note
                    int noteIndex = _noteList.Notes.FindIndex(n => n.Id == note.Id);

                    if (noteIndex != -1)
                    {
                        _noteList.Notes.RemoveAt(noteIndex); // Удаляем заметку из основного списка _note
                    }

                    // Удаляем заметку из _noteList.FilteredNotes
                    _noteList.FilteredNotes.RemoveAt(index);
                }

                // Обновляем список заметок
                UpdateNotesListBox();

                // Если остались заметки, выбираем первую
                if (_noteList.FilteredNotes.Count > 0)
                {
                    notesListBox.SelectedIndex = 0;
                }
                else
                {
                    ClearTextForms();
                }
            }
        }

        /// <summary>
        /// Изменить категорию
        /// </summary>
        public void CategoryChange()
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
            AddNote();
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
            EditNote();
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
            RemoveNote();
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
        /// Метод для обновления отоброжаемого списка заметок
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

        /// <summary>
        /// Сериализовать заметки
        /// </summary>
        private void SaveNotes(string filePath)
        {
            _fileManager.SerializeNotesToFile(filePath, _noteList.Notes);
        }
        /// <summary>
        /// Десериализовать заметки
        /// </summary>
        private void LoadNotes(string filePath)
        {
            var notes = _fileManager.DeserializeNotesFromFile(filePath);
            _noteList.SetNotes(notes);
            UpdateNotesListBox();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to save changes?",
                "Exit",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SaveNotes(@"d:\notes.json"); // Сохраняем данные при закрытии формы
            }
            else if (result == DialogResult.Cancel) // Обработка Cancel
            {
                e.Cancel = true; // Отменяем закрытие формы
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadNotes(@"d:\notes.json"); // Загружаем данные при загрузке формы
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
