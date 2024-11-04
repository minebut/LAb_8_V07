using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_8_V07
{

    public partial class ReplaceInputForm : Form
    {
        public char OldCharacter { get; private set; }
        public char NewCharacter { get; private set; }
        public ReplaceInputForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBox1.Text) && richTextBox1.Text.Length == 1 &&
                !string.IsNullOrEmpty(richTextBox2.Text))
            {
                OldCharacter = richTextBox1.Text[0];
                NewCharacter = richTextBox2.Text[0];

                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter one character to replace.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
