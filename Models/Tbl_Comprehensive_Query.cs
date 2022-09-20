using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// Tbl_Comprehensive_Query的实体类
    /// </summary>
    [Serializable]
    public class Tbl_Comprehensive_Query
    {
        public string 子项号 { get; set; }
        public string 系统号 { get; set; }
        public string 图纸号 { get; set; }
        public string 焊口号 { get; set; }
        public string 是否有效 { get; set; }
        public string 删除标识 { get; set; }
        public string 焊口状态 { get; set; }
        public string DCM焊口状态 { get; set; }
        public string PT状态 { get; set; }
        public string RT状态 { get; set; }
        public string PT批号 { get; set; }
        public string RT批号 { get; set; }
        public string PT委托单编号 { get; set; }
        public string RT委托单编号 { get; set; }
        public DateTime? 检测日期 { get; set; }
        public string 检测结果 { get; set; }
        public int? 底片数 { get; set; }
        public int? 不合格数 { get; set; }
        public string 缺陷描述 { get; set; }
        public string 质量计划 { get; set; }
        public string 安全级 { get; set; }
        public string 焊工 { get; set; }
        public DateTime? 焊接日期 { get; set; }
        public DateTime? 回填日期 { get; set; }
        public string 标高位置 { get; set; }
        public string 班组 { get; set; }
        public string 设备名称 { get; set; }
        public string PT比例 { get; set; }
        public string RT比例 { get; set; }
        public string 物项A { get; set; }
        public string 材质A { get; set; }
        public string 规格A { get; set; }
        public string 转换规格A { get; set; }
        public string 物项B { get; set; }
        public string 材质B { get; set; }
        public string 规格B { get; set; }
        public string 转换规格B { get; set; }
        public string 接头形式 { get; set; }
        public string 介质 { get; set; }
        public double? 寸经 { get; set; }
        public DateTime? 删除日期 { get; set; }
        public string 打印人 { get; set; }
        public DateTime? 打印时间 { get; set; }
        public int? 打印次数 { get; set; }
        public DateTime? 报量日期 { get; set; }
        [PK][DisplayName("主键")] public string 主键 { get; set; }
        public string 工艺编号 { get; set; }
        public double? 转换壁厚A { get; set; }
        public double? 转换壁厚B { get; set; }
    }
}
