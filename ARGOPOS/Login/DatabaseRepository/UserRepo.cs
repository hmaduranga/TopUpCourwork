using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARGOPOS.Login.DatabaseRepository
{
    public class UserRepo
    {
        private ArgoPosEntities dbentities;
        public UserRepo()
        {
            dbentities = new ArgoPosEntities();
        }


        public pos_user userExits(string usernme , string password)
        {

         return   dbentities.pos_user.Where(user =>

            user.password == password &&
            user.username == usernme

            ).FirstOrDefault();
        }
    }
}
