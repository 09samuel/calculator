using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Calculator
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        String a;
        String[] postexp;
        int count;

        private void frmCalculator_Load(object sender, EventArgs e)
        {
            txtboxInput.Text = "0";
        }

        private void roundbtnNine_Click(object sender, EventArgs e)
        {
            if (txtboxInput.Text == "0") //to clear the 0 which is present on default
            {
                txtboxInput.Text = "";
            }
            if (txtboxResult.Text != "") //if ans present clear it for further operation
            {
                if (txtboxResult.Text == "Error") //clear txtboxInput as well because it will lead to an error on further operations
                {
                    txtboxInput.Clear();
                    txtboxResult.Clear();
                    a = "";
                }
                else
                {
                    txtboxResult.Clear();
                }
            }

            txtboxInput.Text = txtboxInput.Text + "9";
            a = a + "9";
        }

        private void roundbtnEight_Click(object sender, EventArgs e)
        {
            if (txtboxInput.Text == "0")
            {
                txtboxInput.Text = "";
            }
            if (txtboxResult.Text != "")
            {
                if (txtboxResult.Text == "Error")
                {
                    txtboxInput.Clear();
                    txtboxResult.Clear();
                    a = "";
                }
                else
                {
                    txtboxResult.Clear();
                }
            }
            txtboxInput.Text = txtboxInput.Text + "8";
            a = a + "8";
        }

        private void roundbtnSeven_Click(object sender, EventArgs e)
        {
            if (txtboxInput.Text == "0")
            {
                txtboxInput.Text = "";
            }
            if (txtboxResult.Text != "")
            {
                if (txtboxResult.Text == "Error")
                {
                    txtboxInput.Clear();
                    txtboxResult.Clear();
                    a = "";
                }
                else
                {
                    txtboxResult.Clear();
                }
            }
            txtboxInput.Text = txtboxInput.Text + "7";
            a = a + "7";
        }

        private void roundbtnSix_Click(object sender, EventArgs e)
        {
            if (txtboxInput.Text == "0")
            {
                txtboxInput.Text = "";
            }
            if (txtboxResult.Text != "")
            {
                if (txtboxResult.Text == "Error")
                {
                    txtboxInput.Clear();
                    txtboxResult.Clear();
                    a = "";
                }
                else
                {
                    txtboxResult.Clear();
                }
            }
            txtboxInput.Text = txtboxInput.Text + "6";
            a = a + "6";
        }

        private void roundbtnFive_Click(object sender, EventArgs e)
        {
            if (txtboxInput.Text == "0")
            {
                txtboxInput.Text = "";
            }
            if (txtboxResult.Text != "")
            {
                if (txtboxResult.Text == "Error")
                {
                    txtboxInput.Clear();
                    txtboxResult.Clear();
                    a = "";
                }
                else
                {
                    txtboxResult.Clear();
                }
            }
            txtboxInput.Text = txtboxInput.Text + "5";
            a = a + "5";
        }

        private void roundbtnFour_Click(object sender, EventArgs e)
        {
            if (txtboxInput.Text == "0")
            {
                txtboxInput.Text = "";
            }
            if (txtboxResult.Text != "")
            {
                if (txtboxResult.Text == "Error")
                {
                    txtboxInput.Clear();
                    txtboxResult.Clear();
                    a = "";
                }
                else
                {
                    txtboxResult.Clear();
                }
            }
            txtboxInput.Text = txtboxInput.Text + "4";
            a = a + "4";
        }

        private void roundbtnThree_Click(object sender, EventArgs e)
        {
            if (txtboxInput.Text == "0")
            {
                txtboxInput.Text = "";
            }
            if (txtboxResult.Text != "")
            {
                if (txtboxResult.Text == "Error")
                {
                    txtboxInput.Clear();
                    txtboxResult.Clear();
                    a = "";
                }
                else
                {
                    txtboxResult.Clear();
                }
            }
            txtboxInput.Text = txtboxInput.Text + "3";
            a = a + "3";
        }

        private void roundbtnTwo_Click(object sender, EventArgs e)
        {
            if (txtboxInput.Text == "0")
            {
                txtboxInput.Text = "";
            }
            if (txtboxResult.Text != "")
            {
                if (txtboxResult.Text == "Error")
                {
                    txtboxInput.Clear();
                    txtboxResult.Clear();
                    a = "";
                }
                else
                {
                    txtboxResult.Clear();
                }
            }
            txtboxInput.Text = txtboxInput.Text + "2";
            a = a + "2";
        }

        private void roundbtnOne_Click(object sender, EventArgs e)
        {
            if (txtboxInput.Text == "0")
            {
                txtboxInput.Text = "";
            }
            if (txtboxResult.Text != "")
            {
                if (txtboxResult.Text == "Error")
                {
                    txtboxInput.Clear();
                    txtboxResult.Clear();
                    a = "";
                }
                else
                {
                    txtboxResult.Clear();
                }
            }
            txtboxInput.Text = txtboxInput.Text + "1";
            a = a + "1";
        }

        private void roundbtnZero_Click(object sender, EventArgs e)
        {
            if (txtboxInput.Text != "0") //only append if 0 is not the only no. present in the equation
            {
                txtboxInput.Text = txtboxInput.Text + "0";
                a = a + "0";
            }
            if (txtboxResult.Text == "Error")
            {
                txtboxInput.Clear();
                txtboxResult.Clear();
                a = "";
            }
        }

        private void roundbtnZeroZero_Click(object sender, EventArgs e)
        {
            if (txtboxInput.Text != "0")
            {
                txtboxInput.Text = txtboxInput.Text + "00";
                a = a + "00";
            }
            if (txtboxResult.Text == "Error")
            {
                txtboxInput.Clear();
                txtboxResult.Clear();
                a = "";
            }
        }

        private void roundbtndot_Click(object sender, EventArgs e)
        {
            if (count == 0)//to prevent more than 1 deimal points in a number
            {
                if (txtboxResult.Text == "Error")
                {
                    txtboxInput.Clear();
                    txtboxResult.Clear();
                    a = "";
                }
                if (txtboxInput.Text.Length > 1)
                {
                    if (a[a.Length - 2] == '-' || a[a.Length - 2] == '+' || a[a.Length - 2] == '*' || a[a.Length - 2] == '/') //to print 0. if part  before the decimal is empty
                    {
                        txtboxInput.Text = txtboxInput.Text + "0.";
                        a = a + "0.";
                        count++;
                    }
                    else
                    {
                        txtboxInput.Text = txtboxInput.Text + ".";
                        a = a + ".";
                        count++;
                    }
                }
                else
                {
                    txtboxInput.Text = txtboxInput.Text + ".";
                    a = a + ".";
                    count++;
                }
                if (txtboxResult.Text != "")
                {
                    if (txtboxResult.Text == "Error")
                    {
                        txtboxInput.Clear();
                        txtboxResult.Clear();
                        a = "";
                    }
                    else
                    {
                        txtboxResult.Clear();
                    }
                }
            }
        }

        private void roundbtnSubtract_Click(object sender, EventArgs e)
        {
            if (txtboxInput.Text == "") { } //disable button on empty txtboxInput
            else
            {
                if (txtboxInput.Text == "0")
                {
                    txtboxInput.Text = txtboxInput.Text + "-";
                    a = a + "0:-:";
                }
                opAfterOp();
                if (txtboxResult.Text != "")
                {
                    if (txtboxResult.Text != "Error")
                    {
                        afterResult();
                        txtboxInput.Text = txtboxInput.Text + "-";
                        a = a + ":-:";
                    }
                    else
                    {
                        txtboxInput.Clear();
                        txtboxResult.Clear();
                        a = "";
                    }
                }
                else
                {
                    txtboxInput.Text = txtboxInput.Text + "-";
                    a = a + ":-:";
                }
            }
            count = 0;
        }

        private void roundbtnAdd_Click(object sender, EventArgs e)
        {
            if (txtboxInput.Text == "") { }
            else
            {
                if (txtboxInput.Text == "0")
                {
                    txtboxInput.Text = txtboxInput.Text + "+";
                    a = a + "0:+:";
                }
                opAfterOp();
                if (txtboxResult.Text != "")
                {
                    if (txtboxResult.Text != "Error")
                    {
                        afterResult();
                        txtboxInput.Text = txtboxInput.Text + "+";
                        a = a + ":+:";
                    }
                    else
                    {
                        txtboxInput.Clear();
                        txtboxResult.Clear();
                        a = "";
                    }
                }
                else
                {
                    txtboxInput.Text = txtboxInput.Text + "+";
                    a = a + ":+:";
                }
            }
            count = 0;
        }

        private void roundbtnMultiply_Click(object sender, EventArgs e)
        {
            if (txtboxInput.Text == "") { }
            else
            {
                if (txtboxInput.Text == "0")
                {
                    txtboxInput.Text = txtboxInput.Text + "*";
                    a = a + "0:*:";
                }
                opAfterOp();
                if (txtboxResult.Text != "")
                {
                    if (txtboxResult.Text != "Error")
                    {
                        afterResult();
                        txtboxInput.Text = txtboxInput.Text + "*";
                        a = a + ":*:";
                    }
                    else
                    {
                        txtboxInput.Clear();
                        txtboxResult.Clear();
                        a = "";
                    }
                }
                else
                {
                    txtboxInput.Text = txtboxInput.Text + "*";
                    a = a + ":*:";
                }
            }
            count = 0;
        }

        private void roundbtnDivide_Click(object sender, EventArgs e)
        {
            if (txtboxInput.Text == "") { }
            else
            {
                if (txtboxInput.Text == "0")
                {
                    txtboxInput.Text = txtboxInput.Text + "/";
                    a = a + "0:/:";
                }
                opAfterOp();
                if (txtboxResult.Text != "")
                {
                    if (txtboxResult.Text != "Error")
                    {
                        afterResult();
                        txtboxInput.Text = txtboxInput.Text + "/";
                        a = a + ":/:";
                    }
                    else
                    {
                        txtboxInput.Clear();
                        txtboxResult.Clear();
                        a = "";
                    }
                }
                else
                {
                    txtboxInput.Text = txtboxInput.Text + "/";
                    a = a + ":/:";
                }
            }
            count = 0;
        }

        private void roundbtnPercent_Click(object sender, EventArgs e)
        {
            if (txtboxInput.Text == "") { }
            else
            {
                if (txtboxInput.Text == "0")
                {
                    txtboxInput.Text = txtboxInput.Text + "%";
                    a = a + "0:%:";
                }
                opAfterOp();
                if (txtboxResult.Text != "")
                {
                    if (txtboxResult.Text != "Error")
                    {
                        afterResult();
                        txtboxInput.Text = txtboxInput.Text + "%";
                        a = a + ":%:";
                    }
                    else
                    {
                        txtboxInput.Clear();
                        txtboxResult.Clear();
                        a = "";
                    }
                }
                else
                {
                    txtboxInput.Text = txtboxInput.Text + "%";
                    a = a + ":%:";
                }
            }
        }

        private void roundbtnEqual_Click(object sender, EventArgs e)
        {
            if (txtboxInput.Text != "0") //disable button if only 0 present in txtboxInput
            {
                if (txtboxInput.Text.Length > 1)
                {
                    if (a[a.Length - 2] != '-' && a[a.Length - 2] != '+' && a[a.Length - 2] != '*' && a[a.Length - 2] != '/' && a[a.Length - 2] != '%')
                    {
                        if (a[a.Length - 1] == '.') //display 0 after decimal point in the absence of the far
                        {
                            a = a + "0";
                            txtboxInput.Text = txtboxInput.Text + "0";
                        }
                        postexp = infixToPostfix(a);
                        txtboxResult.Text = calculate();
                    }
                }
            }
        }

        private void roundbtnClear_Click(object sender, EventArgs e)
        {
            txtboxInput.Clear();
            txtboxResult.Clear();
            a = "";
        }

        private void roundbtnBackspace_Click(object sender, EventArgs e)
        {
            if (txtboxInput.Text != "0")
            {
                int size = a.Length;
                if (size == 1 && txtboxInput.Text != "0") //to remove the sole character
                {
                    a = a.Remove(size - 1, 1);
                    txtboxInput.Text = "0";
                }

                if (size >= 2)
                {
                    if (a[size - 2] == '*' || a[size - 2] == '/' || a[size - 2] == '%' || a[size - 2] == '-' || a[size - 2] == '+') //to remove one operator
                    {
                        a = a.Remove(size - 3, 3);
                    }
                    else //to remove one operand
                    {
                        a = a.Remove(size - 1, 1);
                    }
                    txtboxInput.Text = txtboxInput.Text.Remove(txtboxInput.Text.Length - 1, 1);
                }
                if (txtboxResult.Text != "") //clear txtboxResult 
                {
                    txtboxResult.Clear();
                }
            }
            else //to clear txtboxInput if only 0 present
            {
                txtboxInput.Clear();
            }
        }

        public void opAfterOp() //method to change the last operator in the string on click of another operator
        {
            if (txtboxInput.Text.Length >= 2)
            {
                if (a[a.Length - 2] == '-' || a[a.Length - 2] == '+' || a[a.Length - 2] == '*' || a[a.Length - 2] == '/' || a[a.Length - 2] == '%')
                {
                    if (txtboxResult.Text != "")
                    {
                        txtboxResult.Clear();
                    }
                    else
                    {
                        a = a.Remove(a.Length - 3, 3);
                        txtboxInput.Text = txtboxInput.Text.Remove(txtboxInput.Text.Length - 1, 1);
                    }
                }
            }
            if (a[a.Length - 1] == '.' && a.Length > 1) //to print 0 if part after the decimal is empty
            {
                a = a + "0";
                txtboxInput.Text = txtboxInput.Text + "0";
            }
        }

        public void afterResult() //method to allow calculation more than once
        {
            txtboxInput.Clear();
            txtboxInput.Text = txtboxResult.Text;
            a = txtboxResult.Text;
            txtboxResult.Clear();
        }

        internal static int Prec(string ch) //method to set operator precedence; to be used to convert infix to postfix
        {
            switch (ch)
            {
                case "+":
                case "-":
                    return 1;

                case "*":
                case "/":
                case "%":
                    return 2;
            }
            return -1;
        }

        public static string[] infixToPostfix(String a) //convert from infix to postfix using stack
        {
            int i = 0;

            char[] seperator = { ':' };
            String[] strlist = a.Split(seperator); //separates the string into operators and operands 

            int si = strlist.Length;
            string[] result = new string[si];

            Stack<string> stack = new Stack<string>();

            foreach (String s in strlist)
            {
                string c = s;
                if (Regex.IsMatch(c, @"^\d*\.?\d*$")) //an operand is encountered
                {
                    result[i] = c;
                    i++;
                }
                else //an operator is encountered
                {
                    while (stack.Count > 0 && Prec(c) <= Prec(stack.Peek()))
                    {
                        result[i] = stack.Pop();
                        i++;
                    }
                    stack.Push(c);
                }
            }
            while (stack.Count > 0) //pop all the operators from the stack
            {
                result[i] = stack.Pop();
                i++;
            }
            return result; //return postfix expression
        }

        public string calculate() //calculation function
        {
            Stack<string> eval = new Stack<string>();
            foreach (String p in postexp) //iterate through the entire postfix expression
            {
                if (Regex.IsMatch(p, @"^\d*\.?\d*$")) //an operand is encountered
                {
                    eval.Push(p);
                }

                if (p == "*" || p == "/" || p == "%" || p == "-" || p == "+") //an operator is encountered
                {
                    //pop first two numbers from the stack
                    double num1 = Convert.ToDouble(eval.Pop());
                    double num2 = Convert.ToDouble(eval.Pop());
                    double res;

                    if (p == "*")
                    {
                        res = num2 * num1;
                        eval.Push(Convert.ToString(res)); //push result of operation into the stack
                    }
                    if (p == "/")
                    {
                        if (num1 == 0) //to prevent infinty as result
                        {
                            return "Error";
                        }
                        res = num2 / num1;
                        eval.Push(Convert.ToString(res));
                    }
                    if (p == "%") //try 0%45
                    {
                        if (num1 == 0) //to prevent infinty as result
                        {
                            return "Error";
                        }
                        int r = Convert.ToInt32(num2 / num1);
                        res = num2 - r * num1;
                        eval.Push(Convert.ToString(res));
                    }
                    if (p == "-")
                    {
                        res = num2 - num1;
                        eval.Push(Convert.ToString(res));
                    }
                    if (p == "+")
                    {
                        res = num2 + num1;
                        eval.Push(Convert.ToString(res));
                    }
                }
            }
            return eval.Pop(); //pop the result and return
        }
    }
}