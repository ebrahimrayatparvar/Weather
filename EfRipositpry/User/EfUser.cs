using _01_Weather.Core.User;
using _02_Weather.Contracts.User;
using EfRipositpry.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfRipositpry.User
{
    public class EfUser : UserRiposetory
    {
        private ApplicationDbContext _db = new ApplicationDbContext();


        public void ChanghePassword(UserEntity obj)
        {
            throw new NotImplementedException();
        }

        public List<UserEntity> GetUserInformation(string userName) => _db.Users.Where(q => q.Username.Equals(userName)).ToList();

        public bool IsUser(UserEntity obj)
        {
            var c = _db.Users.Where(q => q.Username.Equals(obj.Username) &&
                                    q.Password.Equals(obj.Password)).ToList().Count;
            return c >= 1;
        }

        public bool Register(UserEntity obj)
        {
            if (!_db.Users.Any(q => q.Username.Equals(obj.Username)))
            {
                var result = _db.Users.Add(obj);
                _db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
