using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void readFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string userFileName = openFileDialog1.FileName;
            string readFile = File.ReadAllText(userFileName);
            userFileTextBox.Text += readFile.ToLower();
            StreamReader reader = new StreamReader(userFileName);
            string[] words = reader.ReadToEnd().Split();
            string longestWord = "";
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > longestWord.Length)
                {
                    longestWord = words[i];
                }
            }
           
            userFileTextBox.Text += "\n" + "\n" +  "Longest Word: " + longestWord;
            userFileTextBox.Text += "\n" + "First Word: " + words[0].ToLower() + "\n";
            userFileTextBox.Text += "Last Word: " + words[words.Length - 1] + "\n";
           
        }
    }
}

