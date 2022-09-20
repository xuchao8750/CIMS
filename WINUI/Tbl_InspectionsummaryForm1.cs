using System;
using Models;
using BLL;
using Common;

namespace WINUI
{
    public partial class Tbl_InspectionsummaryForm1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private 系统配置 配置 = new 系统配置(); //实例化系统配置
        private static Tbl_InspectionsummaryForm1 Tbl_Inspectionsummary = null;
        public Tbl_InspectionsummaryForm1()
        {
            InitializeComponent();
        }
        public static Tbl_InspectionsummaryForm1 tbl_Inspectionsummary()
        {
            if (Tbl_Inspectionsummary is null)
            {
                Tbl_Inspectionsummary = new Tbl_InspectionsummaryForm1();
            }
            return Tbl_Inspectionsummary;
        }
        private void Tbl_InspectionsummaryForm1_Load(object sender, EventArgs e)
        {
            配置.数据表(gridView1);
            配置.BindCustomDrawRowIndicator(gridView1);
            配置.CalcIndicatorBestWidth(gridView1);
            配置.CalcIndicatorDefaultWidth(gridView1);
            Tbl_Inspectionsummary tbl_Inspectionsummary = new Tbl_Inspectionsummary();
            this.gridControl1.DataSource = new Tbl_InspectionsummaryManager().select(tbl_Inspectionsummary);
        }

        private void Tbl_InspectionsummaryForm1_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            Tbl_Inspectionsummary = null;
        }
    }
}