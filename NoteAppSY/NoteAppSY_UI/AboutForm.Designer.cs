
namespace NoteAppSY_UI
{
    partial class AboutForm
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
            this.aboutMainTextBox = new System.Windows.Forms.TextBox();
            this.aboutTitleTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // aboutMainTextBox
            // 
            this.aboutMainTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.aboutMainTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aboutMainTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aboutMainTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.aboutMainTextBox.Location = new System.Drawing.Point(12, 66);
            this.aboutMainTextBox.Multiline = true;
            this.aboutMainTextBox.Name = "aboutMainTextBox";
            this.aboutMainTextBox.ReadOnly = true;
            this.aboutMainTextBox.Size = new System.Drawing.Size(404, 267);
            this.aboutMainTextBox.TabIndex = 0;
            this.aboutMainTextBox.Text = "Учебный проект для университета\r\n\r\nv1.0.0\r\n\r\nAuthor: MElias94\r\n\r\nGitHub: https://" +
    "github.com/MElias94/NoteAppSY\r\n\r\n\r\n\r\n2024";
            this.aboutMainTextBox.TextChanged += new System.EventHandler(this.aboutMainTextBox_TextChanged);
            // 
            // aboutTitleTextBox
            // 
            this.aboutTitleTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.aboutTitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aboutTitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.aboutTitleTextBox.Location = new System.Drawing.Point(12, 12);
            this.aboutTitleTextBox.Name = "aboutTitleTextBox";
            this.aboutTitleTextBox.ReadOnly = true;
            this.aboutTitleTextBox.Size = new System.Drawing.Size(164, 30);
            this.aboutTitleTextBox.TabIndex = 1;
            this.aboutTitleTextBox.Text = "NoteApp_SY";
            this.aboutTitleTextBox.TextChanged += new System.EventHandler(this.aboutTitleTextBox_TextChanged);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 345);
            this.Controls.Add(this.aboutTitleTextBox);
            this.Controls.Add(this.aboutMainTextBox);
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AboutForm";
            this.Load += new System.EventHandler(this.AboutForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox aboutMainTextBox;
        private System.Windows.Forms.TextBox aboutTitleTextBox;
    }
}