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

namespace Visiner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool isInputCorrect(RichTextBox input, RichTextBox key, RichTextBox output)
        {
            if (String.IsNullOrEmpty(richInput.Text) || String.IsNullOrEmpty(richKey.Text))
            {
                output.Text = "Input or key is empty";
                return false;
            }
            for (int i = 0; i < key.Text.Length; i++)
            {
                if (!char.IsLetter(key.Text[i]))
                {
                    output.Text = "Your key contains nonletter symbols";
                    return false;
                }
            }
            return true;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            richOutput.Clear();
            richInput.Focus();

            if (!isInputCorrect(richInput, richKey, richOutput)) return;

            Visiner visiner = new Visiner();

            richOutput.Text = visiner.Cipher(richInput.Text, richKey.Text, radioButtonCypher.Checked, int.Parse(comboBox1.Text.Split(' ')[1])); //tetya if more than one option

        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Load Text File";
            theDialog.Filter = "TXT files|*.txt";
            theDialog.InitialDirectory = @"//";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = theDialog.OpenFile()) != null)
                    {
                        richInput.Text = null;
                        using (myStream)
                        {
                            // Insert code to read the stream here.
                            string filename = theDialog.FileName;

                            string[] filelines = File.ReadAllLines(filename);

                            for (int i = 0; i < filelines.Length; i++)
                            {
                                richInput.Text += filelines[i];
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //Stream myStream = null;
            SaveFileDialog theDialog = new SaveFileDialog();
            theDialog.Title = "Save Text File";
            theDialog.Filter = "TXT files|*.txt";
            theDialog.InitialDirectory = @"//";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(theDialog.FileName, richOutput.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }
    }
}