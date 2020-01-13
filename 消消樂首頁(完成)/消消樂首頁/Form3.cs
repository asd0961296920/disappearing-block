using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 消消樂首頁
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 we = (Form1)this.Owner;
            we.StrValue = "4";
            we.CS = "1";
            this.Close();
        }
   
        int ww;
 
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 we = (Form1)this.Owner;
           
            if (numericUpDown1.Value == 1 || numericUpDown1.Value == 3 || numericUpDown1.Value == 5 || numericUpDown1.Value == 7 || numericUpDown1.Value == 9 || numericUpDown1.Value==11)
            {
               
                we.CS = "1";
                ww = int.Parse(numericUpDown1.Value.ToString());
                we.StrValue =(ww+1).ToString();

                this.Close();
                return;
               
             
            }
            if (numericUpDown1.Value>=15 || numericUpDown1.Value<=0)
            {
                MessageBox.Show("請輸入1-14之間的數字");
                return;
            }
       
                if (radioButton1.Checked)//自訂模式
                {

                    we.CS = "1";
                    
                    we.StrValue = numericUpDown1.Value.ToString();

                }
                if (radioButton2.Checked)//100秒挑戰模式
                {
                    we.CS = "2";
                    we.StrValue = "6";
                }
                if (radioButton3.Checked)//地獄模式
                {
                    we.CS = "3";
                    we.StrValue = "8";
                }
                this.Close();
            
          
        }









        private void Form3_Load(object sender, EventArgs e)
        {
           
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //textBox1.Text = ee.ToString();
        }
    }
}
