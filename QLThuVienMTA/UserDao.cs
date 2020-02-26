using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLThuVienMTA
{
    public class UserDao
    {
        ModelDbContext db = null;
        public UserDao()
        {
            db = new ModelDbContext();
        }
        public long insert(User entity)
        {
            db.Users.Add(entity);
            db.SaveChanges();
            return entity.ID;
        }
        public User GetByID(string userName)
        {
            return db.Users.SingleOrDefault(x => x.UserName == userName);
        }
        public bool Login(string userName ,string password)
        {
            var result = db.Users.Count(x => x.UserName == userName && x.Password == password);
            if(result>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}