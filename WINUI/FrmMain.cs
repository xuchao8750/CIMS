using Common;
using System.Linq;
using System.Windows.Forms;

namespace WINUI
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private 系统配置 配置 = new 系统配置();

        #region 权限简单判断
        void Qx()
        {
            if (Program.Automatic.ObjGrouping.GroupingName == "技术组")
            {
                EncryPtion.Enabled = false;
                Deletedatabase.Enabled = false;
                Deletedata.Enabled = false;
                Wipedata.Enabled = false;
            }
        }

        #endregion

        #region  底部状态栏初始化
        void Init()
        {
            UserName.Caption = $"用户名：{Program.Automatic.BaseUserName}";
            name.Caption = $"姓 名：{Program.Automatic.RealName}";
            GroupingName.Caption = $"分 组：{Program.Automatic.ObjGrouping.GroupingName}";
        }
        #endregion

        #region 窗体加载事件
        public FrmMain()
        {
            InitializeComponent();
            Init();
            Qx();
        }
        private void FrmMain_Load(object sender, System.EventArgs e)
        {
            配置.配置类型(ribbon);
            配置.导航设置(导航菜单);//调用导航栏设置
            配置.导航栏1(导航栏);//调用导航栏方法
            配置.子窗体顶部状态栏(计算窗体);
        }

        #endregion

        #region 创建子窗体的方法
        void 窗体传递(Form form)
        {
            if (!检测窗体(form))
            {
                form.MdiParent = this;
                form.Show();
            }


        }
        bool 检测窗体(Form form)
        {
            bool isOpened = false;
            if (MdiChildren.Count() > 0)
            {
                foreach (var item in MdiChildren)
                {
                    if (form.Name == item.Name)
                    {
                        计算窗体.Pages[item].MdiChild.Activate(); //如果这个窗体存在那么就激活这个窗体
                        isOpened = true;
                    }
                }
            }
            return isOpened;

        }
        #endregion

        #region 关闭窗体事件
        private void FrmMain_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if (MessageBox.Show("确定要退出本系统吗", "系统退出", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        #endregion 

        #region 顶部任务栏事件
        private void ribbon_Merge(object sender, DevExpress.XtraBars.Ribbon.RibbonMergeEventArgs e)
        {
            this.Ribbon.SelectedPage = this.ribbon.MergedPages[0];
        }
        #endregion

        #region 打开加密解密
        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Encryption_and_decryption encryption_And_Decryption = new Encryption_and_decryption();
            encryption_And_Decryption.ShowDialog();
        }
        #endregion

        #region 切换账号事件
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Restart();
            FrmLogin longding = new FrmLogin();
            longding.Show();
        }
        #endregion

        #region 关于事件
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        #endregion

        #region 帮助事件
        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        #endregion

        #region 修改密码事件
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChangePwd changePwd = new ChangePwd();
            changePwd.ShowDialog();
        }
        #endregion

        #region 打开窗体事件
        private void 人员基础信息_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Personnelinformation personnelinformation = new Personnelinformation();
            窗体传递(personnelinformation);
        }
        private void barButtonItem6_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Mouseconnector mouseconnector = new Mouseconnector();
            mouseconnector.ShowDialog();
        }
        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Messagebomber messagebomber = new Messagebomber();
            messagebomber.ShowDialog();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Lotterymachine lotterymachine = new Lotterymachine();
            lotterymachine.ShowDialog();
        }

        private void navBarItem9_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Tbl_InspectionsummaryForm1 tbl_InspectionsummaryForm1 = new Tbl_InspectionsummaryForm1();
            窗体传递(tbl_InspectionsummaryForm1);
        }
        #endregion


    }
}