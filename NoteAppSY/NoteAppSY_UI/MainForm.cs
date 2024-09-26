using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteAppSY_UI
{
    public partial class MainForm : Form
    {
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
            notesCategory.Items.Add(Category.All);
            notesCategory.Items.Add(Category.Home);
            notesCategory.Items.Add(Category.Work);
            notesCategory.Items.Add(Category.Health);
            notesCategory.Items.Add(Category.People);
            notesCategory.Items.Add(Category.Docs);
            notesCategory.Items.Add(Category.Finance);
            notesCategory.Items.Add(Category.Other);
            notesCategory.SelectedIndex = 0;
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

        }

        private void editNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void removeNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
    }
}
