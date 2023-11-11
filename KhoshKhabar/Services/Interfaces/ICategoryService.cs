using Database.DBContexts;
using Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface ICategoryService
    {
        public AppDBContext _context { get; set; }
        public List<Category>? GetAllCategories();
        public Category? GetCategoryById(int id);
        public bool InsertCategory(Category category);
        public bool UpdateCategory(Category category);
        public bool DeleteCategory(int id);
        public bool DeleteCategory(Category? category);
    }
}
