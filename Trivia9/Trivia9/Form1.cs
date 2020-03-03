using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trivia9
{
    public partial class Form1 : Form
    {
        // instance variables

        private Trivia8 Trivia;
        public Form1()
        {
            InitializeComponent();

            constructorTrivia.Enabled = true;
            get2out3.Enabled = false;
            escapeWumpus.Enabled = false;
            getHint.Enabled = false;

        }


        private void get2out3_Click(object sender, EventArgs e)
        {
            myTrivia.get2out3();
        }

        private void constructorTrivia_Click(object sender, EventArgs e)
        {
            Trivia8 myTrivia = new Trivia8();
            constructorTrivia.Enabled = false;
            get2out3.Enabled = true;
            escapeWumpus.Enabled = true;
            getHint.Enabled = true;
        }

        private void getHint_Click(object sender, EventArgs e)
        {

            getHintLabel.Text = myTrivia.getHint("hint!");
        }

        private void escapeWumpus_Click(object sender, EventArgs e)
        {
            myTrivia.escapeWumpus();
        }

        private void getHintLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
