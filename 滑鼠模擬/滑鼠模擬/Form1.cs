using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.Diagnostics;
namespace 滑鼠模擬
{
    public partial class Form1 : Form
    {
        const int WH_KEYBOARD_LL = 13;
        static int global_X;
        static int global_Y;
        static int mouse_velocity;
        enum MouseEventFlag : uint
        {
            Move = 0x0001,
            LeftDown = 0x0002,
            LeftUp = 0x0004,
            RightDown = 0x0008,
            RightUp = 0x0010,
            MiddleDown = 0x0020,
            MiddleUp = 0x0040,
            XDown = 0x0080,
            XUp = 0x0100,
            Wheel = 0x0800,
            VirtualDesk = 0x4000,
            Absolute = 0x8000
        }
        public delegate int HookProc(int nCode, Int32 wParam, IntPtr lParam);
        static int m_HookHandle = 0;
        HookProc m_KbdHookProc;
        // 安装钩子
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hInstance, int threadId);
        // 卸载钩子
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern bool UnhookWindowsHookEx(int idHook);
        // 继续下一个钩子
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern int CallNextHookEx(int idHook, int nCode, Int32 wParam, IntPtr lParam);
        //
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);
        [DllImport("user32.dll")] //替換成所需的DLL檔
        static extern bool SetCursorPos(int X, int Y);
        [DllImport("user32.dll")]
        static extern void mouse_event(MouseEventFlag flag, int dx, int dy, uint data, UIntPtr extraInfo);
        public Form1()
        {
            InitializeComponent();
            global_X = System.Windows.Forms.Cursor.Position.X;
            global_Y = System.Windows.Forms.Cursor.Position.Y;
            mouse_velocity = int.Parse(textBox1.Text);
        }
        private void Click_Click(object sender, EventArgs e)
        {
            if (m_HookHandle == 0)
            {
                using (Process curProcess = Process.GetCurrentProcess())
                {
                    using (ProcessModule curmodule = curProcess.MainModule)
                    {
                        m_KbdHookProc = new HookProc(Form1.hookproc);
                        m_HookHandle = SetWindowsHookEx(WH_KEYBOARD_LL, m_KbdHookProc, GetModuleHandle(curmodule.ModuleName), 0);
                    }
                }
                if (m_HookHandle == 0)
                {
                    MessageBox.Show(" HOOK 失敗!");
                    return;
                }
                MessageBox.Show("建立Hook成功");
                click.Text = "虛擬左右鍵 停止";
            }
            else
            {
                bool ret = UnhookWindowsHookEx(m_HookHandle);
                if (ret == false)
                {
                    MessageBox.Show("關閉 Hook 失敗!");
                    return;
                }
                m_HookHandle = 0;
                MessageBox.Show("解除Hook成功");
                click.Text = "虛擬左右鍵 開始";
            }
        }
        
        static int hookproc(int nCode, Int32 wParam, IntPtr lParam)
        {
            global_X = System.Windows.Forms.Cursor.Position.X;
            global_Y = System.Windows.Forms.Cursor.Position.Y;
            const int delay = 200;
            // 當按鍵按下及鬆開時都會觸發此函式，這裡只處理鍵盤按下的情形。
            bool isPressed = (lParam.ToInt32() & 0x80000000) == 0;
            if (nCode < 0 || !isPressed)
            {
               return CallNextHookEx(m_HookHandle, nCode, wParam, lParam);
            }
            // 取得欲攔截之按鍵狀態
            KeyStateInfo LKey = KeyboardInfo.GetKeyState(Keys.Left);
            KeyStateInfo RKey = KeyboardInfo.GetKeyState(Keys.Right);
            KeyStateInfo MKey = KeyboardInfo.GetKeyState(Keys.Up);
            KeyStateInfo DKey = KeyboardInfo.GetKeyState(Keys.Down);
            KeyStateInfo WKey = KeyboardInfo.GetKeyState(Keys.W);
            KeyStateInfo AKey = KeyboardInfo.GetKeyState(Keys.A);
            KeyStateInfo SKey = KeyboardInfo.GetKeyState(Keys.S);
            KeyStateInfo DLKey = KeyboardInfo.GetKeyState(Keys.D);
            if (LKey.IsPressed)
            {
                Thread.Sleep(delay);
                mouse_event(MouseEventFlag.LeftDown, 0, 0, 0, UIntPtr.Zero);
                mouse_event(MouseEventFlag.LeftUp, 0, 0, 0, UIntPtr.Zero);
            }
            if (RKey.IsPressed)
            {
                Thread.Sleep(delay);
                mouse_event(MouseEventFlag.RightDown, 0, 0, 0, UIntPtr.Zero);
                mouse_event(MouseEventFlag.RightUp, 0, 0, 0, UIntPtr.Zero);
            }
            if (MKey.IsPressed)
            {
                Thread.Sleep(delay);
                mouse_event(MouseEventFlag.MiddleDown, 0, 0, 0, UIntPtr.Zero);
                mouse_event(MouseEventFlag.MiddleUp, 0, 0, 0, UIntPtr.Zero);
            }
            if (DKey.IsPressed)
            {
                Thread.Sleep(2*delay);
                mouse_event(MouseEventFlag.LeftDown, 0, 0, 0, UIntPtr.Zero);
            }
            
            
                //if (WKey.IsPressed)
                //{
                //    SetCursorPos(global_X, global_Y - mouse_velocity);
                //}
                //if (AKey.IsPressed)
                //{
                //    SetCursorPos(global_X - mouse_velocity, global_Y);
                //}
                //if (SKey.IsPressed)
                //{
                //    SetCursorPos(global_X, global_Y + mouse_velocity);
                //}
                //if (DLKey.IsPressed)
                //{
                //    SetCursorPos(global_X + mouse_velocity, global_Y);
                //}
            

            return CallNextHookEx(m_HookHandle, nCode, wParam, lParam);
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try { mouse_velocity = int.Parse(textBox1.Text); }
            catch
            {
                MessageBox.Show("格子要填int");
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            mouse_x.Text = System.Windows.Forms.Cursor.Position.X.ToString();
            mouse_y.Text = System.Windows.Forms.Cursor.Position.Y.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string input;
            input = script.Text;
            string[] list = input.Split('\n');
            for(int i = 0; i < list.Length; i++)
            {
                string[] inside = list[i].Split(' ');
                if(inside[0] == "move")
                {
                    SetCursorPos(int.Parse(inside[1]), int.Parse(inside[2]));
                }
                else if(inside[0] == "wait")
                {
                    Thread.Sleep(int.Parse(inside[1])*1000*60);
                }
                else if(inside[0] == "click")
                {
                    Thread.Sleep(200);
                    mouse_event(MouseEventFlag.LeftDown, 0, 0, 0, UIntPtr.Zero);
                    mouse_event(MouseEventFlag.LeftUp, 0, 0, 0, UIntPtr.Zero);
                }
            }
        }
    }
    public class KeyboardInfo
    {
        private KeyboardInfo() { }
        [DllImport("user32")]
        //GetKeyState為核心API 向windows要求鍵盤狀態以數值輸出 放入案鍵編號 若輸出 > 0 表示已按下
        //要轉high low 值得知意義  -> high = 1 表示被按下 -> low = 1 表示被觸發  *轉換可直接抄
        //https://baike.baidu.com/item/GetKeyState
        private static extern short GetKeyState(int vKey);
        public static KeyStateInfo GetKeyState(Keys key)
        {
            int vkey = (int)key;
            short keyState = GetKeyState(vkey);
            int low = Low(keyState);
            int high = High(keyState);
            bool toggled = (low == 1);
            bool pressed = (high == 1);
            return new KeyStateInfo(key, pressed, toggled);
        }
        private static int High(int keyState)
        {
            if (keyState > 0)
            {
                return keyState >> 0x10;
            }
            else
            {
                return (keyState >> 0x10) & 0x1;
            }
        }
        private static int Low(int keyState)
        {
            return keyState & 0xffff;
        }
    }
    public struct KeyStateInfo
    {
        //只是一個儲存一個按鍵 按下 觸發 狀態的結構
        Keys m_Key;
        bool m_IsPressed;
        bool m_IsToggled;
        public KeyStateInfo(Keys key, bool ispressed, bool istoggled)
        {
            m_Key = key;
            m_IsPressed = ispressed;
            m_IsToggled = istoggled;
        }
        public static KeyStateInfo Default
        {
            get
            {
                return new KeyStateInfo(Keys.None, false, false);
            }
        }
        public Keys Key
        {
            get { return m_Key; }
        }
        public bool IsPressed
        {
            get { return m_IsPressed; }
        }
        public bool IsToggled
        {
            get { return m_IsToggled; }
        }
    }
}
