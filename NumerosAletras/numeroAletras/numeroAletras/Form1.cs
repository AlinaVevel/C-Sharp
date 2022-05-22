using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numeroAletras
{
    public partial class Form1 : Form
    {

        private static string[] ones = {
              " ", "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve", "diez", "once", "doce", "trece", "catorce", "quince", "dieciceis", "dieciciete", "dieciocho", "diecinueve"
        };

        private static string[] tens = {" ", "diez", "vente", "trenta", "cuarenta", "cincuenta", "sesenta", "setenta", "ochenta", "noventa" };

        private static string[] thous = { "cien", " mil", " million", " milmillon", " billion"};
        public Form1()
        {
            InitializeComponent();
            lblResultado.Text = " ";
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(textBox1.Text);

            lblResultado.Text = ToWords(number);
        }

        private static string ToWords(int number, string appendScale = "")
        {
            string numString;
            if (number < 100)
            {
                if (number < 20)
                {
                    numString = ones[number];
                    if(numString == "cinco")
                    {
                        numString = "quinien";
                    }
                }
                    
               
                else
                {
                    if (numString == ;)
                    numString = tens[number / 10];
                    if ((number % 10) > 0)
                        numString += " y " + ones[number % 10];
                }
            }
            else
            {
                int pow = 0;
                string powStr;

                if (number < 1000) 
                {
                    pow = 100;
                    powStr = thous[0]+"tos";
                   
                }
                else 
                {
                    int log = (int)Math.Log(number, 1000);
                    pow = (int)Math.Pow(1000, log);
                    powStr = thous[log];
                }

                numString = string.Format("{0} {1}", ToWords(number / pow, powStr), ToWords(number % pow));
            }

            return string.Format("{0}{1}", numString, appendScale);
        }
    }
}
