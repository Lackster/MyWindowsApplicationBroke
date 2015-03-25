using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics.Contracts;

namespace MyWindowsApplicationBroke
{

    public partial class Form1 : Form
    {   
    //PH6545643684
        public string contents;
        public double conversion1 = 0;
        public double conversion2;
        public Queue<string> symbolQueue;
        public Queue<double> intQueue;
        public int switchHolder;
        public bool secondSwapOn;
        public string lastSymbol;

     




        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (intQueue == null)
            {
                conversion1 = 1;
                textVisor.Text = conversion1.ToString();
                textVisor.Update();
            }
            else if (intQueue != null)
            {
                conversion1 = conversion1 * 10 + 1;
                textVisor.Text = conversion1.ToString();
                textVisor.Update();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            symbolQueue = new Queue<string>();
            intQueue = new Queue<double>();
        }

        private void equalsSign_Click(object sender, EventArgs e)
        {
            try
            {
               
                double spork =0;
                intQueue.Enqueue(conversion1);
                conversion1 = 0;
                
                while (intQueue.Count > 0)
                {
                    
                    string cheese = symbolQueue.Dequeue();
                    double tomatos = intQueue.Dequeue();
                    

                    switch (cheese)
                    {
                        case "+":
                            if (spork == 0)
                            {
                                spork = tomatos + intQueue.Dequeue();
                               
                            }
                            else
                            {
                                spork = spork + intQueue.Dequeue();
                            }
                            
                            break;
                        case "-":
                            break;
                        case "*":
                            break;
                        case "/":
                            break;
                    }
                    
                } 
                textVisor.Text = spork.ToString();
                
                            textVisor.Update();
                            conversion1 = spork;
            }
                
            catch (Exception i)
            {
                MessageBox.Show(i.Message);
            }
        }

        private void numberTwo_Click(object sender, EventArgs e)
        {
           if (intQueue == null)
           {
               conversion1 = 2;
               textVisor.Text = conversion1.ToString();
               textVisor.Update();
           }else if (intQueue != null)
           {
               conversion1 = conversion1 * 10 + 2;
               textVisor.Text = conversion1.ToString();
               textVisor.Update();
           }
        }

        private void numberThree_Click(object sender, EventArgs e)
        {
            if (intQueue == null)
            {
                conversion1 = 3;
                textVisor.Text = conversion1.ToString();
                textVisor.Update();
            }
            else if (intQueue != null)
            {
                conversion1 = conversion1 * 10 + 3;
                textVisor.Text = conversion1.ToString();
                textVisor.Update();
            }
           
           
        }

        private void numberFour_Click(object sender, EventArgs e)
        {
            if (intQueue == null)
            {
                conversion1 = 4;
                textVisor.Text = conversion1.ToString();
                textVisor.Update();
            }
            else if (intQueue != null)
            {
                conversion1 = conversion1 * 10 +4;
                textVisor.Text = conversion1.ToString();
                textVisor.Update();
            }
        }

        private void numberFive_Click(object sender, EventArgs e)
        {
            if (intQueue == null)
            {
                conversion1 =5;
                textVisor.Text = conversion1.ToString();
                textVisor.Update();
            }
            else if (intQueue != null)
            {
                conversion1 = conversion1 * 10 + 5;
                textVisor.Text = conversion1.ToString();
                textVisor.Update();
            }
        }

        private void numberSix_Click(object sender, EventArgs e)
        {
            if (intQueue == null)
            {
                conversion1 = 6;
                textVisor.Text = conversion1.ToString();
                textVisor.Update();
            }
            else if (intQueue != null)
            {
                conversion1 = conversion1 * 10 + 6;
                textVisor.Text = conversion1.ToString();
                textVisor.Update();
            }
        }

        private void numberSeven_Click(object sender, EventArgs e)
        {
            if (intQueue == null)
            {
                conversion1 = 7;
                textVisor.Text = conversion1.ToString();
                textVisor.Update();
            }
            else if (intQueue != null)
            {
                conversion1 = conversion1 * 10 + 7;
                textVisor.Text = conversion1.ToString();
                textVisor.Update();
            }
        }

        private void additionSign_Click(object sender, EventArgs e)
        {
            symbolQueue.Enqueue("+");
            intQueue = new Queue<double>();
            intQueue.Enqueue(conversion1);
            textVisor.Text = conversion1 + "+";
            conversion1 = 0;
           
            
        }

        private void numberEight_Click(object sender, EventArgs e)
        {
            if (intQueue == null)
            {
                conversion1 = 8;
                textVisor.Text = conversion1.ToString();
                textVisor.Update();
            }
            else if (intQueue != null)
            {
                conversion1 = conversion1 * 10 + 8;
                textVisor.Text = conversion1.ToString();
                textVisor.Update();
            }
        }

        private void numberNine_Click(object sender, EventArgs e)
        {
            if (intQueue == null)
            {
                conversion1 = 9;
                textVisor.Text = conversion1.ToString();
                textVisor.Update();
            }
            else if (intQueue != null)
            {
                conversion1 = conversion1 * 10 + 9;
                textVisor.Text = conversion1.ToString();
                textVisor.Update();
            }
        }

        private void negativeSign_Click(object sender, EventArgs e)
        {
            symbolQueue.Enqueue("-");
            lastSymbol = "-";
            textVisor.Clear();
        }

        private void divisionSign_Click(object sender, EventArgs e)
        {
            symbolQueue.Enqueue("/");
            lastSymbol = "/";
            MessageBox.Show(symbolQueue.Dequeue());
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            
              textVisor.Text = null;
        conversion1 = 0;
        conversion2 = 0;
        intQueue = null;
        switchHolder = 0;
        secondSwapOn = false; //PH6545643684
        string lastSymbol;
        }

        private void textVisor_TextChanged(object sender, EventArgs e)
        {
            conversion1 = double.Parse(textVisor.Text);
           
            for (int ilk = 0; ilk < textVisor.Text.Length; ilk++)
            {
                if (textVisor.Text.Contains("*+-/"))
                {
                    string textConv = textVisor.Text;
                    char[] c;
                    c = textConv.ToArray<char>(); 
                    if (char.IsSymbol(c[ilk]))
                    {
                    if (c[ilk] == (char)42)
                    {
                        symbolQueue.Enqueue("*");
                    }else if ( c[ilk] == (char)43)
                    {
                        symbolQueue.Enqueue("+");
                    }else if (c[ilk] == (char)47)
                    {
                        symbolQueue.Enqueue("/");
                    }else if (c[ilk] == (char)45)
                    {
                        symbolQueue.Enqueue("-");
                    }else if (char.IsWhiteSpace(c[ilk]))
                    {
                        MessageBox.Show("Sorry, but WhiteSpace is not allowed. Try again please?");
                        return;
                    }
                    }
                    else if (char.IsNumber(c[ilk]))
                    {
                        intQueue.Enqueue(c[ilk]);
                    }
                   
                   
                   
                  
                }
                
               
              

             

            }

           

        }
            

        }
    }

