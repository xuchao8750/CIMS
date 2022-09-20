using BLL;
using Common;
using Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;


namespace WINUI
{
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        private SerializeObject serializeObject = new SerializeObject(); //实例化序列化方法
        private List<Automatic> automatics = new List<Automatic>();
        #region 窗体加载事件
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            #region  反序列化
            if (File.Exists("User.obj"))
            {
                this.checkEdit1.Checked = true;
                automatics = (List<Automatic>)serializeObject.Dsofl("User.obj");
                foreach (var item in automatics)
                {
                    this.用户名.Properties.Items.Add(item.BaseUserName);
                    if (用户名.Properties.Items.Count > 0)
                    {
                        用户名.SelectedIndex = 用户名.Properties.Items.Count - 1;
                    }
                    if (this.用户名.Text == item.BaseUserName)
                    {
                        this.密码.Text = item.BaseUserPwd;
                    }
                }
            }

            #endregion

            #region 自动登录事件
            //if (this.checkEdit2.Checked == true)
            //{
            //    Automatic uSER = new Automatic()
            //    {
            //        BaseUserName = this.用户名.Text.Trim(),
            //        BaseUserPwd = new Encryptions().GetMD5X2(this.密码.Text),
            //        MyProperty = this.checkEdit2.Checked
            //    };
            //    Automatic uSER2 = new Automatic()
            //    {
            //        BaseUserName = this.用户名.Text.Trim(),
            //        BaseUserPwd = this.密码.Text,
            //        MyProperty = this.checkEdit2.Checked
            //    };
            //    try
            //    {
            //        Program.Automatic = new BaseUserManager().UserLogin(uSER);
            //        if (Program.Automatic is null)
            //        {
            //            MessageBox.Show("用户名或密码不正确！", "用户登录");
            //            return;
            //        }
            //        this.DialogResult = DialogResult.OK;
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //}
            #endregion
        }

        #endregion

        #region 登录事件
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //非空验证
            if (this.用户名.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(this.用户名, "请输入用户名");
                return;
            }
            if (this.密码.Text.Length == 0)
            {
                errorProvider1.SetError(this.密码, "请输入密码");
                return;
            }

            //封装对象
            Automatic uSER = new Automatic()
            {
                BaseUserName = this.用户名.Text.Trim(),
                BaseUserPwd = new Encryptions().GetMD5X2(this.密码.Text),
                MyProperty = this.checkEdit2.Checked

            };
            try
            {
                Program.Automatic = new BaseUserManager().UserLogin(uSER);
                if (Program.Automatic is null)
                {
                    MessageBox.Show("用户名或密码不正确！", "用户登录");
                    return;
                }
                Automatic uSER2 = new Automatic()
                {
                    BaseUserName = this.用户名.Text.Trim(),
                    BaseUserPwd = this.密码.Text,

                };
                automatics.Add(uSER2);
                if (this.checkEdit1.Checked == true)
                {
                    foreach (var item in automatics)
                    {
                        if (item.BaseUserName == this.用户名.Text)
                        {
                            automatics.Add(uSER2);
                            break;
                        }
                        }
                        else
                        {
                            serializeObject.eotl("User.obj", automatics); //序列化到本地 
                        }
                    }
                    
                }
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //提交数据验证

        }

        #endregion

        #region 退出事件
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 注册事件
        private void 注册_Click(object sender, EventArgs e)
        {

        }

        #endregion

    }
}