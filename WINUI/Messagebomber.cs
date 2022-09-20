using System;
using System.Threading;
using System.Windows.Forms;

namespace WINUI
{
    public partial class Messagebomber : DevExpress.XtraEditors.XtraForm
    {
        public Messagebomber()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread.Sleep(3000);
            int a = Convert.ToInt32(textBox2.Text);
            string b = textBox1.Text;
            for (int i = 1; i <= a; i++)
            {
                Clipboard.Clear();
                Clipboard.SetText(b);
                SendKeys.Send("^V");
                SendKeys.Send("%S");
            }
        }

        private void Messagebomber_Load(object sender, EventArgs e)
        {
            MessageBox.Show("目前布谷鸟不能用，正在修复中");
        }
    }
}