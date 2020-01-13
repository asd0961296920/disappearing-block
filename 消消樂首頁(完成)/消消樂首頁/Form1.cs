using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Media;

namespace 消消樂首頁
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*　　～～～程式執行流程說明～～～
         
         首先，會先將Form3中的按鈕數量和遊戲模式的數值匯入Form1中，然後Form1會在按下＂開始遊戲＂按鈕時將這些數值匯入Form2中
         Form2是遊戲執行的主要視窗，在按下開始遊戲按鈕後開始執行
         Form2執行後，首先建立４００個按鈕，然後依照剛剛從Form3中匯入進來的數值將多餘的按鈕消除
         接著隨機亂數選出圖片到按鈕中並顯示出來，然後過了四秒後將按鈕中的圖案消除，遊戲正式開始
       
　　　　當按鈕被按下後，有兩種可能，一種是翻開一張圖片，第二種可能是翻開了兩張圖片
  　　  當只翻開第一張圖片的時候，將圖片的編號記錄下來，並將按鈕設定成再點選相同的按鈕將會無反應
  　　  點選第二個按鈕後，會先比對預先存好的編號跟目前的圖片編號相不相同
  　　  如果相同的話，按鈕消除
 　　   不同的話，將圖片顯示出來，然後畫面停留０．５秒，圖片消除
  　　  最後再比對畫面上的所有按鈕是否全部消失，是的話結束程式，否的話繼續遊戲
         
            　～～～以上是程式主體的流程～～～
        */

        private void Form1_Load(object sender, EventArgs e)
        {
            // pictureBox1.BackgroundImage = Image.FromFile("Resources\\123.gif");
            label1.Parent = this.pictureBox1;
            label2.Parent = this.pictureBox1;
            label3.Parent = this.pictureBox1;
            label4.Parent = this.pictureBox1;
            label5.Parent = this.pictureBox1;
            label6.Parent = this.pictureBox1;
            Bitmap bit = new Bitmap(("Resources\\楓谷背景.gif"));
         this.pictureBox1.Image = bit;
            SoundPlayer sp = new SoundPlayer(".\\Resources\\楓之谷.wav");//匯入聲音檔
            sp.Stop();
            pictureBox2.Parent = this.pictureBox1;
            pictureBox3.Parent = this.pictureBox1;
            pictureBox4.Parent = this.pictureBox1;
            pictureBox5.Parent = this.pictureBox1;

            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            

        }
        bool y = true;
        private void button1_Click(object sender, EventArgs e)
        {//將設定的數據傳給遊戲
            f3.String1 = zz.ToString();
            
            f3.CS1 =xx.ToString();
            f3.ShowDialog();

        }


        Form4 f4 = new Form4();
 
        private void button2_Click(object sender, EventArgs e)
        {
          //  f4.Visible = true;
            f4.Owner = this;
            f4.ShowDialog();


        }

        //傳遞設定的數值區
        private string strValue;
        public string StrValue//決定顯示多少按鈕的部分
        {
            set
            {
                strValue = value;
               
            }
        }
        private string cs;
        public string CS//決定哪種遊戲模式的部分
        {
            set
            {
                cs = value;

            }
        }

        public int zz = 4;
        public int xx = 1;
        Form3 f2 = new Form3();
        Form2 f3 = new Form2();
        private void button3_Click(object sender, EventArgs e)
        {
          

            //     f2.Visible = true;
            //接收設定的數據
            f2.Owner = this;
            f2.ShowDialog();
           zz=int.Parse( strValue);
          xx= int.Parse(cs);
        }









        bool q = false;
        private void button4_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(".\\Resources\\楓之谷.wav");
            if (q ==true)
            {button4.Image = Image.FromFile("Resources\\172.png");
                sp.Stop();
                q = false;
            }
            else if(q==false)
            {
                button4.Image = Image.FromFile("Resources\\171.png");
                sp.PlayLooping();
                q = true;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        //滑鼠進入
        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.ForeColor = Color.White;
           pictureBox2.Image = Image.FromFile("Resources\\指標 (1)1.png");

        }
        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.ForeColor = Color.White;
            pictureBox3.Image = Image.FromFile("Resources\\指標 (1)1.png");
        }
        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            button3.ForeColor = Color.White;
            pictureBox4.Image = Image.FromFile("Resources\\指標 (1)1.png");
        }
        private void button5_MouseMove(object sender, MouseEventArgs e)
        {
            button5.ForeColor = Color.White;
            pictureBox5.Image = Image.FromFile("Resources\\指標 (1)1.png");
        }





        //滑鼠離開
        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Black;
            pictureBox2.Image =null;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
            pictureBox3.Image = null;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.ForeColor = Color.Black;
            pictureBox4.Image = null;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.ForeColor = Color.Black;
            pictureBox5.Image = null;
        }
    }
}
