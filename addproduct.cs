using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Grocery_shop
{
    public partial class addproduct : Form
    {
        public addproduct()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        string randomnum()
        {
            Random r = new Random();
            int a = r.Next(10000, 99999);
            return a.ToString();
        }

        
        public void button1_Click(object sender, EventArgs e)
        {
            string n, i, p, u;
            n=textBox1.Text;
            i=textBox2.Text;
            p = textBox3.Text;
            u =comboBox1.Text;
            product r = new product();
            r.productName = textBox1.Text;
            r.ID = textBox2.Text;
            r.Price = textBox3.Text;
            r.Unit = comboBox1.Text;

            FileStream FS = new FileStream("product.list.txt", FileMode.Append, FileAccess.Write);

            StreamWriter sw = new StreamWriter(FS);
            sw.WriteLine(r.stFullInfo());
            sw.Close();
            FS.Close();
         
            
                if (string.IsNullOrEmpty(r.productName))
                {
                    MessageBox.Show("please Enter the Product Name");
                }

               if (string.IsNullOrEmpty(r.Price))
                {
                    MessageBox.Show("please Enter the Price");
                }
                if (string.IsNullOrEmpty(r.Unit))
                {
                    MessageBox.Show("please Enter the Unit");
                }
               else
               {
                MessageBox.Show("PRODUCT ADDED SUCCESFULLY");
               }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.Items.Clear();
           
            
        }
      

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox2.Text = randomnum();
            }
            checkBox2.Refresh();
        }   
    }
}
