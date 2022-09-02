using BaharBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaharBlog.Entities.Concrete
{
    public class User:EntityBase,IEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }//şifreli yapacağız
        public string UserNAme { get; set; }
        public int RoleId { get; set; }
        public string Picture { get; set; }
        public string Description { get; set; }
        public Role Role { get; set; }//role ile arasında bağlantı 
        public virtual string Note { get; set; }
       
    }
}
