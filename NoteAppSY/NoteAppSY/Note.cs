using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoteAppSY;

namespace NoteAppSY
{
    /// <summary>
    /// Главный Класс, хранит информацию о заметках
    /// </summary>
    public class Note
    {
        public Guid Id { get; set; }
        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                if (value.Length > 35)
                {
                    throw new ArgumentException("Note title symbols should not exceed 35 characters.");
                }

                if (value.Length == 0)
                {
                    throw new ArgumentException("Note title should not be empty.");
                }
                _name = value;
            }
        }
        public string Text { get; set; }
        public string Category { get; set; }
        public DateTime LastUpdate;
        public DateTime CreateTime;
    }
    public class NoteList
    {
        ///<summary>
        ///Список заметок
        /// </summary>
        public List<Note> Notes { get; private set; }
        ///<summary>
        ///Список заметок фильтрованный по категории
        /// </summary>
        public List<Note> FilteredNotes { get; private set; }

        public NoteList()
        {
            Notes = new List<Note>();
            FilteredNotes = new List<Note>();
        }

        // Добавляем метод для замены всего списка заметок
        public void SetNotes(List<Note> notes)
        {
            Notes = notes;
        }

            public void UpdateFilteredNotes(Category selectedCategory)
        {
            FilteredNotes.Clear();
            if (selectedCategory == Category.All)
            {
                FilteredNotes.AddRange(Notes);
            }
            else
            {
                FilteredNotes.AddRange(Notes.Where(n =>
                {
                    Category category;
                    return Enum.TryParse<Category>(n.Category, out category) && category == selectedCategory;
                }));
            }
        }
    }
}
