using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace 消消樂首頁
{
    public partial class Form2 : Form
    {
        //重新啟動程式的方法
        private void Restart()
        {
            System.Threading.Thread thtmp = new System.Threading.Thread(new
            System.Threading.ParameterizedThreadStart(run));

            object appName = Application.ExecutablePath;
            System.Threading.Thread.Sleep(2000);
            thtmp.Start(appName);
        }

        private void run(Object obj)
        {
            System.Diagnostics.Process ps = new System.Diagnostics.Process();
            ps.StartInfo.FileName = obj.ToString();
            ps.Start();
        }

        //程式進入點
        public Form2()
        {
            InitializeComponent();
        }

        //傳遞設定的數值區
        string string1;//決定顯示多少按鈕的部分
        public string String1
        {
            set
            {
                string1 = value;
            }
        }

        private string cs1;//決定哪種遊戲模式的部分
        public string CS1
        {
            set
            {
                cs1 = value;

            }
        }

        Form3 f2 = new Form3();//匯入設定表單
        public int[] c = new int[400];//儲存亂數
        Random fff = new Random();//生成亂數
        Button[,] btn = new Button[20,20];//按鈕陣列
        int u = 0;
        //  public int[] z = new int[16];
        bool uy = false;
        int pp = 0;
           int cv = 0;
    
        private void Form2_Load(object sender, EventArgs e)
        {
           
            string vv = cs1;//遊戲模式
            pp = int.Parse(string1);   //決定按鈕單行數量
            
            cv = pp * pp;//按鈕總數
           

            this.Size = new Size(pp* 85, pp* 105);
          
            label4.Location = new Point(0, pp * 90);
            if (pp == 2)//第二模式
            {
                label4.Location = new Point(0, pp * 102);
                this.Size = new Size(pp * 120, pp * 130);
            }
            bool rr = false;
            for (int i = 0; i <= btn.GetUpperBound(0); i++) //建立全部的按鈕基本數值
            {
                for (int j = 0; j <= btn.GetUpperBound(1); j++)
                {
                    if (i < pp && j < pp)
                    {
                        rr = true;
                    }
                    else
                    {
                        rr = false;
                    }
                   
                    btn[j, i] = new Button();
                    btn[j, i].Size = new Size(80, 80);
                    btn[j, i].Name = "-88";
                    btn[j, i].Click += new EventHandler(button_Click);
                    btn[j, i].Visible =rr;
                  
                    Controls.Add(btn[j, i]);
                    
                }
            }
            for (int i = 0; i < pp; i++)//將顯示出來的按鈕標上編號並排列整齊
            {
                for (int j = 0; j < pp; j++)
                {
                    if (btn[j, i].Visible)
                    {
                        btn[j, i].Name = u.ToString();
                        btn[j, i].Location = new Point(i * 80, (j * 80) + 35);
                        u++;
                    }



                }
            }

            for (int a = 0; a < cv/2; a++)//將前半段編號按鈕隨機選出圖片
            {
                c[a] = fff.Next(1, 151);
                for (int b = 0; b < a; b++)
                {
                    while (c[b] == c[a])
                    {
                        b = 0;
                        c[a] = fff.Next(1, 151);
                    }
                }
            }


            int v = 0;
            for (int a = cv/2; a < cv; a++)//將後半段的按鈕隨機根前半段的按鈕結合
            {
                v = fff.Next(0, cv/2);
                c[a] = c[v];
                for (int b = cv/2; b < a; b++)
                {
                    while (c[b] == c[a])
                    {
                        b =cv/2;
                        v = fff.Next(0, cv/2);
                        c[a] = c[v];
                    }
                }
            }



            int uu = 0;
            for (int a = 0; a <pp; a++)//將隨機好的圖片顯示出來
            {
                for (int b = 0; b <pp; b++)
                {
                    string n = "";
                    if (c[uu] < 10)
                    {
                        n = "00";
                    }
                    else if (c[uu] >= 10 && c[uu] < 100)
                    {
                        n = "0";
                    }
                    btn[b, a].Image = Image.FromFile("Resources\\" + n + c[uu] + ".png");

                    uu++;
                }
            }
            timer2.Enabled = true;//4秒之後將圖片消除
            timer2.Interval = 500;
           
            uy = true;          //開始計時
            if (sb> 0){
                timer1.Enabled = true; }
            uy = false;
            timer1.Interval = 1000;
            
           

        }
        int ss = 0;
        int sss = 0;
        int ssss = 3;
        int sb = 100;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sss++;
            ssss--;
            
            label4.Text = "記憶時間剩下" + ssss + "秒";
            string vv = cs1;
            if (sss >= 3 && vv =="2")
            {
                sb--;
                if(sb<0)
                {
                    timer1.Enabled = false;
                    MessageBox.Show("時間到，挑戰失敗");
                  
                    this.Close();
                    

                }
                label4.Text = "時間剩下" + sb + "秒";
                ss++;
            }
            else   if (sss >= 3&&vv!="2")
            {
                label4.Text = "時間已經經過了" + ss + "秒";
                ss++;
               
            }

            
        }

        int q = 0;//翻第一張牌或第二張牌的時候
        int w = -1;//儲存翻第一張牌的編號
        bool m = true;//按鈕只能按一次
        int tt = 0;
        int cc = 0;
        int bb = 0;
        private void button_Click(object sender, EventArgs e)//點擊之後會發生的事情
        {
            string vv = cs1;//遊戲模式


            if (ssss>-1)//在記憶時間到之前不准點擊
            {
                return;

            }
            if(((Button)sender).Name == "-1")//已經翻開的按鈕不准點擊
            {
                return;
            }
          
            string n = "";
            if(c[int.Parse(((Button)sender).Name)]<10)//加圖片文字
            {
                n = "00";
            }else if(c[int.Parse(((Button)sender).Name)]>=10 && c[int.Parse(((Button)sender).Name)]<100)
            {
                n = "0";
            }

            


            //  ((Button)sender).Image = Image.FromFile("Resources\\00" + c[int.Parse(((Button)sender).Name)] + ".png");
            q++;
            if (q == 1)//翻第一張牌
            {
                ((Button)sender).Image = Image.FromFile("Resources\\"+n + c[int.Parse(((Button)sender).Name)] + ".png");//將圖片顯示
                w = c[int.Parse(((Button)sender).Name)];//紀錄編號
               
                if (vv == "3")//第三遊戲模式
                {
                    cc = c[int.Parse(((Button)sender).Name)];
                }
                 ((Button)sender).Name = "-1";
                m = false;

            }

            if (q == 2)//翻第二張牌
            {


                if (w == c[int.Parse(((Button)sender).Name)])//如果對的話
                {

                    ((Button)sender).Image = Image.FromFile("Resources\\"+n + c[int.Parse(((Button)sender).Name)] + ".png");
                    int s = 0;
                    ((Button)sender).Visible= false;//將按鈕消失掉
                    tt++;
                    label2.Text = tt.ToString();//翻牌數+1
                    for (int a = 0; a <= pp; a++)//搜尋出上一個按的按鈕並消除
                    {
                        for (int b = 0; b <= pp; b++)
                        {


                            if (btn[b, a].Name == "-1")
                            {
                                btn[b, a].Name = s.ToString();
                                btn[b, a].Visible= false;
                                break;
                            }
                            s++;
                        }
                    }
                }
                else if (w != c[int.Parse(((Button)sender).Name)]) //如果錯的話
                {



                    int s = 0;
                    ((Button)sender).Image = Image.FromFile("Resources\\"+n + c[int.Parse(((Button)sender).Name)] + ".png");//顯示圖片
                    tt++;
                    label2.Text = tt.ToString();//翻牌數+1
                    ((Button)sender).Refresh();//暫停畫面
                    Thread.Sleep(400);

                    if (vv == "3")//第三遊戲模式
                    {
                        bb = c[int.Parse(((Button)sender).Name)];
                        c[int.Parse(((Button)sender).Name)] = cc;
                    }
                    for (int a = 0; a <pp; a++)//搜尋上一個按的按鈕把現在和上一個按鈕圖片消失
                    {
                        for (int b = 0; b <pp; b++)
                        {


                            if (btn[b, a].Name == "-1")
                            {
                               
                                Thread.Sleep(500);
                                btn[b, a].Name = s.ToString();
                                btn[b, a].Image = null;
                                ((Button)sender).Image = null;
                                if (vv == "3")
                                {
                                    c[int.Parse(btn[b, a].Name)] = bb;
                                }
                                break;
                            }
                            s++;
                        }
                    }

                }
                w = -1;
                q = 0;

            }


            int v = 0;

            for (int a = 0; a <= btn.GetUpperBound(0); a++)//消失的按鈕紀錄
            {
                for (int b = 0; b <= btn.GetUpperBound(1); b++)
                {


                    if (btn[a, b].Visible == false)
                    {
                        v++;
                    }
                    else if (btn[a, b].Visible== true)
                    {
                        v = 0;
                        break;
                    }



                }
            }

            if (v == 400)//按鈕全部消失時
            {
                timer1.Enabled = false;
                MessageBox.Show("你花了"+ss+"秒，翻了"+label2.Text+"次牌，過關！！");
                Application.ExitThread();
                Restart();
            }
            //    MessageBox.Show(((Button)sender).Name.ToString());


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (sss == 4)//記憶時間過了之後消掉圖案
            {
                for (int a = 0; a <= btn.GetUpperBound(0); a++)
                {
                    for (int b = 0; b <= btn.GetUpperBound(1); b++)
                    {
                        btn[b, a].Image = null;
                    }
                }
                timer2.Enabled = false;
            }
        }

        private void 遊戲結束ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
            Restart();
        }

        private void 關於ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("本遊戲由\n林冠廷單獨製作\n4TM1070036\n要關閉遊戲請按旁邊的遊戲選項");
           
        }
    }
}
