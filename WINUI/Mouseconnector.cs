using Common;
using System;
using System.Threading;
using System.Windows.Forms;

namespace WINUI
{
    public partial class Mouseconnector : DevExpress.XtraEditors.XtraForm
    {
        private const int WM_HOTKEY = 0x312; //窗口消息-热键
        private const int WM_CREATE = 0x1; //窗口消息-创建
        private const int WM_DESTROY = 0x2; //窗口消息-销毁
        private const int F11 = 0x3572; //热键ID
        private const int F12 = 0x3573; //热键ID

        private bool _state = true;
        private Thread th_Click;
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            switch (m.Msg)
            {
                case WM_HOTKEY: //窗口消息-热键ID
                    switch (m.WParam.ToInt32())
                    {
                        case F11: //热键ID
                            //MessageBox.Show("我按了Control +Shift +Alt +F11");
                            btnStart.PerformClick();
                            break;
                        case F12: //热键ID
                            //MessageBox.Show("我按了Control +Shift +Alt +F12");
                            btnStop.PerformClick();
                            break;
                        default:
                            break;
                    }
                    break;
                case WM_CREATE: //窗口消息-创建
                    //AppHotKey.RegKey(Handle, F11, AppHotKey.KeyModifiers.Ctrl | AppHotKey.KeyModifiers.Shift | AppHotKey.KeyModifiers.Alt, Keys.F11);
                    //AppHotKey.RegKey(Handle, F12, AppHotKey.KeyModifiers.Ctrl | AppHotKey.KeyModifiers.Shift | AppHotKey.KeyModifiers.Alt, Keys.F12);
                    AppHotKey.RegKey(Handle, F11, AppHotKey.KeyModifiers.Ctrl | AppHotKey.KeyModifiers.Shift | AppHotKey.KeyModifiers.Alt, Keys.F11);
                    AppHotKey.RegKey(Handle, F12, AppHotKey.KeyModifiers.Ctrl | AppHotKey.KeyModifiers.Shift | AppHotKey.KeyModifiers.Alt, Keys.F12);
                    break;
                case WM_DESTROY: //窗口消息-销毁
                    AppHotKey.UnRegKey(Handle, F11); //销毁热键
                    AppHotKey.UnRegKey(Handle, F12); //销毁热键
                    break;
                default:
                    break;
            }
        }
        public Mouseconnector()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        void DoClick()
        {
            while (_state)
            {
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            }
        }
        int num = 0;
        private void timerClick_Tick(object sender, EventArgs e)
        {
            MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timerClick.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timerClick.Stop();
        }
    }
}