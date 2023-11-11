using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string Title { get; set; }
        [InverseProperty("Category")]
        public List<Content>? Contents { get; set; }
    }
}
