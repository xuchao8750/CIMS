using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// log_R2_Repair_bill的实体类
    /// </summary>
    [Serializable]
    public class log_R2_Repair_bill
    {
        [PK][DisplayName("主键")] public Guid? 日志序号 { get; set; }
        public string 操作类型 { get; set; }
        public int? 原表ID { get; set; }
        public string 图纸号 { get; set; }
        public string 焊口号 { get; set; }
        public string 字段旧值 { get; set; }
        public string 字段新值 { get; set; }
        public int spid { get; set; }
        public string 登录名 { get; set; }
        public string 程序名 { get; set; }
        public string 主机名 { get; set; }
        public string IP地址 { get; set; }
        public string 执行的TSQL代码 { get; set; }
        public DateTime? 操作日期时间 { get; set; }
    }
}
