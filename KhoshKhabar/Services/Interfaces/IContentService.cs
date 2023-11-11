using Database.DBContexts;
using Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IContentService
    {
        public AppDBContext _context { get; set; }
        public List<Content>? GetAllNews();
        public Content? GetNewsById(int id);
        public bool UpdateNews(Content Content);
        public bool DeleteNews(int id);
        public bool InsertNews(Content Content);
        public bool DeleteNews(Content Content);
    }
}
