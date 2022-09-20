using BLL;
using Common;
using Models;
using System;
using System.Windows.Forms;
namespace WINUI
{
    public partial class ChangePwd : DevExpress.XtraEditors.XtraForm
    {
        public ChangePwd()
        {
            InitializeComponent();
        }

        #region 取消事件
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 修改密码事件
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //非空验证
            if (this.Oldpwd.Text.Length == 0)
            {
                MessageBox.Show("请输入旧密码", "修改密码");
                this.Oldpwd.Focus();
                return;
            }
            if (this.Newpwd.Text.Length == 0)
            {
                MessageBox.Show("请输入新密码", "修改密码");
                this.Newpwd.Focus();
                return;
            }
            if (this.Newpwd.Text.Length < 8)
            {
                MessageBox.Show("密码长度不符合要求，请重新输入", "修改密码");
                this.Newpwd.Focus();
                return;
            }
            if (this.Confirmpwd.Text != this.Newpwd.Text)
            {
                MessageBox.Show("请两次输入的密码不一致，请检查后从新输入", "修改密码");
                return;
            }
            //验证用户旧密码
            if (new Encryptions().GetMD5X2(this.Oldpwd.Text) != Program.Automatic.BaseUserPwd)
            {
                MessageBox.Show("您输入旧密码不正确", "修改密码");
                this.Oldpwd.Focus();
                this.Oldpwd.SelectAll();
                return;
            }
            //提交数据
            try
            {
                BaseUserEx BaseUser = new BaseUserEx()
                {
                    BaseUserPwd = new Encryptions().GetMD5X2(this.Newpwd.Text),
                    BaseUserGUID = Program.Automatic.BaseUserGUID,
                };
                int RE = new BaseUserManager().ChangePwd(BaseUser);
                if (RE == 1)
                {
                    MessageBox.Show("密码修改成功，请重新登录", "修改密码", MessageBoxButtons.OK);
                    Program.Automatic.BaseUserPwd = new Encryptions().GetMD5X2(this.Newpwd.Text);
                    this.Close();
                }
                this.DialogResult = DialogResult.OK;
                if (DialogResult == DialogResult.OK)
                {
                    Application.Restart();
                    FrmLogin longding = new FrmLogin();
                    longding.Show();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}