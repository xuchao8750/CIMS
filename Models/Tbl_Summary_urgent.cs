using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// Tbl_Summary_urgent的实体类
    /// </summary>
    [Serializable]
    public class Tbl_Summary_urgent
    {
        public string 子项号 { get; set; }
        public string 系统号 { get; set; }
        public string 图纸号 { get; set; }
        public string 焊口号 { get; set; }
        public string 检测结果 { get; set; }
        public string 焊工号 { get; set; }
        public string 规格 { get; set; }
        public DateTime? 加急日期 { get; set; }
        [PK][DisplayName("主键")] public int 主键ID { get; set; }
    }
}
