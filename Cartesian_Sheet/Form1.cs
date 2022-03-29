using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Cartesian_Sheet
{
    public partial class Form1 : Form
    {
        private double leftBorder, rightBorder, step, parameterA;
        private double x, y;
        private void DefaultParams()
        {
            leftBorder = -10;
            rightBorder = 10;
            step = 0.1;
            parameterA = 3;
            textBox_to.Text = rightBorder.ToString();
            textBox_from.Text = leftBorder.ToString();
            textBox_param.Text = parameterA.ToString();
            textBox_step.Text = step.ToString();
        }
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_clear_Click(sender, e);
        }
        private void buildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_build_Click(sender, e);
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Irina Bovchurova group 403 \n\n" +
                "    The application is written by using WinForms technology to plot " +
                "a Cartesian sheet function and output a table of function values.\n" +
                "   The user sets the right and left border, step, coefficient.\n" +
                "   If it is impossible to plot a function in a given interval, the user is given a warning " +
                "about this with a suggestion to change the bordes of the interval.\n" +
                "   If the graph of the function becomes a point or cannot be constructed, the user also sees a warning.", "About");
        }
        private void button_build_Click(object sender, EventArgs e)
        {
            Algorithm algorithm = new Algorithm();
            List<FunctionArg> list = new List<FunctionArg>();
            if (CorrectParam())
            {
                double asymptote = parameterA / Math.Sqrt(2);
                x = leftBorder;
                double l = 3 * parameterA / Math.Sqrt(2);
                this.chart.Series[0].Points.Clear();
                while (x <= rightBorder)
                {
                    y = x * Math.Sqrt((l + x) / (l - 3 * x));
                    this.chart.Series[0].Points.AddXY(x, y);
                    x += step;
                }
                x = leftBorder;
                while (x <= rightBorder)
                {
                    y = -(x * Math.Sqrt((l + x) / (l - 3 * x)));
                    this.chart.Series[0].Points.AddXY(x, y);
                    x += step;
                }
                list = algorithm.SaveToList(leftBorder, rightBorder, step, parameterA);
                table.DataSource = list;
            }
        }
        private void button_clear_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();
            this.chart.Series[0].Points.Clear();
            textBox_from.Clear();
            textBox_param.Clear();
            textBox_step.Clear();
            textBox_to.Clear();
            table.DataSource = list;
        }

        private bool CorrectParam()
        {
            Algorithm algorithm = new Algorithm();
            double rightFrom = 0.0;
            double rightTo = 0.0;
            double rstep = 0.0;

            if (textBox_from.Text == "" || textBox_to.Text == "" || textBox_step.Text == "" || textBox_param.Text == "")
            {
                if (MessageBox.Show("Use default settings? \n from -10 to 10 with step 0,1 \n param a = 3", "Attention", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DefaultParams();
                    return true;
                }
                else
                {
                    MessageBox.Show("Enter the parameter values!", "Attention");
                    return false;
                }
            }
            else
            {
                leftBorder = Convert.ToDouble(textBox_from.Text);
                rightBorder = Convert.ToDouble(textBox_to.Text);
                step = Convert.ToDouble(textBox_step.Text);
                parameterA = Convert.ToDouble(textBox_param.Text);
                double distance = rightBorder - leftBorder;
                if (leftBorder >= rightBorder)
                {
                    MessageBox.Show("The value of B must be greater than the value of A!", "Attention");
                    return false;
                }
                if (step == 0)
                {
                    MessageBox.Show("The step cannot be zero!", "Attention");
                    return false;
                }
                if (parameterA == 0)
                {
                    MessageBox.Show("The parameter a cannot be zero!", "Attention");
                    return false;
                }
                algorithm.RightBorders(ref rightFrom, ref rightTo, parameterA);
                if ((leftBorder > rightFrom) || (rightBorder < rightTo) || ((distance) / parameterA > 5))
                {
                    if (MessageBox.Show("In the specified range, the graph may not exist or be displayed incorrectly.\n" +
                        "Would you like to change the range to [" + rightFrom + " .. " + rightTo + "]?", "Attention", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        leftBorder = rightFrom;
                        rightBorder = rightTo;
                        textBox_from.Text = rightFrom.ToString();
                        textBox_to.Text = rightTo.ToString();
                    }
                }
                algorithm.RightStep(ref rstep, rightBorder, leftBorder);
                if (((distance) /step < 200))
                {
                    if (MessageBox.Show("At this step, the graph may be displayed incorrectly.\n" +
                        "Would you like to change the step to " + rstep + "?", "Attention", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        step = rstep;
                        textBox_step.Text = rstep.ToString();
                    }
                }
            }
            return true;
        }

        private bool RightKey(ref KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return true;
            }
            if (Char.IsControl(e.KeyChar))
            {
                return true;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
                return true;
            }
            if (e.KeyChar == ',')
            {
                return true;
            }
            return false;
        }

        private void textBox_to_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool right = RightKey(ref e);
            if (e.KeyChar == '-')
            {
                return;
            }
            if (right)
            {
                if (e.KeyChar == ',')
                {
                    if (textBox_to.Text == "")
                    {
                        e.Handled = true;
                    }
                    if (textBox_to.Text.IndexOf(',') != -1)
                    {
                        e.Handled = true;
                    }
                    return;
                }
                return;
            }
            e.Handled = true;
        }
        private void textBox_from_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool right = RightKey(ref e);
            if (e.KeyChar == '-')
            {
                return;
            }
            if (right)
            {
                if (e.KeyChar == ',')
                {
                    if (textBox_from.Text == "")
                    {
                        e.Handled = true;
                    }
                    if (textBox_from.Text.IndexOf(',') != -1)
                    {
                        e.Handled = true;
                    }
                    return;
                }
                return;
            }
            e.Handled = true;
        }
        private void textBox_step_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool right = RightKey(ref e);
            if (right)
            {
                if (e.KeyChar == ',')
                {
                    if (textBox_step.Text == "")
                    {
                        e.Handled = true;
                    }
                    if (textBox_step.Text.IndexOf(',') != -1)
                    {
                        e.Handled = true;
                    }
                    return;
                }
                return;
            }
            e.Handled = true;
        }
        private void textBox_param_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool right = RightKey(ref e);
            if (e.KeyChar == '-')
            {
                return;
            }
            if (right)
            {
                if (e.KeyChar == ',')
                {
                    if (textBox_param.Text == "")
                    {
                        e.Handled = true;
                    }
                    if (textBox_param.Text.IndexOf(',') != -1)
                    {
                        e.Handled = true;
                    }
                    return;
                }
                return;
            }
            e.Handled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            aboutToolStripMenuItem_Click(sender, e);
        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
