using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWindowsApplicationBroke
{

    public partial class Form1 : Form
    {   
    //PH6545643684
        public string contents;
        public double conversion1;
        public double conversion2;
        public Queue<string> symbolQueue;
        public Queue<int> intQueue;
        public int switchHolder;
        public bool secondSwapOn[];
        public string lastSymbol;




        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (conversion1 == null)
            {
                conversion1 = 1;
            }
            else
            {
                conversion1 = conversion1 * 10 + 1;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void equalsSign_Click(object sender, EventArgs e)
        {
            if (contents == null)
            {
                if (symbolQueue == null)
                {
                    try
                    {


                        if (lastSymbol == "+")
                        {
                            switchHolder = 1;
                        }else if (lastSymbol == "-")
                        {
                            switchHolder = 2;
                        }else if (lastSymbol == "x")
                        {
                            switchHolder = 3;
                        }
                        else if (lastSymbol == "/")
                        {
                            switchHolder = 4;
                        }
                        else
                        {
                            MessageBox.Show("Sorry, but it seems that you haven't chose a function. Try again!");
                            return;
                        }
                       

                        switch (switchHolder)
                        {
                            case 1:
                                conversion1 = conversion1 + conversion2;
                                contents = conversion1.ToString();
                             
                                conversion2 = 0;
                                break;
                            case 2:
                                conversion1 = conversion1 - conversion2;
                                contents = conversion1.ToString();
                     
                                conversion2 = 0;
                                break;
                            case 3:
                                conversion1 = conversion1 * conversion2;
                                contents = conversion1.ToString();
                           
                                conversion2 = 0;
                                break;
                            case 4:
                                if (conversion1 == 0)
                                {
                                    MessageBox.Show("You cannot divide by 0");
                                }else if (conversion2 == 0)
                                {
                                    MessageBox.Show("You cannot divide by 0");
                                }else
                                {
                                    conversion1 = conversion1 * conversion2;
                                    contents = conversion1.ToString();
                                //Symbol.
                                    conversion2 = 0;
                                }
                                break;

                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                }
            }
        }

        private void numberTwo_Click(object sender, EventArgs e)
        {
            if (conversion1 == null)
            {
                conversion1 = 2;
            }
            else
            {
                conversion1 = conversion1 * 10 + 2;
            }
        }

        private void numberThree_Click(object sender, EventArgs e)
        {
            if (secondSwapOn == false && conversion1 == null)
            {
                conversion1 = 3;
            }else if(secondSwapOn == false)
            {
                conversion1 = conversion1 * 10 + 3;
            }
            else if (secondSwapOn == true& conversion2 == null)
            {
                conversion2 = 3;
            }else if(secondSwapOn == true)
            {
                conversion2 = conversion2 * 10 + 3;
            }
           
           
        }

        private void numberFour_Click(object sender, EventArgs e)
        {
            if (conversion1 == null)
            {
                conversion1 = 4;
            }
            else
            {
                conversion1 = conversion1 * 10 + 4;
            }
        }

        private void numberFive_Click(object sender, EventArgs e)
        {
            if (conversion1 == null)
            {
                conversion1 = 5;
            }
            else
            {
                conversion1 = conversion1 * 10 + 5;
            }
        }

        private void numberSix_Click(object sender, EventArgs e)
        {
            if (conversion1 == null)
            {
                conversion1 = 6;
            }
            else
            {
                conversion1 = conversion1 * 10 + 6;
            }
        }

        private void numberSeven_Click(object sender, EventArgs e)
        {
            if (conversion1 == null)
            {
                conversion1 = 7;
            }
            else
            {
                conversion1 = conversion1 * 10 + 7;
            }
        }

        private void additionSign_Click(object sender, EventArgs e)
        {
            symbolQueue.Enqueue("+");
            lastSymbol = "+";
        }

        private void numberEight_Click(object sender, EventArgs e)
        {
            if (conversion1 == null)
            {
                conversion1 = 8;
            }
            else
            {
                conversion1 = conversion1 * 10 + 8;
            }
        }

        private void numberNine_Click(object sender, EventArgs e)
        {
        if (conversion1 == null)
        {
            conversion1 = 9;
        }
        else
        {
            conversion1 = conversion1 * 10 + 9;
        }
        }

        private void negativeSign_Click(object sender, EventArgs e)
        {
            symbolQueue.Enqueue("-");
            lastSymbol = "-";
        }

        private void divisionSign_Click(object sender, EventArgs e)
        {
            symbolQueue.Enqueue("/");
            lastSymbol = "/";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            
              contents = null;
        conversion1 = 0;
        conversion2 = 0;
        symbolQueue = null;
        intQueue = null;
        switchHolder = 0;
        secondSwapOn = false; //PH6545643684
        public string lastSymbol;
        }
            

        }
    }

