namespace CAlculator_Project_abu_hasnat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int numOne;
        int numTwo;
        int equals;

        private void numberOne_Click(object sender, EventArgs e)
        {
            resultWindow.Text = resultWindow.Text + numberOne.Text;
        }

        private void numberTwo_Click(object sender, EventArgs e)
        {
            resultWindow.Text = resultWindow.Text + numberTwo.Text;
        }

        private void NumberThree_Click(object sender, EventArgs e)
        {
            resultWindow.Text = resultWindow.Text + NumberThree.Text;
        }

        private void numberFour_Click(object sender, EventArgs e)
        {
            resultWindow.Text = resultWindow.Text + numberFour.Text;
        }

        private void numberFive_Click(object sender, EventArgs e)
        {
            resultWindow.Text = resultWindow.Text + numberFive.Text;
        }

        private void numberSix_Click(object sender, EventArgs e)
        {
            resultWindow.Text = resultWindow.Text + numberSix.Text;
        }

        private void numberSeven_Click(object sender, EventArgs e)
        {
            resultWindow.Text = resultWindow.Text + numberSeven.Text;
        }

        private void numberEight_Click(object sender, EventArgs e)
        {
            resultWindow.Text = resultWindow.Text + numberEight.Text;
        }

        private void numberNine_Click(object sender, EventArgs e)
        {
            resultWindow.Text = resultWindow.Text + numberNine.Text;
        }

        private void numberZero_Click(object sender, EventArgs e)
        {
            resultWindow.Text = resultWindow.Text + numberZero.Text;
        }

        private void deciamlButton_Click(object sender, EventArgs e)
        {
            resultWindow.Text = resultWindow.Text + deciamlButton.Text;
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            operatorWindow.Text =  plusButton.Text;
            numOne = int.Parse(resultWindow.Text);
            resultWindow.Text = null;
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            operatorWindow.Text =  minusButton.Text;
            numOne = int.Parse(resultWindow.Text);
            resultWindow.Text = null;
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            operatorWindow.Text =  multiplyButton.Text;
            numOne = int.Parse(resultWindow.Text);
            resultWindow.Text = null;
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            operatorWindow.Text =  divideButton.Text;
            numOne = int.Parse(resultWindow.Text);
            resultWindow.Text = null;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            resultWindow.Text = null;
            operatorWindow.Text = null;
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            numTwo = int.Parse(resultWindow.Text);

            if(operatorWindow.Text == "+")
            {
                equals = numOne + numTwo;
                resultWindow.Text = equals.ToString();
            }
            else if (operatorWindow.Text == "-")
            {
                equals = numOne - numTwo;
                resultWindow.Text = equals.ToString();
            }
            else if (operatorWindow.Text == "*")
            {
                equals = numOne * numTwo;
                resultWindow.Text = equals.ToString();
            }
            else if (operatorWindow.Text == "/")
            {
                equals = (numOne / numTwo);
                resultWindow.Text = equals.ToString();
            }
            else
            {
                resultWindow.Text = null;
            }

        }
    }
}