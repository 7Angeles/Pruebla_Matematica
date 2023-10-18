using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private object timeLabel;
        private int timeLeft;
        private int addend1;
        private int minuend;
        private int addend2;
        private int dividend;
        private int divisor;
        private int multiplier;

        public Form1()
        {
            InitializeComponent();
            Random randomizer = new Random();
            int addend1;
            int addend2;

            
            int minuend;
            int subtrahend;

            
            int multiplicand;
            int multiplier;

            
            int dividend;
            int divisor;


            int timeLeft;

        }

        private bool CheckTheAnswer1(int addend1, int addend2, int minuend, int subtrahend, int multiplicand, int multiplier, int dividend, int divisor)
        {
            if ((addend1 + addend2 == Suma.Value)
                && (minuend - subtrahend == Diferente.Value)
                && (multiplicand * multiplier == Producto.Value)
                && (dividend / divisor == Division.Value))
                return true;
            else
                return false;
        }

        private void StartTheQuiz1(Random randomizer, ref int addend1, ref int addend2, ref int minuend, ref int subtrahend, ref int multiplicand, ref int multiplier, ref int dividend, ref int divisor, ref int timeLeft)
        {
            // Fill in the addition problem.
            // Generate two random numbers to add.
            // Store the values in the variables 'addend1' and 'addend2'.
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            // Convert the two randomly generated numbers
            // into strings so that they can be displayed
            // in the label controls.
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();

            // 'sum' is the name of the NumericUpDown control.
            // This step makes sure its value is zero before
            // adding any values to it.
            Suma.Value = 0;

            // Fill in the subtraction problem.
            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            minusLeftLabel.Text = minuend.ToString();
            minusRightLabel.Text = subtrahend.ToString();
            Diferente.Value = 0;

            // Fill in the multiplication problem.
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            timesLeftLabel.Text = multiplicand.ToString();
            timesRightLabel.Text = multiplier.ToString();
            Producto.Value = 0;

            // Fill in the division problem.
            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            dividedLeftLabel.Text = dividend.ToString();
            dividedRightLabel.Text = divisor.ToString();
            Division.Value = 0;

            // Start the timer.
            timeLeft = 30;
            timeLabel.Text = "30 seconds";
            timer1.Start();
        }






        private void timer1_Tick(object sender, EventArgs e)
        {

            if (CheckTheAnswer())
            {
                // If CheckTheAnswer() returns true, then the user 
                // got the answer right. Stop the timer  
                // and show a MessageBox.
                timer1.Stop();
                MessageBox.Show("You got all the answers right!",
                                "Congratulations!");
                startButton.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                // If CheckTheAnswer() returns false, keep counting
                // down. Decrease the time left by one second and 
                // display the new time left by updating the 
                // Time Left label.
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + " seconds";
            }
            else
            {
                // If the user ran out of time, stop the timer, show
                // a MessageBox, and fill in the answers.
                timer1.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                Suma.Value = addend1 + addend2;
                int subtrahend = 0;
                Diferente.Value = minuend - subtrahend;
                int multiplicand = 0;
                Producto.Value = multiplicand * multiplier;
                Division.Value = dividend / divisor;
                startButton.Enabled = true;
            }

        }

        private bool CheckTheAnswer()
        {
            throw new NotImplementedException();
        }

        private void starbutton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;

        }

        private void StartTheQuiz()
        {
            throw new NotImplementedException();
        }

        private void Suma_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Diferente_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Producto_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Division_ValueChanged(object sender, EventArgs e)
        {

        }
    }
    

}

