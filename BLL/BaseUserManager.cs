using DAL;
using Models;

namespace BLL
{
    public class BaseUserManager
    {
        private BaseUserService BaseUserService = new BaseUserService();
        public Automatic UserLogin(Automatic objbaseUser)
        {
            return BaseUserService.UserLogin(objbaseUser);
        }
        public int ChangePwd(BaseUser objbaseUser)
        {
            return BaseUserService.ChangePwd(objbaseUser);
        }
    }
}
