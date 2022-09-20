using DevExpress.XtraBars.Docking;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTabbedMdi;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Common
{
    public class 系统配置
    {
        public void 配置类型(RibbonControl ribbon)
        {
            ribbon.ShowToolbarCustomizeItem = false;
            ribbon.ShowSearchItem = false;
            ribbon.ShowMoreCommandsButton = DevExpress.Utils.DefaultBoolean.False;
            //ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            ribbon.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            ribbon.MdiMergeStyle = RibbonMdiMergeStyle.Always;
        }
        public void 导航设置(DockPanel dockPanel)
        {
            dockPanel.Options.AllowDockTop = false;//停靠上边
            dockPanel.Options.AllowDockBottom = false;//停靠下边
            dockPanel.Options.AllowDockRight = false;//停靠右边
            dockPanel.Options.FloatOnDblClick = false;//双击浮动
            dockPanel.Options.ShowCloseButton = false;//关闭按钮
            dockPanel.Options.ShowMaximizeButton = false;//最大化
            dockPanel.Options.ShowMinimizeButton = false;//最下化
        }
        public void 导航栏1(DockManager dockManager)
        {
            dockManager.AutoHiddenPanelShowMode = AutoHiddenPanelShowMode.MouseClick; //点击显示 点击隐藏
        }

        public void 子窗体顶部状态栏(XtraTabbedMdiManager mdiManager) //顶部状态栏设置
        {
            mdiManager.CloseTabOnMiddleClick = CloseTabOnMiddleClick.Never;
            mdiManager.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPagesAndTabControlHeader;
            mdiManager.FloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.False;
            mdiManager.FloatOnDrag = DevExpress.Utils.DefaultBoolean.False;
        }

        public void 数据表(GridView gridView)
        {
            gridView.OptionsView.ColumnAutoWidth = false;//横向滚动条
            //gridView.OptionsBehavior.Editable = false; //不可编辑
            gridView.BestFitColumns();//自动列宽
            //gridView.OptionsBehavior.SmartVertScrollBar = true; //自动隐藏滚动条
            //gridView.OptionsView.ShowFooter = true; //显示页脚行
            //gridView.OptionsView.ShowIndicator = false; //不显示左边空白列
            gridView.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click; //选中整行

        }

        #region 数据表序号显示
        public void BindCustomDrawRowIndicator(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            view.IndicatorWidth = CalcIndicatorDefaultWidth(view);
            view.CustomDrawRowIndicator += (s, e) =>
            {
                if (e.RowHandle >= 0)
                {
                    e.Info.DisplayText = (e.RowHandle + 1).ToString();
                }
            };
            view.TopRowChanged += (s, e) =>
            {
                int width = CalcIndicatorBestWidth(view);
                if ((view.IndicatorWidth - 4 < width || view.IndicatorWidth + 4 > width) && view.IndicatorWidth != width)
                {
                    view.IndicatorWidth = width;
                }
            };

        }
        /// <summary>
        /// 计算行头宽度
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
        public int CalcIndicatorBestWidth(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            Graphics graphics = new Control().CreateGraphics();
            SizeF sizeF = new SizeF();
            int count = view.TopRowIndex + ((DevExpress.XtraGrid.Views.Grid.ViewInfo.GridViewInfo)view.GetViewInfo()).RowsInfo.Count;
            if (count == 0)
            {
                count = 30;
            }
            sizeF = graphics.MeasureString(count.ToString(), view.Appearance.Row.Font);
            return Convert.ToInt32(sizeF.Width) + 20;
        }
        /// <summary>
        /// 计算默认的宽度
        /// </summary>
        /// <param name="view"></param>
        /// <returns></returns>
        public int CalcIndicatorDefaultWidth(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            var grid = view.GridControl;
            Graphics graphics = new Control().CreateGraphics();
            SizeF sizeF = new SizeF();
            int rowHeight = 22;//22是Row的估计高度
            if (view.RowHeight > 0)
            {
                rowHeight = view.RowHeight;
            }
            int count = grid != null ? grid.Height / rowHeight : 30;
            sizeF = graphics.MeasureString(count.ToString(), view.Appearance.Row.Font);
            return Convert.ToInt32(sizeF.Width) + 20;
        }
        #endregion

        /// <summary>
        /// 导出表格数据到文件
        /// </summary>
        /// <param name="gridView"></param>
        /// <param name="strCaption"></param>
        public void ExportFile(GridView gridView, string strCaption)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.FileName = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
            sf.AddExtension = true;//自动添加扩展名

            switch (strCaption)
            {
                case "Excel文件":
                    sf.DefaultExt = "xlsx";
                    sf.Filter = "Excel文件 (*.xlsx)|*.xlsx|Excel文件(*.xls)|*.xls";

                    if (sf.ShowDialog() == DialogResult.OK)
                    {
                        if (sf.FileName.EndsWith("xlsx"))
                            gridView.ExportToXlsx(sf.FileName);
                        if (sf.FileName.EndsWith("xls"))
                            gridView.ExportToXls(sf.FileName);
                    }
                    break;
                case "TXT文件":
                    sf.DefaultExt = "txt";
                    sf.Filter = "TXT文件 (*.txt)|*.txt";

                    if (sf.ShowDialog() == DialogResult.OK)
                    {
                        if (sf.FileName.EndsWith("txt"))
                            gridView.ExportToText(sf.FileName);
                    }
                    break;
                case "CSV文件":
                    sf.DefaultExt = "csv";
                    sf.Filter = "CSV文件 (*.csv)|*.csv";

                    if (sf.ShowDialog() == DialogResult.OK)
                    {
                        if (sf.FileName.EndsWith("csv"))
                            gridView.ExportToCsv(sf.FileName);
                    }
                    break;
                case "PDF文件":
                    sf.DefaultExt = "pdf";
                    sf.Filter = "Pdf文件 (*.pdf)|*.pdf";

                    if (sf.ShowDialog() == DialogResult.OK)
                    {
                        if (sf.FileName.EndsWith("pdf"))
                            gridView.ExportToPdf(sf.FileName);
                    }
                    break;
                case "Rtf文件":
                    sf.DefaultExt = "rtf";
                    sf.Filter = "Rtf文件 (*.rtf)|*.rtf";

                    if (sf.ShowDialog() == DialogResult.OK)
                    {
                        if (sf.FileName.EndsWith("rtf"))
                            gridView.ExportToRtf(sf.FileName);
                    }
                    break;
                case "Mht文件":
                    sf.DefaultExt = "mht";
                    sf.Filter = "Mht文件 (*.mht)|*.mht";

                    if (sf.ShowDialog() == DialogResult.OK)
                    {
                        if (sf.FileName.EndsWith("mht"))
                            gridView.ExportToMht(sf.FileName);
                    }
                    break;
                case "Html文件":
                    sf.DefaultExt = "html";
                    sf.Filter = "HTML文件 (*.html)|*.html";

                    if (sf.ShowDialog() == DialogResult.OK)
                    {
                        if (sf.FileName.EndsWith("html"))
                            gridView.ExportToHtml(sf.FileName);
                    }
                    break;
                default:
                    break;
            }
        }
    }

}
