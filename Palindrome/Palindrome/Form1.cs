using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Palindrome
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxInput.Text))
            {
                var input = textBoxInput.Text;

                var inputReverse = new String(input.Reverse().ToArray());

                if (inputReverse.ToString() == input.ToString())
                {
                    labelPalindrome.Text = "It's a palindrome :)";
                }
                else
                {
                    labelPalindrome.Text = "It ain't a palindrome!";
                }
            }
            else
            {
                labelPalindrome.Text = "Enter something...";
            }
        }
    }
}
