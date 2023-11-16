using Database.DBContexts;
using Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Interfaces;
using DTOs;

namespace Services.Classes
{
    public class UserService : IUserService
    {
        public AppDBContext _context { get; set; }
        public UserService(AppDBContext context)
        {
            _context = context;
        }
        public bool DeleteUser(int id)
        {
            try
            {
                var نمنمله = GetUserById(id);
                _context.users.Remove(نمنمله);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool DeleteUser(User User)
        {
            try
            {
                _context.users.Remove(User);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<User>? GetAllUsers()
        {
            try
            {
                return _context.users.ToList();
            }
            catch (Exception)
            {

                return null;
            }
        }

        public User? GetUserById(int id)
        {
            try
            {
                return _context.users.Find(id);

            }
            catch (Exception)
            {

                return null;
            }
        }

        public bool InsertUser(User User)
        {
            try
            {
                _context.users.Add(User);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool UpdateUser(User User)
        {
            try
            {
                _context.users.Update(User);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public EditableUserDTO GetEditableUser(int id)
        {
            var user = _context.users.Find(id);
            return new EditableUserDTO()
            {
                ID = user.ID,
                Name = user.Name,
                Bio = user.Bio,
                PhoneNumber = user.PhoneNumber,
                PassWordHash = user.PassWordHash

            };
        }

        public bool UpdateUser(EditableUserDTO? User)
        {
            try
            {
                User? user = _context.users.Find(User.ID);
                user.ID = User.ID;
                user.Name = User.Name;
                user.Bio = User.Bio;
                user.PhoneNumber = User.PhoneNumber;
                if (!string.IsNullOrEmpty(User.PassWordHash))
                {
                    user.PassWordHash = User.PassWordHash;
                }
                _context.users.Update(user);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
