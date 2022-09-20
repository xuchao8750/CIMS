using BLL;
using Common;
using Microsoft.Win32.SafeHandles;
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
                //这里集合就是序列化文件了  对啊  不知道为啥不对   
                automatics = (List<Automatic>)serializeObject.Dsofl("User.obj");  //dengxa 
                Console.WriteLine("31__" + automatics.Count);
                MessageBox.Show("32__" + automatics.Count);
                foreach (var item in automatics)
                {
                    this.用户名.Properties.Items.Add(item.BaseUserName);   // 反序列化  又给他了 
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
                //还是这一块的逻辑，再花点时间  我在看看吧    他逻辑  就是登录的时候 看下系列化文件里有没有这个   
                //这里用automatics.Add(uSER2)比较危险，容易重复，序列化是没问题的，问题是他序列化的时候有没有判断重复，在这里做重复判断是没用的  
                //第一次运行时，automatic is null,没有进行循环
                //automatics.Add(uSER2);    //注释掉 新用户不进去了 我感觉问题就是这里了   他应该就在这里了吧  实例化完成后添加到集合里  集合在这里遍历  也不对啊    操蛋
                /*
                 *   序列化  serializeObject.eotl("User.obj", automatics);  是这句   我在这句之前判断 应该都是有效的   
                 *   这里相当于是一个变量，变量自己做了重复判断，但是序列化本地的时候，就重复了
                 *   先把
                 *   
                 *   我的 那个是这样的 
                 * if (this.checkEdit1.Checked == true)
                {
                    foreach (var item in automatics)  // 在这遍历下这个集合    我其实在想  这是不是也有问题   应该去遍历序列化文件  而不是那个集合 
                    {
                        if (item.BaseUserName == this.用户名.Text)   //如果序列化文件里的用户名 和这个一样  
                        {
                            break;   那就跳出
                        }
                        else   //否则就序列化    但是这样也不行
                        {
                            serializeObject.eotl("User.obj", automatics); //序列化到本地  
                        }
                    }
                     
                }
                 * 直接 4个    
                 */
                for (int i = 0; i < automatics.Count; i++)
                {
                    Console.WriteLine(automatics[i].BaseUserName);
                    Console.WriteLine(用户名.Text.Trim());    //  875062   875062 
                    //先判断automatic中是否有用户名  我已经看不懂了
                    if (automatics[i].BaseUserName.Contains(用户名.Text.Trim()))
                    {
                        break;
                    }
                    //automatics.Add(uSER2);
                    if (automatics[i].BaseUserName != 用户名.Text.Trim())
                    {
                        Console.WriteLine(automatics[i].BaseUserName);
                        Console.WriteLine(用户名.Text.Trim());    //  875062   875062 
                        //移除后，可能更不就不存在了
                        //automatics.Remove(automatics[i]);     //把他移除掉也行 移除掉  他登录的时候 又执行了 序列化啊    没序列化
                        //break;
                        automatics.Add(uSER2);
                    }
                }
                if (automatics.Count==0)
                {

                }
                automatics.Add(uSER2);

                MessageBox.Show("168__" + automatics.Count);
                Console.WriteLine(automatics.Count);
                serializeObject.eotl("User.obj", automatics); //序列化到本地   // 问题绝对在这    他每次都序列化了 
                if (this.checkEdit1.Checked == true)
                {
                    for (int i = 0; i < automatics.Count; i++)
                    {
                        Console.WriteLine(automatics[i].BaseUserName);
                        Console.WriteLine(用户名.Text.Trim());    //  875062   875062 
                                                               //先判断automatic中是否有用户名  我已经看不懂了
                        if (automatics[i].BaseUserName.Contains(用户名.Text.Trim()))
                        {
                            break;
                        }
                        //automatics.Add(uSER2);
                        if (automatics[i].BaseUserName != 用户名.Text.Trim())
                        {
                            Console.WriteLine(automatics[i].BaseUserName);
                            Console.WriteLine(用户名.Text.Trim());  
                            automatics.Add(uSER2);
                        }
                    }
                    if (automatics.Count == 0)
                    {

                    }
                    automatics.Add(uSER2);
                    serializeObject.eotl("User.obj", automatics); //序列化到本地   // 问题绝对在这    他每次都序列化了 
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