using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// Tbl_R1_Repair_bill的实体类
    /// </summary>
    [Serializable]
    public class Tbl_R1_Repair_bill
    {
        public string 子项号 { get; set; }
        public string 受检设备 { get; set; }
        public string 图纸号 { get; set; }
        public string 焊口号 { get; set; }
        public string 焊工号 { get; set; }
        public string 焊工姓名 { get; set; }
        public string 检测结果 { get; set; }
        public int? 底片数 { get; set; }
        public int? 不合格数 { get; set; }
        public string 缺陷描述 { get; set; }
        public string 规格 { get; set; }
        public DateTime? 检测时间 { get; set; }
        public string 焊口状态 { get; set; }
        public string 管工班组 { get; set; }
        public string 标高位置 { get; set; }
        public string 返修单领取人 { get; set; }
        public DateTime? 返修单领取时间 { get; set; }
        public string 焊接方法 { get; set; }
        public string 寸经 { get; set; }
        public string 系统号 { get; set; }
        public string 备注 { get; set; }
        public string 所属单位 { get; set; }
        public DateTime? 返修完成日期 { get; set; }
        public string 焊工班组 { get; set; }
        public string 加急状态 { get; set; }
        [PK][DisplayName("主键")] public int 主键 { get; set; }
    }
}
