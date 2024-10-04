
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.noteNameTextBox = new System.Windows.Forms.TextBox();
            this.enterNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NoteTextBox
            // 
            this.NoteTextBox.Location = new System.Drawing.Point(12, 65);
            this.NoteTextBox.Multiline = true;
            this.NoteTextBox.Name = "NoteTextBox";
            this.NoteTextBox.Size = new System.Drawing.Size(278, 146);
            this.NoteTextBox.TabIndex = 0;
            this.NoteTextBox.TextChanged += new System.EventHandler(this.NoteTextBox_TextChanged);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(35, 217);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(85, 29);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(158, 217);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(85, 29);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // noteNameTextBox
            // 
            this.noteNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.noteNameTextBox.Location = new System.Drawing.Point(130, 26);
            this.noteNameTextBox.Name = "noteNameTextBox";
            this.noteNameTextBox.Size = new System.Drawing.Size(100, 15);
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
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 301);
            this.Controls.Add(this.enterNameTextBox);
            this.Controls.Add(this.noteNameTextBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.NoteTextBox);
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditForm";
            this.Load += new System.EventHandler(this.InnerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NoteTextBox;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox noteNameTextBox;
        private System.Windows.Forms.TextBox enterNameTextBox;
    }
}