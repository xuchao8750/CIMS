using System;

namespace Models
{
    [Serializable]
    public class BaseUserEx : BaseUser
    {
        public Grouping ObjGrouping { get; set; }
        public AdminRoles ObjAdminRoles { get; set; }
    }
}
