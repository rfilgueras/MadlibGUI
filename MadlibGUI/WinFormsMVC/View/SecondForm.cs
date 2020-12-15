using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsMVC.View
{
    public partial class SecondForm : Form
    {
        public SecondForm()
        {
            InitializeComponent();
        }

        public UserInput UserInput { get; set; } 
        private void wordOne_TextChanged(object sender, EventArgs e)
        {
            UserInput.WordOne = wordOne.Text;
        }

        private void wordTwo_TextChanged(object sender, EventArgs e)
        {
            UserInput.WordTwo = wordTwo.Text;
        }

        private void wordThree_TextChanged(object sender, EventArgs e)
        {
            UserInput.WordThree = wordThree.Text;
        }

        private void wordFour_TextChanged(object sender, EventArgs e)
        {
            UserInput.WordFour = wordFour.Text;
        }

        private void wordFive_TextChanged(object sender, EventArgs e)
        {
            UserInput.WordFive = wordFive.Text;
        }

        private void wordSix_TextChanged(object sender, EventArgs e)
        {
            UserInput.WordSix = wordSix.Text;
        }

        private void wordSeven_TextChanged(object sender, EventArgs e)
        {
            UserInput.WordSeven = wordSeven.Text;
        }

        private void wordEigth_TextChanged(object sender, EventArgs e)
        {
            UserInput.WordEigth = wordEigth.Text;
        }

        private void wordNine_TextChanged(object sender, EventArgs e)
        {
            UserInput.WordNine = wordNine.Text;
        }

        private void wordTen_TextChanged(object sender, EventArgs e)
        {
            UserInput.WordTen = wordTen.Text;
        }

        private void SecondForm_Load(object sender, EventArgs e)
        {
            wordOne.Text = UserInput.WordOne;
            wordTwo.Text = UserInput.WordTwo;
            wordThree.Text = UserInput.WordThree;
            wordFour.Text = UserInput.WordFour;
            wordFive.Text = UserInput.WordFive;
            wordSix.Text = UserInput.WordSix;
            wordSeven.Text = UserInput.WordSeven;
            wordEigth.Text = UserInput.WordEigth;
            wordNine.Text = UserInput.WordNine;
            wordTen.Text = UserInput.WordTen;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
