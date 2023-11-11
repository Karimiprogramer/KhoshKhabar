using Database.DBContexts;
using Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Interfaces;

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
    }
}
