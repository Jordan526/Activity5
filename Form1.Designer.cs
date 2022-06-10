namespace Activity5
{
    partial class Form1
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
            this.userFileTextBox = new System.Windows.Forms.RichTextBox();
            this.readFileButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // userFileTextBox
            // 
            this.userFileTextBox.Location = new System.Drawing.Point(53, 12);
            this.userFileTextBox.Name = "userFileTextBox";
            this.userFileTextBox.Size = new System.Drawing.Size(517, 210);
            this.userFileTextBox.TabIndex = 0;
            this.userFileTextBox.Text = "";
            // 
            // readFileButton
            // 
            this.readFileButton.Location = new System.Drawing.Point(241, 228);
            this.readFileButton.Name = "readFileButton";
            this.readFileButton.Size = new System.Drawing.Size(144, 38);
            this.readFileButton.TabIndex = 1;
            this.readFileButton.Text = "Select File For Input";
            this.readFileButton.UseVisualStyleBackColor = true;
            this.readFileButton.Click += new System.EventHandler(this.readFileButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 357);
            this.Controls.Add(this.readFileButton);
            this.Controls.Add(this.userFileTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox userFileTextBox;
        private System.Windows.Forms.Button readFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

