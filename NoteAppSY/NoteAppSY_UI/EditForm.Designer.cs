
namespace NoteAppSY_UI
{
    partial class EditForm
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
            this.NoteTextBox = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.noteNameTextBox = new System.Windows.Forms.TextBox();
            this.enterNameTextBox = new System.Windows.Forms.TextBox();
            this.selectCategoryTextBox = new System.Windows.Forms.TextBox();
            this.editNotesCategory = new System.Windows.Forms.ComboBox();
            this.createSelectedTextBox = new System.Windows.Forms.TextBox();
            this.createTimeTextBox = new System.Windows.Forms.TextBox();
            this.lastUpdateSelectedTextBox = new System.Windows.Forms.TextBox();
            this.updateTimeTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NoteTextBox
            // 
            this.NoteTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteTextBox.Location = new System.Drawing.Point(12, 134);
            this.NoteTextBox.Multiline = true;
            this.NoteTextBox.Name = "NoteTextBox";
            this.NoteTextBox.Size = new System.Drawing.Size(571, 272);
            this.NoteTextBox.TabIndex = 0;
            this.NoteTextBox.TextChanged += new System.EventHandler(this.NoteTextBox_TextChanged);
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkButton.Location = new System.Drawing.Point(328, 412);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(85, 29);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "Save";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(451, 412);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(85, 29);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // noteNameTextBox
            // 
            this.noteNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.noteNameTextBox.Location = new System.Drawing.Point(118, 26);
            this.noteNameTextBox.Multiline = true;
            this.noteNameTextBox.Name = "noteNameTextBox";
            this.noteNameTextBox.Size = new System.Drawing.Size(465, 22);
            this.noteNameTextBox.TabIndex = 2;
            this.noteNameTextBox.TextChanged += new System.EventHandler(this.noteNameTextBox_TextChanged);
            // 
            // enterNameTextBox
            // 
            this.enterNameTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.enterNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.enterNameTextBox.Location = new System.Drawing.Point(12, 26);
            this.enterNameTextBox.Name = "enterNameTextBox";
            this.enterNameTextBox.Size = new System.Drawing.Size(100, 15);
            this.enterNameTextBox.TabIndex = 2;
            this.enterNameTextBox.Text = "Enter note name";
            this.enterNameTextBox.TextChanged += new System.EventHandler(this.enterNameTextBox_TextChanged);
            // 
            // selectCategoryTextBox
            // 
            this.selectCategoryTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.selectCategoryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.selectCategoryTextBox.Location = new System.Drawing.Point(12, 58);
            this.selectCategoryTextBox.Multiline = true;
            this.selectCategoryTextBox.Name = "selectCategoryTextBox";
            this.selectCategoryTextBox.Size = new System.Drawing.Size(148, 22);
            this.selectCategoryTextBox.TabIndex = 3;
            this.selectCategoryTextBox.Text = "Choose category";
            this.selectCategoryTextBox.TextChanged += new System.EventHandler(this.selectCategoryTextBox_TextChanged);
            // 
            // editNotesCategory
            // 
            this.editNotesCategory.FormattingEnabled = true;
            this.editNotesCategory.Location = new System.Drawing.Point(183, 55);
            this.editNotesCategory.Name = "editNotesCategory";
            this.editNotesCategory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.editNotesCategory.Size = new System.Drawing.Size(107, 24);
            this.editNotesCategory.TabIndex = 4;
            this.editNotesCategory.SelectedIndexChanged += new System.EventHandler(this.editNotesCategory_SelectedIndexChanged);
            // 
            // createSelectedTextBox
            // 
            this.createSelectedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.createSelectedTextBox.Enabled = false;
            this.createSelectedTextBox.Location = new System.Drawing.Point(76, 104);
            this.createSelectedTextBox.Name = "createSelectedTextBox";
            this.createSelectedTextBox.Size = new System.Drawing.Size(94, 22);
            this.createSelectedTextBox.TabIndex = 19;
            this.createSelectedTextBox.TextChanged += new System.EventHandler(this.createSelectedTextBox_TextChanged);
            // 
            // createTimeTextBox
            // 
            this.createTimeTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.createTimeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.createTimeTextBox.Location = new System.Drawing.Point(12, 104);
            this.createTimeTextBox.Multiline = true;
            this.createTimeTextBox.Name = "createTimeTextBox";
            this.createTimeTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.createTimeTextBox.Size = new System.Drawing.Size(79, 24);
            this.createTimeTextBox.TabIndex = 18;
            this.createTimeTextBox.Text = "Created";
            this.createTimeTextBox.TextChanged += new System.EventHandler(this.createTimeTextBox_TextChanged);
            // 
            // lastUpdateSelectedTextBox
            // 
            this.lastUpdateSelectedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastUpdateSelectedTextBox.Enabled = false;
            this.lastUpdateSelectedTextBox.Location = new System.Drawing.Point(255, 104);
            this.lastUpdateSelectedTextBox.Name = "lastUpdateSelectedTextBox";
            this.lastUpdateSelectedTextBox.Size = new System.Drawing.Size(94, 22);
            this.lastUpdateSelectedTextBox.TabIndex = 17;
            this.lastUpdateSelectedTextBox.TextChanged += new System.EventHandler(this.lastUpdateSelectedTextBox_TextChanged);
            // 
            // updateTimeTextBox
            // 
            this.updateTimeTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.updateTimeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.updateTimeTextBox.Location = new System.Drawing.Point(183, 104);
            this.updateTimeTextBox.Multiline = true;
            this.updateTimeTextBox.Name = "updateTimeTextBox";
            this.updateTimeTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.updateTimeTextBox.Size = new System.Drawing.Size(79, 24);
            this.updateTimeTextBox.TabIndex = 16;
            this.updateTimeTextBox.Text = "Modified";
            this.updateTimeTextBox.TextChanged += new System.EventHandler(this.updateTimeTextBox_TextChanged);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 457);
            this.Controls.Add(this.createSelectedTextBox);
            this.Controls.Add(this.createTimeTextBox);
            this.Controls.Add(this.lastUpdateSelectedTextBox);
            this.Controls.Add(this.updateTimeTextBox);
            this.Controls.Add(this.editNotesCategory);
            this.Controls.Add(this.selectCategoryTextBox);
            this.Controls.Add(this.enterNameTextBox);
            this.Controls.Add(this.noteNameTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.NoteTextBox);
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditForm_FormClosing);
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NoteTextBox;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox noteNameTextBox;
        private System.Windows.Forms.TextBox enterNameTextBox;
        private System.Windows.Forms.TextBox selectCategoryTextBox;
        private System.Windows.Forms.ComboBox editNotesCategory;
        private System.Windows.Forms.TextBox createSelectedTextBox;
        private System.Windows.Forms.TextBox createTimeTextBox;
        private System.Windows.Forms.TextBox lastUpdateSelectedTextBox;
        private System.Windows.Forms.TextBox updateTimeTextBox;
    }
}