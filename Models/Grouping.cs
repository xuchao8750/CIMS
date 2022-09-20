using System;
using System.ComponentModel;

namespace Models
{
    /// <summary>
    /// Grouping的实体类
    /// </summary>
    [Serializable]
    public class Grouping
    {
        [PK][DisplayName("分组GUID")] public string GroupingGUID { get; set; }
        [DisplayName("分组名称")] public string GroupingName { get; set; }
    }
}
