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
    
        public string contents;
        public double conversion1;
        public double conversion2;
        public string symbolHolder;
        public int switchHolder;




        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void equalsSign_Click(object sender, EventArgs e)
        {
            if (contents == null)
            {
                if (symbolHolder == null)
                {
                    try
                    {


                        if (symbolHolder == "+")
                        {
                            switchHolder = 1;
                        }else if (symbolHolder == "-")
                        {
                            switchHolder = 2;
                        }else if (symbolHolder == "x")
                        {
                            switchHolder = 3;
                        }
                        else if (symbolHolder == "/")
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
                                symbolHolder = null;
                                conversion2 = 0;
                                break;
                            case 2:
                                conversion1 = conversion1 - conversion2;
                                contents = conversion1.ToString();
                                symbolHolder = null;
                                conversion2 = 0;
                                break;
                            case 3:
                                conversion1 = conversion1 * conversion2;
                                contents = conversion1.ToString();
                                symbolHolder = null;
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
                                    symbolHolder = null;
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
    }
}
