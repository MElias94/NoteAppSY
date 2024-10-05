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
        public string Name { get; set; }
        public string Text;
        public string Category { get; set; }
        public DateTime LastUpdate;
        public DateTime CreateTime;
    }

}
