using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace NoteAppSY
{
    public class NoteFileManager
    {
        /// <summary>
        /// Сериализует список заметок в файл.
        /// </summary>
        /// <param name="filePath">Путь к файлу.</param>
        /// <param name="notes">Список заметок для сериализации.</param>
        public void SerializeNotesToFile(string filePath, List<Note> notes)
        {
            // Сериализация списка заметок в JSON
            string json = JsonConvert.SerializeObject(notes, Formatting.Indented);

            // Запись JSON в файл
            File.WriteAllText(filePath, json);
        }

        /// <summary>
        /// Десериализует список заметок из файла.
        /// </summary>
        /// <param name="filePath">Путь к файлу.</param>
        /// <returns>Список заметок из файла.</returns>
        public List<Note> DeserializeNotesFromFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<List<Note>>(json) ?? new List<Note>();
            }

            return new List<Note>();
        }
    }

}
