using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// Tbl_Inspectionsummary的实体类
    /// </summary>
    [Serializable]
    public class Tbl_Inspectionsummary
    {
        public string 子项号 { get; set; }
        public string 专业名称 { get; set; }
        public string 图纸号 { get; set; }
        public string 焊口号 { get; set; }
        public string 规格 { get; set; }
        public string 焊工号 { get; set; }
        public int? 底片量 { get; set; }
        public string 检测结果 { get; set; }
        public int? 不合格数 { get; set; }
        public string 缺陷描述 { get; set; }
        public DateTime? 检测日期 { get; set; }
        public string 焊工姓名 { get; set; }
        [PK][DisplayName("主键")] public int 主键 { get; set; }
    }
}
