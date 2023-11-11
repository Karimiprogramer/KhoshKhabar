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
    public class ContentService : IContentService
    {
        public AppDBContext _context { get; set; }
        public ContentService(AppDBContext context)
        {
            _context = context;
        }
        public bool DeleteNews(int id)
        {
            try
            {
                var نمنمله = GetNewsById(id);
                _context.news.Remove(نمنمله);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool DeleteNews(Content Content)
        {
            try
            {
                _context.news.Remove(Content);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<Content>? GetAllNews()
        {
            try
            {
                return _context.news.ToList();
            }
            catch (Exception)
            {

                return null;
            }
        }

        public Content? GetNewsById(int id)
        {
            try
            {
                return _context.news.Find(id);

            }
            catch (Exception)
            {

                return null;
            }
        }

        public bool InsertNews(Content Content)
        {
            try
            {
                _context.news.Add(Content);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool UpdateNews(Content Content)
        {
            try
            {
                _context.news.Update(Content);
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
