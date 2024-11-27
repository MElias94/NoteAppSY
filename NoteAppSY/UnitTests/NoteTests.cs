using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoteAppSY;
using NUnit.Framework;
using NUnit.Framework.Legacy;


namespace UnitTests
{
    [TestFixture]
    public class NoteTests
    {
        [Test]
        public void Note_Name_ValidLength_ShouldSetName()
        {
            // Arrange
            var note = new Note();
            var validName = "This is a valid title";

            // Act
            note.Name = validName;

            // Assert
            ClassicAssert.AreEqual(validName, note.Name);
        }

        [Test]
        public void Note_Name_ExceedsMaxLength_ShouldThrowArgumentException()
        {
            // Arrange
            var note = new Note();
            var invalidName = new string('A', 36); // 36 символов

            // Act & Assert
            var ex = Assert.Throws<ArgumentException>(() => note.Name = invalidName);
            ClassicAssert.AreEqual("Note title symbols should not exceed 35 characters.", ex.Message);
        }
        [Test]
        public void Note_Name_Empty_ShouldThrowArgumentException()
        {
            // Arrange
            var note = new Note();
            var invalidName = new string('A', 0); // 0 символов

            // Act & Assert
            var ex = Assert.Throws<ArgumentException>(() => note.Name = invalidName);
            ClassicAssert.AreEqual("Note title should not be empty.", ex.Message);
        }

        [Test]
        public void Note_Properties_ShouldBeSetCorrectly()
        {
            // Arrange
            var note = new Note
            {
                Id = Guid.NewGuid(),
                Name = "Test Note",
                Text = "Test note content",
                Category = "General",
                LastUpdate = DateTime.Now,
                CreateTime = DateTime.Now.AddHours(-1)
            };

            // Assert
            ClassicAssert.IsNotNull(note.Id);
            ClassicAssert.AreEqual("Test Note", note.Name);
            ClassicAssert.AreEqual("Test note content", note.Text);
            ClassicAssert.AreEqual("General", note.Category);
            ClassicAssert.Less(note.CreateTime, note.LastUpdate);
        }
    }

    [TestFixture]
    public class NoteListTests
    {
        [Test]
        public void NoteList_AddNotes_ShouldContainNotes()
        {
            // Arrange
            var noteList = new NoteList();
            var note1 = new Note { Name = "Note 1", Text = "Content 1", Category = "Work" };
            var note2 = new Note { Name = "Note 2", Text = "Content 2", Category = "Personal" };

            // Act
            noteList.Notes.Add(note1);
            noteList.Notes.Add(note2);

            // Assert
            ClassicAssert.AreEqual(2, noteList.Notes.Count);
            ClassicAssert.Contains(note1, noteList.Notes);
            ClassicAssert.Contains(note2, noteList.Notes);
        }

        [Test]
        public void NoteList_FilterNotesByCategory_ShouldReturnFilteredNotes()
        {
            // Arrange
            var noteList = new NoteList();
            noteList.Notes.Add(new Note { Name = "Note 1", Text = "Content 1", Category = "Work" });
            noteList.Notes.Add(new Note { Name = "Note 2", Text = "Content 2", Category = "Personal" });

            // Act
            noteList.FilteredNotes.AddRange(noteList.Notes.FindAll(n => n.Category == "Work"));

            // Assert
            ClassicAssert.AreEqual(1, noteList.FilteredNotes.Count);
            ClassicAssert.AreEqual("Work", noteList.FilteredNotes[0].Category);
        }
    }
}
