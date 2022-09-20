using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// Tbl_R2_Repair_bill的实体类
    /// </summary>
    [Serializable]
    public class Tbl_R2_Repair_bill
    {
        public string 序号 { get; set; }
        public string 子项号 { get; set; }
        public string 受检设备 { get; set; }
        public string 图纸号 { get; set; }
        public string 焊口号 { get; set; }
        public string 焊工号 { get; set; }
        public string 检测结果 { get; set; }
        public string 缺陷描述 { get; set; }
        public string 管工班组 { get; set; }
        public DateTime? 检测时间 { get; set; }
        public string 规格 { get; set; }
        public string 标高位置 { get; set; }
        public string 焊口状态 { get; set; }
        public string 变更状态 { get; set; }
        public string 发放人 { get; set; }
        public string 领取人 { get; set; }
        public DateTime? 返修单发放时间 { get; set; }
        public DateTime? 预计返修结束时间 { get; set; }
        public string 第1天 { get; set; }
        public string 第2天 { get; set; }
        public string 第3天 { get; set; }
        public string 返修口焊口号 { get; set; }
        public DateTime? 返修口回填委托时间 { get; set; }
        public string 返修口检测结果 { get; set; }
        public DateTime? 返修口检测时间 { get; set; }
        public string 移交人 { get; set; }
        public string 接收人 { get; set; }
        public DateTime? 移交时间 { get; set; }
        public string 备注 { get; set; }
        public string 线上班组 { get; set; }
        [PK][DisplayName("主键")] public int 主键ID { get; set; }
        public string UUID { get; set; }
    }
}
