using Database.DBContexts;
using Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IUserService
    {
        public AppDBContext _context { get; set; }
        public List<User>? GetAllUsers();
        public User? GetUserById(int id);
        public bool InsertUser(User User);
        public bool UpdateUser(User User);
        public bool DeleteUser(int id);
        public bool DeleteUser(User User);
        public DTOs.EditableUserDTO GetEditableUser(int id);
        public bool UpdateUser(DTOs.EditableUserDTO? User);
    }
}
