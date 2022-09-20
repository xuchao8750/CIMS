using System;
using System.ComponentModel;

namespace Models
{
    /// <summary>
    /// AdminRoles的实体类
    /// </summary>
    [Serializable]
    public class AdminRoles
    {
        [PK][DisplayName("角色GUID")] public string RoleGUID { get; set; }
        [DisplayName("角色名称")] public string RoleName { get; set; }
        [DisplayName("角色描述")] public string RoleDesc { get; set; }
    }
}
