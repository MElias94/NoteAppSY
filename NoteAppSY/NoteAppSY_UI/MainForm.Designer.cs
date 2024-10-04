﻿
namespace NoteAppSY_UI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.notesCategory = new System.Windows.Forms.ComboBox();
            this.notesCategoryText = new System.Windows.Forms.TextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.addNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.notesListBox = new System.Windows.Forms.ListBox();
            this.addPictureBox = new System.Windows.Forms.PictureBox();
            this.editPictureBox = new System.Windows.Forms.PictureBox();
            this.removePictureBox = new System.Windows.Forms.PictureBox();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.noteListBoxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.removePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteListBoxBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // notesCategory
            // 
            this.notesCategory.FormattingEnabled = true;
            this.notesCategory.Location = new System.Drawing.Point(115, 41);
            this.notesCategory.Name = "notesCategory";
            this.notesCategory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.notesCategory.Size = new System.Drawing.Size(142, 24);
            this.notesCategory.TabIndex = 1;
            this.notesCategory.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // notesCategoryText
            // 
            this.notesCategoryText.BackColor = System.Drawing.SystemColors.Control;
            this.notesCategoryText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.notesCategoryText.Location = new System.Drawing.Point(9, 44);
            this.notesCategoryText.Multiline = true;
            this.notesCategoryText.Name = "notesCategoryText";
            this.notesCategoryText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.notesCategoryText.Size = new System.Drawing.Size(100, 24);
            this.notesCategoryText.TabIndex = 2;
            this.notesCategoryText.Text = "Show Category";
            this.notesCategoryText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(46, 24);
            this.toolStripButton1.Text = "File";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNoteToolStripMenuItem,
            this.editNoteToolStripMenuItem,
            this.removeNoteToolStripMenuItem});
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(49, 24);
            this.toolStripButton2.Text = "Edit";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // addNoteToolStripMenuItem
            // 
            this.addNoteToolStripMenuItem.Name = "addNoteToolStripMenuItem";
            this.addNoteToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.addNoteToolStripMenuItem.Text = "Add Note";
            this.addNoteToolStripMenuItem.Click += new System.EventHandler(this.addNoteToolStripMenuItem_Click);
            // 
            // editNoteToolStripMenuItem
            // 
            this.editNoteToolStripMenuItem.Name = "editNoteToolStripMenuItem";
            this.editNoteToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.editNoteToolStripMenuItem.Text = "Edit Note";
            this.editNoteToolStripMenuItem.Click += new System.EventHandler(this.editNoteToolStripMenuItem_Click);
            // 
            // removeNoteToolStripMenuItem
            // 
            this.removeNoteToolStripMenuItem.Name = "removeNoteToolStripMenuItem";
            this.removeNoteToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.removeNoteToolStripMenuItem.Text = "Remove Note";
            this.removeNoteToolStripMenuItem.Click += new System.EventHandler(this.removeNoteToolStripMenuItem_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(55, 24);
            this.toolStripButton3.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // notesListBox
            // 
            this.notesListBox.FormattingEnabled = true;
            this.notesListBox.ItemHeight = 16;
            this.notesListBox.Location = new System.Drawing.Point(12, 88);
            this.notesListBox.Name = "notesListBox";
            this.notesListBox.Size = new System.Drawing.Size(245, 308);
            this.notesListBox.TabIndex = 3;
            this.notesListBox.SelectedIndexChanged += new System.EventHandler(this.notesListBox_SelectedIndexChanged);
            // 
            // addPictureBox
            // 
            this.addPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("addPictureBox.Image")));
            this.addPictureBox.Location = new System.Drawing.Point(23, 408);
            this.addPictureBox.Name = "addPictureBox";
            this.addPictureBox.Size = new System.Drawing.Size(30, 30);
            this.addPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.addPictureBox.TabIndex = 4;
            this.addPictureBox.TabStop = false;
            this.addPictureBox.Click += new System.EventHandler(this.addPictureBox_Click);
            // 
            // editPictureBox
            // 
            this.editPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("editPictureBox.Image")));
            this.editPictureBox.Location = new System.Drawing.Point(89, 408);
            this.editPictureBox.Name = "editPictureBox";
            this.editPictureBox.Size = new System.Drawing.Size(30, 30);
            this.editPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.editPictureBox.TabIndex = 4;
            this.editPictureBox.TabStop = false;
            this.editPictureBox.Click += new System.EventHandler(this.editPictureBox_Click);
            // 
            // removePictureBox
            // 
            this.removePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("removePictureBox.Image")));
            this.removePictureBox.Location = new System.Drawing.Point(152, 408);
            this.removePictureBox.Name = "removePictureBox";
            this.removePictureBox.Size = new System.Drawing.Size(30, 30);
            this.removePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.removePictureBox.TabIndex = 4;
            this.removePictureBox.TabStop = false;
            this.removePictureBox.Click += new System.EventHandler(this.removePictureBox_Click);
            // 
            // noteTextBox
            // 
            this.noteTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.noteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.noteTextBox.Location = new System.Drawing.Point(295, 88);
            this.noteTextBox.Multiline = true;
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(461, 308);
            this.noteTextBox.TabIndex = 5;
            this.noteTextBox.TextChanged += new System.EventHandler(this.noteTextBox_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.noteTextBox);
            this.Controls.Add(this.removePictureBox);
            this.Controls.Add(this.editPictureBox);
            this.Controls.Add(this.addPictureBox);
            this.Controls.Add(this.notesListBox);
            this.Controls.Add(this.notesCategoryText);
            this.Controls.Add(this.notesCategory);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NoteAppSY";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.removePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteListBoxBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox notesCategory;
        private System.Windows.Forms.TextBox notesCategoryText;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem addNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton3;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ListBox notesListBox;
        private System.Windows.Forms.PictureBox addPictureBox;
        private System.Windows.Forms.PictureBox editPictureBox;
        private System.Windows.Forms.PictureBox removePictureBox;
        private System.Windows.Forms.TextBox noteTextBox;
        private System.Windows.Forms.BindingSource noteListBoxBindingSource;
    }
}

