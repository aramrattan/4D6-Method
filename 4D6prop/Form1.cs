using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4D6prop
{
    public partial class Form1 : Form
    {
        //random has to be global
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
            
        }
        private int fourDSix()
        {
            //list has to be in method
            List<int> fourDice = new List<int>();
            int sum = 0;
            fourDice.Add(rnd.Next(1, 7));
            //label1.Text = Convert.ToString(fourDice[0]);
            fourDice.Add(rnd.Next(1, 7));
            //label2.Text = Convert.ToString(fourDice[1]);
            fourDice.Add(rnd.Next(1, 7));
            //label3.Text = Convert.ToString(fourDice[2]);
            fourDice.Add(rnd.Next(1, 7));
            //label4.Text = Convert.ToString(fourDice[3]);

            fourDice.Sort();

            for (int i = 1; i < 4; i++)
            {
                sum += fourDice[i];
            }

            
            return sum;
        }

        private void RollButton_Click(object sender, EventArgs e)
        {
            SumTextBox.Text = Convert.ToString(fourDSix());
        }
    }
}
