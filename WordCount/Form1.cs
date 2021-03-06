﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordCount
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWordCount_Click(object sender, EventArgs e)
        {
            // Assign entered string in str variable
            string userInput = txtWordCount.Text;

            // Trim the string in both trailing and leading space from the string
            if (userInput.Trim() == "")
            {
                MessageBox.Show("Please enter the string to display number of word", "Display Word Count Error");
                // It would not excute the remaining code
                return;
            }

            int noOfWords = StringWordsCount(userInput);

            MessageBox.Show("Number of words in the given string is: " + noOfWords.ToString());

        }


        private int StringWordsCount(string str)
        {
            int wordsCount = 0;
            //Null is delimenetor

            string[] strWords = str.Split(null);
            wordsCount = strWords.Length;
            return wordsCount;
        }
    }
}
