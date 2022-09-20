using Common;
using System.Windows.Forms;

namespace WINUI
{
    public partial class Personnelinformation : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private 系统配置 配置 = new 系统配置();
        private static Personnelinformation _Personnelinformation = null;
        public Personnelinformation()
        {
            InitializeComponent();
        }

        #region 打开窗体事件
        public static Personnelinformation personnelinformation()
        {
            if (_Personnelinformation is null)
            {
                _Personnelinformation = new Personnelinformation();
            }
            return _Personnelinformation;
        }
        #endregion

        #region 退出窗体事件
        private void Personnelinformation_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Personnelinformation = null;
        }
        #endregion
    }
}