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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label2.Text = "右下角的喇叭圖案點下去可以開啟背景音樂\n遊戲進行中要關閉遊戲請點選左上角的遊戲選項";
            label5.Text = "進入遊戲後，會有４秒的時間讓玩家記憶相同的圖案\n，四秒過後，圖案會全部消失，遊戲正式開始\n\n遊戲開始後，玩家需要將剛剛記憶下來的相同圖案\n位置點開，點開的兩個圖案正確的會方塊會消失，\n如果錯誤畫在方塊上的圖案消失，玩家繼\n續尋找相同圖案的方塊\n\n當方塊全部消失，則遊戲結束";
            button3.Visible = false;
            



        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "~~~備註~~~";
            label2.Text = "右下角的喇叭圖案點下去可以開啟背景音樂\n遊戲進行中要關閉遊戲請點選左上角的遊戲選項";
            label3.Text = "~~~備註~~~";
            label4.Text = "寶可夢消消樂遊戲規則";
            label5.Text = "進入遊戲後，會有４秒的時間讓玩家記憶相同的圖案\n，四秒過後，圖案會全部消失，遊戲正式開始\n\n遊戲開始後，玩家需要將剛剛記憶下來的相同圖案\n位置點開，點開的兩個圖案正確的會方塊會消失，\n如果錯誤畫在方塊上的圖案消失，玩家繼\n續尋找相同圖案的方塊\n\n當方塊全部消失，則遊戲結束";
            button2.Visible = true;
            button3.Visible = false;
            this.Close();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "設定";
            label2.Text = "遊戲有三種模式，可以在設定選項中進行調整，預設\n模式是４*4不限時間的方塊自訂義模式：\n自訂義模式可以自己定義方塊的多寡，只能輸入\n１－１４的數字，如果輸入的數字是奇數則自動＋１\n\n１００秒挑戰模式：\n在１００秒內必須要消除６＊６個方塊，否則算失敗\n\n地獄模式：\n不限時間，在８＊８的方塊陣中如果選錯方塊，除了\n方塊中的圖案消失之外兩個方塊的圖案也會相互交換\n位置\n\n過關條件所有方塊全部消失\n";
            button2.Visible = false;
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            button3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "~~~備註~~~";
            label2.Text = "右下角的喇叭圖案點下去可以開啟背景音樂\n遊戲進行中要關閉遊戲請點選左上角的遊戲選項";
            label3.Text = "~~~備註~~~";
            label4.Text = "寶可夢消消樂遊戲規則";
            label5.Text = "進入遊戲後，會有４秒的時間讓玩家記憶相同的圖案\n，四秒過後，圖案會全部消失，遊戲正式開始\n\n遊戲開始後，玩家需要將剛剛記憶下來的相同圖案\n位置點開，點開的兩個圖案正確的會方塊會消失，\n如果錯誤畫在方塊上的圖案消失，玩家繼\n續尋找相同圖案的方塊\n\n當方塊全部消失，則遊戲結束";
            button2.Visible = true;
            button3.Visible = false;
        }
    }
}
