using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace Lab_8_V07
{
    public partial class Main : Form
    {
        
        private Color currentBackColor = Color.White;
        private Font currentFont = new Font("Segoe UI", 10);
        

        
        public Main()
        {
            InitializeComponent();
            EnableMenuItems(false);
        }
       


        #region Event Handlers
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton radioButton && radioButton.Checked)
            {
                switch (radioButton.Text)
                {
                    case "Microsoft Sans Serif":
                    case "Impact":
                    case "Courier New":
                        currentFont = new Font(radioButton.Text, 12);
                        break;
                    case "Red":
                        currentBackColor = Color.Red;
                        break;
                    case "Green":
                        currentBackColor = Color.Green;
                        break;
                    case "Blue":
                        currentBackColor = Color.Blue;
                        break;
                    case "The longest words. sorted":
                        break;
                    case "Change symbol":
                        break;
                    case "Delete symbol":
                        break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox3.Checked && radioButton1.Checked)
            {
                myvariant();
            }
            else if (checkBox3.Checked && radioButton2.Checked)
            {
                ReplaceCharacter();
            }
            else if (checkBox3.Checked && radioButton3.Checked)
            {
                RemoveCharacter();
            }
            else if (!checkBox3.Checked)
            {
                richTextBox2.Text = richTextBox1.Text;
                richTextBox2.Font = currentFont;
                richTextBox2.BackColor = currentBackColor;
            }
        }

        private void FontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetRadioButtonTexts(new[] { "Microsoft Sans Serif", "Impact", "Courier New" }, 12);
        }

        private void BackColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetRadioButtonTexts(new[] { "Red", "Green", "Blue" }, 10);
        }

        private void myVariantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myvariant();
        }

        private void exiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ToggleMenuItem(FontToolStripMenuItem, checkBox1.Checked);
            if (checkBox1.Checked) SetRadioButtonTexts(new[] { "Microsoft Sans Serif", "Impact", "Courier New" }, 12);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            ToggleMenuItem(BackColorToolStripMenuItem, checkBox2.Checked);
            if (checkBox2.Checked) SetRadioButtonTexts(new[] { "Red", "Green", "Blue" }, 10);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            ToggleMenuItem(myVariantToolStripMenuItem, checkBox3.Checked);
            if (checkBox3.Checked) SetRadioButtonTexts(new[] { "The longest words. sorted", "Change symbol", "Delete symbol" }, 10);
        }
        #endregion

        #region Word Processing Methods
        private void myvariant()
        {
            string text = richTextBox1.Text;
            string result1 = ProcessWords(text);
            string result2 = SortWordsByLength(text);
            string result = result1 + result2;
            richTextBox2.Text = result;
        }

        private string ProcessWords(string text)
        {
            string[] words = text.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            string longestWord = "";
            int maxLength = 0;
            if (!string.IsNullOrEmpty(text))
            {
                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i].Length > maxLength)
                    {
                        maxLength = words[i].Length;
                        longestWord = words[i];
                    }
                }
                List<string> newWords = new List<string>();
                for (int i = 0; i < words.Length; i++)
                {
                    newWords.Add(words[i]);
                    if (words[i] == longestWord)
                    {
                        break;
                    }
                }
                string result1 = $"REDACTED\n" + string.Join(" ", newWords);
                return result1;
            }
            else
            {
                return $"Error\n";
            }
        }

        private string SortWordsByLength(string text)
        {
            using (var letterForm = new LetterInputForm())
            {
                if (letterForm.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(text))
                {
                    char letter = char.ToLower(letterForm.StartLetter);
                    var sortedWords = text.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries)
                      .Where(word => word.StartsWith(letter.ToString(), StringComparison.OrdinalIgnoreCase))
                      .OrderBy(word => word.Length)
                      .ToList();
                    richTextBox2.Text = string.Join(", ", sortedWords);
                    string result2 = $"\n----------------------\nSORTED\n" + string.Join(" ", sortedWords);
                    return result2;
                }
                else
                {
                    return $"Error\n";
                }
            }
        }

        private void ReplaceCharacter()
        {
            using (var characterForm = new ReplaceInputForm())
            {
                if (characterForm.ShowDialog() == DialogResult.OK)
                {
                    char oldCharacter = characterForm.OldCharacter;
                    char newCharacter = characterForm.NewCharacter;
                    string text = richTextBox1.Text;
                    string[] words = text.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
                    List<string> modifiedWords = new List<string>();

                    foreach (string word in words)
                    {
                        string modifiedWord = "";
                        foreach (char c in word)
                        {
                            if (c == oldCharacter)
                            {
                                modifiedWord += newCharacter;
                            }
                            else
                            {
                                modifiedWord += c;
                            }
                        }
                        modifiedWords.Add(modifiedWord);
                    }

                    richTextBox2.Text = string.Join(" ", modifiedWords);
                }
            }
        }

        private void RemoveCharacter()
        {
            using (var letterForm = new LetterInputForm())
            {
                if (letterForm.ShowDialog() == DialogResult.OK)
                {
                    char deleteChar = letterForm.DeleteCharacter;
                    string[] words = richTextBox1.Text.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

                    List<string> modifiedWords = new List<string>();

                    foreach (string word in words)
                    {
                        StringBuilder modifiedWord = new StringBuilder();

                        foreach (char c in word)
                        {
                            if (c == deleteChar)
                            {
                                modifiedWord.Append(' ');
                            }
                            else
                            {
                                modifiedWord.Append(c);
                            }
                        }

                        modifiedWords.Add(modifiedWord.ToString());
                    }

                    richTextBox2.Text = string.Join(" ", modifiedWords);
                }
            }
        }
        #endregion

        #region Formatting Methods
        private void ApplyColorFormatting(Color color)
        {
            richTextBox2.BackColor = color;
        }

        private void ApplyTextFormatting(string fontName, float fontSize)
        {
            richTextBox2.Font = new Font(fontName, fontSize);
        }
        #endregion

        #region RadioButton Methods
        private void SetRadioButtonTexts(string[] texts, float fontSize)
        {
            radioButton1.Text = texts[0];
            radioButton2.Text = texts[1];
            radioButton3.Text = texts[2];
            SetRadioButtonFontSize(fontSize);
            AssignRadioButtonEvents(RadioButton_CheckedChanged);
            ShowRadioButtons();
        }

        private void SetRadioButtonFontSize(float fontSize)
        {
            radioButton1.Font = new Font(radioButton1.Font.FontFamily, fontSize);
            radioButton2.Font = new Font(radioButton2.Font.FontFamily, fontSize);
            radioButton3.Font = new Font(radioButton3.Font.FontFamily, fontSize);
        }

        private void HideRadioButtons()
        {
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
        }

        private void ShowRadioButtons()
        {
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
        }

        private void AssignRadioButtonEvents(EventHandler handler)
        {
            radioButton1.CheckedChanged += handler;
            radioButton2.CheckedChanged += handler;
            radioButton3.CheckedChanged += handler;
        }
        #endregion

        #region Menu Methods
        private void EnableMenuItems(bool isEnabled)
        {
            FontToolStripMenuItem.Enabled = isEnabled;
            BackColorToolStripMenuItem.Enabled = isEnabled;
            myVariantToolStripMenuItem.Enabled = isEnabled;
        }

        private void ToggleMenuItem(ToolStripMenuItem menuItem, bool isEnabled)
        {
            menuItem.Enabled = isEnabled;
            menuItem.Checked = isEnabled;
            if (!isEnabled) HideRadioButtons();

        }
        #endregion

        #region Reset and Clear Methods
        private void defaultSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyTextFormatting("Segoe UI", 10);
            ApplyColorFormatting(Color.White);
        }

        private void clearTheResultWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
        }
        #endregion
    }
}
