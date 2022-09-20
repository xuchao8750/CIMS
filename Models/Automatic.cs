using System;
using System.Collections.Generic;
using System.ComponentModel;
using Models;

namespace Models
{
    [Serializable]
    public class Automatic : BaseUserEx
    {

        [DisplayName("自动登录")] public bool MyProperty { get; set; }
    }
}
