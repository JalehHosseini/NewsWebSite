using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class LoginReposiory : ILoginReposiory
    {

        private MyCmsContext db;
        public LoginReposiory(MyCmsContext context)
        {
            this.db = context;
        }

        public bool IsExistUser(string username, string password)
        {
            return db.adminLogins.Any(u=> u.UserName==username&& u.Password==password); 
        }
    }
}
