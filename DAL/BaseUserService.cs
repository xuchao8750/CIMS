using Common;
using DBUtility;
using Models;
using System;
using System.Linq;

namespace DAL
{
    public class BaseUserService
    {
        public Automatic UserLogin(BaseUser objbaseUser)
        {
            string SQL = $"SELECT {MyReflector.GetSelectProp(typeof(BaseUser))} FROM BaseUser WHERE BaseUserName=@BaseUserName AND BaseUserPwd=@BaseUserPwd";
            Automatic baseUser = DPHelper.ReadDB<Automatic>(SQL, objbaseUser).FirstOrDefault();
            if (baseUser is null)
            {
                return null;
            }
            else
            {
                string sql = $"SELECT {MyReflector.GetSelectProp(typeof(Grouping))} FROM Grouping WHERE GroupingGUID=@GroupingGUID";
                baseUser.ObjGrouping = DPHelper.ReadDB<Grouping>(sql, baseUser).FirstOrDefault();
                string Sql = $"SELECT {MyReflector.GetSelectProp(typeof(AdminRoles))} FROM AdminRoles WHERE RoleGUID=@RoleGUID";
                baseUser.ObjAdminRoles = DPHelper.ReadDB<AdminRoles>(Sql, baseUser).FirstOrDefault();
                return baseUser;
            }
        }
        public int ChangePwd(BaseUser objbaseUser)
        {
            String sql = $"UPDATE BaseUser SET BaseUserPwd=@BaseUserPwd WHERE BaseUserGUID=@BaseUserGUID";
            return DPHelper.WriteDB(sql, objbaseUser);
        }
    }
}
