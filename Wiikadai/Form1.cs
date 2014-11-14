//オリジナル課題　Wiiリモコンを振って音を出す
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WiimoteLib;    //WimoteLib

namespace Wiikadai
{

    public partial class Form1 : Form
    {

        Wiimote wm = new Wiimote();                    //Wiimoteの宣言

        public Form1()
        {
            InitializeComponent();
            wm.WiimoteChanged += wm_WiimoteChanged;    //イベント関数の登録
            wm.Connect();                            //Wiimoteの接続
        }

        //Wiiリモコンの値が変化したときに呼ばれる関数
        void wm_WiimoteChanged(object sender, WiimoteChangedEventArgs args)
        {
            WiimoteState ws = args.WiimoteState;      //WiimoteStateの値を取得
            if (ws.AccelState.Values.X > 1)　//上から下に少し強めに振ったときの条件
            {

                if (ws.ButtonState.A == true)//ド
                {
                    Console.Beep(440, 700);

                }

                if (ws.ButtonState.B == true)//レ
                {
                    Console.Beep(494, 700);
                }

                if (ws.ButtonState.Minus == true)//ミ
                {
                    Console.Beep(554, 700);
                }

                if (ws.ButtonState.Plus == true)//ファ
                {
                    Console.Beep(587, 700);
                }

                if (ws.ButtonState.Left == true)//ソ
                {
                    Console.Beep(659, 700);
                }

                if (ws.ButtonState.Up == true)//ラ
                {
                    Console.Beep(740, 700);
                }

                if (ws.ButtonState.Right == true)//シ
                {
                    Console.Beep(830, 700);
                }

                if (ws.ButtonState.Down == true)//ド
                {
                    Console.Beep(880, 700);
                }
            }
        }
    }

}