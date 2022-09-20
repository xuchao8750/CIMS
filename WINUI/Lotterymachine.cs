
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WINUI
{
    public partial class Lotterymachine : DevExpress.XtraEditors.XtraForm
    {
        Random Random = new Random();
        CancellationTokenSource cancellationTokenSource = null;
        public Lotterymachine()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            cancellationTokenSource = new CancellationTokenSource();
            if (this.simpleButton1.Text == "开  始")
            {
                this.simpleButton1.Text = "停  止";
                Task task = Task.Factory.StartNew(GO, cancellationTokenSource.Token);
            }
            else
            {
                this.simpleButton1.Text = "开  始";
                cancellationTokenSource.Cancel();
            }
        }

        void GO()
        {
            while (!cancellationTokenSource.IsCancellationRequested)
            {
                labelControl1.Text = Random.Next(01, 33).ToString();
                labelControl2.Text = Random.Next(01, 33).ToString();
                labelControl3.Text = Random.Next(01, 33).ToString();
                labelControl4.Text = Random.Next(01, 33).ToString();
                labelControl5.Text = Random.Next(01, 33).ToString();
                labelControl6.Text = Random.Next(01, 33).ToString();
                labelControl7.Text = Random.Next(01, 16).ToString();
                dlt1.Text = Random.Next(01, 35).ToString();
                dlt2.Text = Random.Next(01, 35).ToString();
                dlt3.Text = Random.Next(01, 35).ToString();
                dlt4.Text = Random.Next(01, 35).ToString();
                dlt5.Text = Random.Next(01, 35).ToString();
                dlt6.Text = Random.Next(01, 12).ToString();
                dlt7.Text = Random.Next(01, 12).ToString();
                D1.Text = Random.Next(01, 09).ToString();
                D2.Text = Random.Next(01, 09).ToString();
                D3.Text = Random.Next(01, 09).ToString();

            }
        }

        private void Lotterymachine_Load(object sender, EventArgs e)
        {

        }
    }
}