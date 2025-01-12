using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleNotepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.Title = "Open a Text File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Read the contents of the file into the TextBox
                        string filePath = openFileDialog.FileName;
                        textBox1.Text = File.ReadAllText(filePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error opening file: " + ex.Message);
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                saveFileDialog.DefaultExt = "txt";
                saveFileDialog.AddExtension = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, textBox1.Text); // Assuming you use a RichTextBox named richTextBox1
                }
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
          
            float newSize = textBox1.Font.Size + 2.0f;
            textBox1.Font = new Font(textBox1.Font.FontFamily, newSize, textBox1.Font.Style);
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Assuming the text area is named textBox1 or richTextBox1
            // Check if any text is selected before cutting
            if (textBox1.SelectedText != "")
            {
                textBox1.Cut();
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Assuming the text area is named textBox1 or richTextBox1
            if (Clipboard.ContainsText())
            {
                textBox1.Paste();
            }
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Assuming the text area is named textBox1 or richTextBox1
            textBox1.SelectAll();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Mohammad Amin Miri",
                            "About Me . ",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

    }

}    