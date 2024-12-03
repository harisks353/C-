using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grocery_shop
{
    public partial class Shoppingcart : Form
    {
        public Shoppingcart()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string qan;
            
            listBox3.Items.Add(numericUpDown1.Value+"X"+listBox1.SelectedItem);
         

        }

        private void button4_Click(object sender, EventArgs e)
        {


            FileStream fs = new FileStream("product.list.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);





            while (!sr.EndOfStream)
            {


                string s;
                s = sr.ReadLine();
                int i = s.IndexOf("@");
                string n = s.Substring(0, i);
                if (listBox1.SelectedItem.ToString ()== n)
                {
                    textBox1.Text = n;

                    int b = i + 1;
                    if (s.Length >= b + 5)

                    {
                        string m = s.Substring(i + 1, 5);
                        textBox2.Text = m;
                    }


                    int k = s.IndexOf("@", b + 1);
                    int l = s.IndexOf("@", k + 1);
                    string o = s.Substring(k + 1, 1);
                    textBox3.Text = o;


                    int p = s.IndexOf("@", k + 1);
                    string h = s.Substring(p + 1, 2);
                    textBox4.Text = h;

                    string pricevalue = o;
                    int StringValue = int.Parse(pricevalue);
                    int numericValue = (int)numericUpDown1.Value;
                    int result = StringValue * numericValue;
                    textBox5.Text = result.ToString();
                }
            }

            sr.Close();
            fs.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Shoppingcart_Load(object sender, EventArgs e)
        {


            FileStream fs = new FileStream("product.list.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);





            while (!sr.EndOfStream)
            {


                string s;
                s = sr.ReadLine();
                int i = s.IndexOf("@");
                string n = s.Substring(0, i);
                listBox1.Items.Add(n);
               
            }

            
            sr.Close();
            fs.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("product.list.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            
            {
                string s;
                s = sr.ReadLine();
                int i = s.IndexOf("@");
                string n = s.Substring(0, i);
                int b = i + 1;
                int k = s.IndexOf("@", b + 1);
                int l = s.IndexOf("@", k + 1);
                string o = s.Substring(k + 1, 1);
                textBox3.Text = o;
                string pricevalue = o;
                int StringValue = int.Parse(pricevalue);
                int numericValue = (int)numericUpDown1.Value;
                int result = StringValue * numericValue;
                int sum = int.Parse(textBox5.Text);
                sum = sum + result;
                textBox5.Text =sum.ToString();


                MessageBox.Show("your sum is " + sum + " .Thank you for shopping;");
            }                                   
            sr.Close();
            fs.Close();
        }   

       
        
       

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
