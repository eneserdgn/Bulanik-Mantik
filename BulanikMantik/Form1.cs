using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BulanikMantik
{
    public partial class Form1 : Form
    {
        public double yas;
        public double sonuc;
       

        public Form1()
        {
            InitializeComponent();
        }
        
        public string YeniDogan(double yas)
        {
            
                if (yas >= 5)
                {
                    return "0";
                 }
                else
                {
                     return Convert.ToString(Math.Round(1 - (yas / 5), 2));
                
                }
           

        }
        public string  Genc(double yas)
        {

            if (yas >= 18 && yas <=35)
            {
                return Convert.ToString(Math.Round(1 - ((yas-18) / 18), 2));
            }
            else if (yas >45)
            {
                return "1";
            }
            else if (yas < 5)
            {
                return "0";
            }
            else
            {
                return Convert.ToString(Math.Round(1 - (yas / 18), 2));
            }
           
        }
        public string Yetiskin(double yas)
        {
            if (yas >= 30 && yas <= 55)
            {
                return Convert.ToString(Math.Round(1 - ((yas - 30) / 30), 2));
            }
            else if (yas > 55)
            {
                return "1";
            }
            else if (yas < 15)
            {
                return "0";
            }
            else
            {
                return Convert.ToString(Math.Round(1 - (yas / 30), 2));
            }



        }
        public string Yasli(double yas)
        {

            if (yas >= 60 && yas <= 80)
            {
                return Convert.ToString(Math.Round(1 - ((yas - 60) / 60), 2));
            }
            else if (yas > 80)
            {
                return "1";
            }
            else if (yas < 45)
            {
                return "0";
            }
            else
            {
                return Convert.ToString(Math.Round(1 - (yas / 60), 2));
            }


        }
        


        private void button1_Click(object sender, EventArgs e)
        {
           

            yas = Convert.ToDouble(textBox1.Text);
            if (yas > 0)
            {

                label6.Text = YeniDogan(yas);
                label7.Text = Genc(yas);
                label8.Text = Yetiskin(yas);
                label9.Text = Yasli(yas);

            }

            else
            {
                MessageBox.Show("Adam Akıllı Yaşını Gir");
            }
          
            }

         
        }
    }

