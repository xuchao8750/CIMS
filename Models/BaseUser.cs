using System;
using System.ComponentModel;

namespace Models
{
    /// <summary>
    /// BaseUser的实体类
    /// </summary>
    [Serializable]
    public class BaseUser
    {
        [PK][DisplayName("用户GUID")] public string BaseUserGUID { get; set; }
        [DisplayName("真实姓名")] public string RealName { get; set; }
        [DisplayName("用户名")] public string BaseUserName { get; set; }
        [DisplayName("密码")] public string BaseUserPwd { get; set; }
        [DisplayName("分组GUID")] public string GroupingGUID { get; set; }
        [DisplayName("角色GUID")] public string RoleGUID { get; set; }
        [DisplayName("用户状态")] public int BaseUserStatus { get; set; }
    }
}
