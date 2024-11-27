using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoteAppSY;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace UnitTests
{
    [TestFixture]
    public class NoteFileManagerTests
    {
        private NoteFileManager _fileManager;
        private string _testFilePath;

        [SetUp]
        public void SetUp()
        {
            _fileManager = new NoteFileManager();
            _testFilePath = Path.Combine(Path.GetTempPath(), "test_notes.json");
        }

        [TearDown]
        public void TearDown()
        {
            if (File.Exists(_testFilePath))
            {
                File.Delete(_testFilePath);
            }
        }

        [Test]
        public void SerializeNotesToFile_ShouldCreateFileWithValidContent()
        {
            // Arrange
            var notes = new List<Note>
        {
            new Note
            {
                Id = Guid.NewGuid(),
                Name = "Test Note",
                Text = "This is a test note.",
                Category = "General",
                LastUpdate = DateTime.Now,
                CreateTime = DateTime.Now
            }
        };

            // Act
            _fileManager.SerializeNotesToFile(_testFilePath, notes);

            // Assert
            ClassicAssert.IsTrue(File.Exists(_testFilePath), "File was not created.");
            string content = File.ReadAllText(_testFilePath);
            ClassicAssert.IsNotEmpty(content, "File content is empty.");
            ClassicAssert.That(content, Does.Contain("Test Note"), "Serialized content is incorrect.");
        }

        [Test]
        public void DeserializeNotesFromFile_ShouldReturnValidNotesList()
        {
            // Arrange
            var notes = new List<Note>
        {
            new Note
            {
                Id = Guid.NewGuid(),
                Name = "Test Note",
                Text = "This is a test note.",
                Category = "General",
                LastUpdate = DateTime.Now,
                CreateTime = DateTime.Now
            }
        };
            _fileManager.SerializeNotesToFile(_testFilePath, notes);

            // Act
            var deserializedNotes = _fileManager.DeserializeNotesFromFile(_testFilePath);

            // Assert
            ClassicAssert.IsNotNull(deserializedNotes, "Deserialized list is null.");
            ClassicAssert.AreEqual(1, deserializedNotes.Count, "Deserialized list count is incorrect.");
            ClassicAssert.AreEqual("Test Note", deserializedNotes[0].Name, "Note name is incorrect.");
        }

        [Test]
        public void DeserializeNotesFromFile_NonexistentFile_ShouldReturnEmptyList()
        {
            // Arrange
            string nonexistentFilePath = Path.Combine(Path.GetTempPath(), "nonexistent.json");

            // Act
            var notes = _fileManager.DeserializeNotesFromFile(nonexistentFilePath);

            // Assert
            ClassicAssert.IsNotNull(notes, "Returned list is null.");
            ClassicAssert.IsEmpty(notes, "Returned list is not empty.");
        }

        [Test]
        public void DeserializeNotesFromFile_EmptyFile_ShouldReturnEmptyList()
        {
            // Arrange
            File.WriteAllText(_testFilePath, string.Empty);

            // Act
            var notes = _fileManager.DeserializeNotesFromFile(_testFilePath);

            // Assert
            ClassicAssert.IsNotNull(notes, "Returned list is null.");
            ClassicAssert.IsEmpty(notes, "Returned list is not empty.");
        }
    }
}
