using Database.DBContexts;
using Database.Models;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Classes
{
    public class CategoryService : ICategoryService
    {
        public AppDBContext _context { get; set; }
        public CategoryService(AppDBContext context)
        {
            _context = context;
        }
        public bool DeleteCategory(int id)
        {
            try
            {
                var ide = GetCategoryById(id);
                _context.categories.Remove(ide);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool DeleteCategory(Category? category)
        {
            try
            {
                _context.categories.Remove(category);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

        public List<Category>? GetAllCategories()
        {
            try
            {
                return _context.categories.ToList();
            }
            catch (Exception)
            {

                return null;
            }
        }

        public Category? GetCategoryById(int id)
        {
            try
            {
                return _context.categories.Find(id);

            }
            catch (Exception)
            {

                return null;
            }
        }

        public
            bool InsertCategory(Category category)
        {
            try
            {
                _context.categories.Add(category);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool UpdateCategory(Category category)
        {
            try
            {
                _context.categories.Update(category);
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
