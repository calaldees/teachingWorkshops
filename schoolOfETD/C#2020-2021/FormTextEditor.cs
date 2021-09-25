using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SimpleTextEditor
{
    public partial class Form1 : Form
    {
        string FileDisplayed; 

        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxTextFile.Text = "";
            FileDisplayed = "";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show the open file dialog and let the user select a file
            // If the file does not have a .txt extension then inform the
            // user that they would require to select a valid text file
            if (openFileDialogText.ShowDialog() == System.Windows.Forms.DialogResult.OK && openFileDialogText.FileName.Contains(".txt")) 
            {
                FileDisplayed = openFileDialogText.FileName;
                            
                string open = File.ReadAllText(openFileDialogText.FileName);  
                richTextBoxTextFile.Text = open; 
            }
            else 
            {
                MessageBox.Show("The file selected is not a valid text file");
            }
        }

        private void openToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            // Show the open file dialog and let the user select a file
            // If the file does not have a .txt extension then inform the
            // user that they would require to select a valid text file
            if (openFileDialogText.ShowDialog() == System.Windows.Forms.DialogResult.OK && openFileDialogText.FileName.Contains(".txt"))
            {
                FileDisplayed = openFileDialogText.FileName;
                List<string> Lines = new List<string>();
                try
                {
                    using (StreamReader sr = new StreamReader(FileDisplayed))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            richTextBoxTextFile.Text += line + Environment.NewLine;
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Let the user know what went wrong
                    MessageBox.Show(ex.Message, "The file could not be read");
                }
            }
            else
            {
                MessageBox.Show("The file selected is not a valid text file");
            }
        }


        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Check first if the user has opened a file first
            // if not then call the saveAs event
            if (FileDisplayed == "")
            {
                saveAsToolStripMenuItem_Click(sender, e);
            }
            else
            {
                File.WriteAllText(FileDisplayed, richTextBoxTextFile.Text);
            }
        }

        private void saveToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            // Check first if the user has opened a file first
            // if not then call the saveAs event
            if (FileDisplayed == "")
            {
                saveAsToolStripMenuItem_Click(sender, e);
            }
            else
            {
                string[] Lines = richTextBoxTextFile.Text.Split(Environment.NewLine.ToCharArray());
                try
                {
                    using (StreamWriter sw = new StreamWriter(FileDisplayed))
                    {
                        foreach (string s in Lines)
                        {
                            sw.WriteLine(s);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Writing to File");
                }
            }
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show the save file dialog and let the user select or enter a file
            // If the file does not have a .txt extension then add the 
            // appropriate .txt extension
            if (saveAsFileDialogText.ShowDialog() == System.Windows.Forms.DialogResult.OK)  
            {
                string fileName = saveAsFileDialogText.FileName;
                if (!saveAsFileDialogText.FileName.EndsWith(".txt"))
                {
                    fileName = saveAsFileDialogText.FileName + ".txt";
                }
                File.WriteAllText(fileName, richTextBoxTextFile.Text);                
            }
        }
    }
}
