
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
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.selectedCategoryNameTextBox = new System.Windows.Forms.TextBox();
            this.selectedCategoryTextBox = new System.Windows.Forms.TextBox();
            this.updateTimeTextBox = new System.Windows.Forms.TextBox();
            this.lastUpdateSelectedTextBox = new System.Windows.Forms.TextBox();
            this.selectedTitleNameTextBox = new System.Windows.Forms.TextBox();
            this.selectedTitleTextBox = new System.Windows.Forms.TextBox();
            this.statusGroupBox = new System.Windows.Forms.Panel();
            this.removePictureBox = new System.Windows.Forms.PictureBox();
            this.addPictureBox = new System.Windows.Forms.PictureBox();
            this.editPictureBox = new System.Windows.Forms.PictureBox();
            this.createTimeTextBox = new System.Windows.Forms.TextBox();
            this.createSelectedTextBox = new System.Windows.Forms.TextBox();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.statusGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.removePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // notesCategory
            // 
            this.notesCategory.FormattingEnabled = true;
            this.notesCategory.Location = new System.Drawing.Point(115, 41);
            this.notesCategory.Name = "notesCategory";
            this.notesCategory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.notesCategory.Size = new System.Drawing.Size(155, 24);
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
            this.saveToolStripMenuItem,
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
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
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
            this.notesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.notesListBox.FormattingEnabled = true;
            this.notesListBox.ItemHeight = 16;
            this.notesListBox.Location = new System.Drawing.Point(12, 88);
            this.notesListBox.Name = "notesListBox";
            this.notesListBox.Size = new System.Drawing.Size(258, 308);
            this.notesListBox.TabIndex = 3;
            this.notesListBox.SelectedIndexChanged += new System.EventHandler(this.notesListBox_SelectedIndexChanged);
            // 
            // noteTextBox
            // 
            this.noteTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noteTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.noteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.noteTextBox.Location = new System.Drawing.Point(295, 128);
            this.noteTextBox.Multiline = true;
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(493, 304);
            this.noteTextBox.TabIndex = 5;
            this.noteTextBox.TextChanged += new System.EventHandler(this.noteTextBox_TextChanged);
            // 
            // selectedCategoryNameTextBox
            // 
            this.selectedCategoryNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.selectedCategoryNameTextBox.Location = new System.Drawing.Point(359, 67);
            this.selectedCategoryNameTextBox.Name = "selectedCategoryNameTextBox";
            this.selectedCategoryNameTextBox.Size = new System.Drawing.Size(94, 15);
            this.selectedCategoryNameTextBox.TabIndex = 6;
            this.selectedCategoryNameTextBox.TextChanged += new System.EventHandler(this.selectedCategoryNameTextBox_TextChanged);
            // 
            // selectedCategoryTextBox
            // 
            this.selectedCategoryTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.selectedCategoryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.selectedCategoryTextBox.Location = new System.Drawing.Point(295, 67);
            this.selectedCategoryTextBox.Multiline = true;
            this.selectedCategoryTextBox.Name = "selectedCategoryTextBox";
            this.selectedCategoryTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.selectedCategoryTextBox.Size = new System.Drawing.Size(58, 24);
            this.selectedCategoryTextBox.TabIndex = 7;
            this.selectedCategoryTextBox.Text = "Category";
            this.selectedCategoryTextBox.TextChanged += new System.EventHandler(this.selectedCategoryTextBox_TextChanged);
            // 
            // updateTimeTextBox
            // 
            this.updateTimeTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.updateTimeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.updateTimeTextBox.Location = new System.Drawing.Point(470, 98);
            this.updateTimeTextBox.Multiline = true;
            this.updateTimeTextBox.Name = "updateTimeTextBox";
            this.updateTimeTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.updateTimeTextBox.Size = new System.Drawing.Size(79, 24);
            this.updateTimeTextBox.TabIndex = 8;
            this.updateTimeTextBox.Text = "Modified";
            this.updateTimeTextBox.TextChanged += new System.EventHandler(this.updateTimeTextBox_TextChanged);
            // 
            // lastUpdateSelectedTextBox
            // 
            this.lastUpdateSelectedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastUpdateSelectedTextBox.Location = new System.Drawing.Point(538, 98);
            this.lastUpdateSelectedTextBox.Name = "lastUpdateSelectedTextBox";
            this.lastUpdateSelectedTextBox.Size = new System.Drawing.Size(94, 15);
            this.lastUpdateSelectedTextBox.TabIndex = 9;
            this.lastUpdateSelectedTextBox.TextChanged += new System.EventHandler(this.lastUpdateSelectedTextBox_TextChanged);
            // 
            // selectedTitleNameTextBox
            // 
            this.selectedTitleNameTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.selectedTitleNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.selectedTitleNameTextBox.Location = new System.Drawing.Point(295, 28);
            this.selectedTitleNameTextBox.Multiline = true;
            this.selectedTitleNameTextBox.Name = "selectedTitleNameTextBox";
            this.selectedTitleNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.selectedTitleNameTextBox.Size = new System.Drawing.Size(58, 24);
            this.selectedTitleNameTextBox.TabIndex = 10;
            this.selectedTitleNameTextBox.Text = "Title";
            this.selectedTitleNameTextBox.TextChanged += new System.EventHandler(this.selectedTitleNameTextBox_TextChanged);
            // 
            // selectedTitleTextBox
            // 
            this.selectedTitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.selectedTitleTextBox.Location = new System.Drawing.Point(359, 28);
            this.selectedTitleTextBox.Multiline = true;
            this.selectedTitleTextBox.Name = "selectedTitleTextBox";
            this.selectedTitleTextBox.Size = new System.Drawing.Size(292, 22);
            this.selectedTitleTextBox.TabIndex = 11;
            this.selectedTitleTextBox.TextChanged += new System.EventHandler(this.selectedTitleTextBox_TextChanged);
            // 
            // statusGroupBox
            // 
            this.statusGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.statusGroupBox.Controls.Add(this.editPictureBox);
            this.statusGroupBox.Controls.Add(this.addPictureBox);
            this.statusGroupBox.Controls.Add(this.removePictureBox);
            this.statusGroupBox.Location = new System.Drawing.Point(12, 402);
            this.statusGroupBox.Name = "statusGroupBox";
            this.statusGroupBox.Size = new System.Drawing.Size(245, 30);
            this.statusGroupBox.TabIndex = 13;
            this.statusGroupBox.Paint += new System.Windows.Forms.PaintEventHandler(this.statusGroupBox_Paint);
            // 
            // removePictureBox
            // 
            this.removePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("removePictureBox.Image")));
            this.removePictureBox.Location = new System.Drawing.Point(165, 0);
            this.removePictureBox.Name = "removePictureBox";
            this.removePictureBox.Size = new System.Drawing.Size(30, 30);
            this.removePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.removePictureBox.TabIndex = 4;
            this.removePictureBox.TabStop = false;
            this.removePictureBox.Click += new System.EventHandler(this.removePictureBox_Click);
            // 
            // addPictureBox
            // 
            this.addPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("addPictureBox.Image")));
            this.addPictureBox.Location = new System.Drawing.Point(38, 0);
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
            this.editPictureBox.Location = new System.Drawing.Point(103, 0);
            this.editPictureBox.Name = "editPictureBox";
            this.editPictureBox.Size = new System.Drawing.Size(30, 30);
            this.editPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.editPictureBox.TabIndex = 4;
            this.editPictureBox.TabStop = false;
            this.editPictureBox.Click += new System.EventHandler(this.editPictureBox_Click);
            // 
            // createTimeTextBox
            // 
            this.createTimeTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.createTimeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.createTimeTextBox.Location = new System.Drawing.Point(295, 98);
            this.createTimeTextBox.Multiline = true;
            this.createTimeTextBox.Name = "createTimeTextBox";
            this.createTimeTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.createTimeTextBox.Size = new System.Drawing.Size(79, 24);
            this.createTimeTextBox.TabIndex = 14;
            this.createTimeTextBox.Text = "Created";
            this.createTimeTextBox.TextChanged += new System.EventHandler(this.createTimeTextBox_TextChanged);
            // 
            // createSelectedTextBox
            // 
            this.createSelectedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.createSelectedTextBox.Location = new System.Drawing.Point(359, 98);
            this.createSelectedTextBox.Name = "createSelectedTextBox";
            this.createSelectedTextBox.Size = new System.Drawing.Size(94, 15);
            this.createSelectedTextBox.TabIndex = 15;
            this.createSelectedTextBox.TextChanged += new System.EventHandler(this.createSelectedTextBox_TextChanged);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createSelectedTextBox);
            this.Controls.Add(this.createTimeTextBox);
            this.Controls.Add(this.statusGroupBox);
            this.Controls.Add(this.selectedTitleTextBox);
            this.Controls.Add(this.selectedTitleNameTextBox);
            this.Controls.Add(this.lastUpdateSelectedTextBox);
            this.Controls.Add(this.updateTimeTextBox);
            this.Controls.Add(this.selectedCategoryTextBox);
            this.Controls.Add(this.selectedCategoryNameTextBox);
            this.Controls.Add(this.noteTextBox);
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
            this.statusGroupBox.ResumeLayout(false);
            this.statusGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.removePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editPictureBox)).EndInit();
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
        private System.Windows.Forms.TextBox noteTextBox;
        private System.Windows.Forms.TextBox selectedCategoryNameTextBox;
        private System.Windows.Forms.TextBox selectedCategoryTextBox;
        private System.Windows.Forms.TextBox updateTimeTextBox;
        private System.Windows.Forms.TextBox lastUpdateSelectedTextBox;
        private System.Windows.Forms.TextBox selectedTitleNameTextBox;
        private System.Windows.Forms.TextBox selectedTitleTextBox;
        private System.Windows.Forms.Panel statusGroupBox;
        private System.Windows.Forms.PictureBox editPictureBox;
        private System.Windows.Forms.PictureBox addPictureBox;
        private System.Windows.Forms.PictureBox removePictureBox;
        private System.Windows.Forms.TextBox createTimeTextBox;
        private System.Windows.Forms.TextBox createSelectedTextBox;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}

