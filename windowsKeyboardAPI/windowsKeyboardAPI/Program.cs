using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Threading;
using System.IO.Ports;

namespace windowsKeyboardAPI
{
    class keyboard
    {
        //提供method按下鍵盤
        /***********
         * import dll needed in windowAPI
        VOID keybd_event(
　　  BYTE bVk, // virtual-key code 大寫英文ASC2(65~90) code, 其餘案件可自行查詢
　　  BYTE bScan, // hardware scan code  掃描碼預設為0
　　  DWORD dwFlags, // flags specifying various function options keydown用0表示,2表示up
　　  DWORD dwExtraInfo // additional data associated with keystroke 額外訊息預設為零
　　);
         * **********/
        //[DllImport("user32.dll")]
        //private static extern int MessageBox(IntPtr hWnd, String text, String caption, uint type);

        //public static void Show(string message, string caption)
        //{
        //    MessageBox(new IntPtr(0), message, caption, 0);
        //}

        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);
        public static void press(byte keycode)
        {
            /*********
            keycode example: 'A','W','S','D','J','F'
             * **********/
            keybd_event((byte)keycode, 0, 0, 0);
            keybd_event((byte)keycode, 0, 2, 0);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //串口通訊setting
            SerialPort myport = new SerialPort();
            myport.BaudRate = 9600; //需跟arduno設定的一樣
            myport.PortName = "COM5"; //指定PortName 
            myport.Open();
            Console.WriteLine("start read");
            //在Yun這塊板子中，一定要加上這行來啟用DTR訊號；其他板子不一定需要。 
            myport.DtrEnable = true;

            //開始讀值
            while (true)
            {
                //讀取port傳入, 假設輸入為字串內容為按鈕的ASC2
                string data = myport.ReadLine();
                Console.WriteLine(data);
                int num = Int32.Parse(data);
                //把輸入做轉換,觸發鍵盤事件
                keyboard.press((byte)Convert.ToChar(num));
                //Thread.Sleep(1000);
            }
        }
    }
}
