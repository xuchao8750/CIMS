using Common;
using System;
using System.Windows.Forms;

namespace WINUI
{
    public partial class Encryption_and_decryption : DevExpress.XtraEditors.XtraForm
    {
        public Encryption_and_decryption()
        {
            InitializeComponent();
        }
        #region 生成GUID事件
        private void btnGenerateGUID_Click(object sender, EventArgs e)
        {
            this.txtGUID.Clear();
            if (chkX2.Checked == true)
            {
                for (int i = 0; i < this.numericUpDownGUID.Value; i++)
                {
                    this.txtGUID.Text += Guid.NewGuid().ToString("N") + "\r\n";
                }
            }
            else
            {
                for (int i = 0; i < this.numericUpDownGUID.Value; i++)
                {
                    this.txtGUID.Text += Guid.NewGuid().ToString() + "\r\n";
                }
            }
        }

        #endregion

        #region 生成MD5事件
        private void btnGenerateMD5_Click(object sender, EventArgs e)
        {
            this.txtMD5X.Text = new Encryptions().GetMD5X(this.txtStrForMD5.Text);
            this.txtMD5X2.Text = new Encryptions().GetMD5X2(this.txtStrForMD5.Text);
        }
        #endregion

        #region 复制MD5值
        private void btnCopyMD5X_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(this.txtMD5X.Text);
        }

        private void btnCopyMD5X2_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(this.txtMD5X2.Text);
        }

        #endregion

        #region DES加密事件
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (this.txtStr.Text.Length == 0)
            {
                MessageBox.Show("请输入明文！");
                this.txtStr.Focus();
                return;
            }
            if (this.txtKey.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入密钥！");
                this.txtKey.Focus();
                return;
            }
            if (this.txtVI.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入向量！");
                this.txtVI.Focus();
                return;
            }
            try
            {
                this.txtDES.Text = new Encryptions().DESEncrypt(this.txtStr.Text, this.txtKey.Text, this.txtVI.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region DES解密事件
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (this.txtKey.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入密钥！");
                this.txtKey.Focus();
                return;
            }
            if (this.txtVI.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入向量！");
                this.txtVI.Focus();
                return;
            }
            if (this.txtDES.Text.Length == 0)
            {
                MessageBox.Show("请输入密文！");
                this.txtDES.Focus();
                return;
            }
            try
            {
                this.txtStr.Text = new Encryptions().DESDecrypt(this.txtDES.Text, this.txtKey.Text, this.txtVI.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region DES复制事件
        private void btnCopyStr_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(this.txtStr.Text);
        }

        private void btnCopyDES_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(this.txtDES.Text);
        }
        #endregion
    }
}