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

namespace ProgrammingProject3
{
    public partial class ProgrammingProject3 : Form
    {
        string[] words;
        string first;
        string last;
        string longest;
        string mostVowels;
        int vowelCount;

        public ProgrammingProject3()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //OpenFileDialog dlg = new OpenFileDialog();

            //if (dlg.ShowDialog() == DialogResult.OK)
            //{
            //    StreamReader reader = new StreamReader(dlg.FileName, Encoding.Default);
            //    textBox1.Text = reader.ReadToEnd();
            //    //reader.Close();
            //}
            //else
            //{
            //    MessageBox.Show("operation canceled.");
            //}
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                List<string> wordsInLine = new List<string>();
                StreamReader inputFile;
                inputFile = File.OpenText(dlg.FileName);
                while (!inputFile.EndOfStream)
                {
                    // Convert contents to Lower case
                    foreach (string word in inputFile.ReadLine().ToLower().Split(' '))
                    {
                        wordsInLine.Add(word);
                    }
                }
                inputFile.Close();
                words = wordsInLine.ToArray();
                foreach (string word in words)
                {
                    alphabeticalFirstLast(word);
                    longestWord(word);
                    vowelCounter(word);
                }

                // display processed file in textview
                string[] lines =
                {
                    "First word alphabetically:  " + first,
                    "Last word alphabetically:   " + last,
                    "Longest Word:               " + longest,
                    "Word with the most vowels:  " + mostVowels
                };
                txt_results.Text = string.Join("\r\n", lines);
                if (saveDlg.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllLines(saveDlg.FileName, lines);
                }
            }
            else
            {
                MessageBox.Show("You did not select a file.");
            }


        }


        // method with loop to find Alphabetically first and last word
        private void alphabeticalFirstLast(string word)
        {
            if (first == null)
            {
                last = word;
                first = word;
                return;
            }

            // check word does not equal an empty space
            if (word.CompareTo(first) == -1 && word.Length != 0) 
            {
                first = word;
            }
            if (word.CompareTo(last) == 1)
            {
                last = word;
            }
        }

        // method with loop to find longet word
        private void longestWord(string word)
        {
            if (longest == null)
            {
                longest = word;
                return;
            }
            if (longest.Length < word.Length)
            {
                longest = word;
            }
        }

        // method with loop to find word with most vowels
        private void vowelCounter(string word)
        {
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                // if statement to find words using vowels
                if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u')
                {
                    //add to vowel counter
                    count++;
                }
            }
             // if statment to find word with most vowels
            if (count > vowelCount)
            {
                vowelCount = count;
                mostVowels = word;
            }
        }


        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            

            MessageBox.Show("Your file is saved.");

            this.Close();

        }

       
    }
}
