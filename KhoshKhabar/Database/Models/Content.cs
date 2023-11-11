using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Models
{
    public class Content
    {


        public int ID { get; set; }
        public string? Tags { get; set; }
        public string Title { get; set; }

        public string? ImagePath { get; set; }
        public string content { get; set; }
        public DateTime ReleaseDate { get; set; }
        private int myVar = 0;
        public int TotalVisits
        {
            get
            {
                myVar += 1;
                return myVar;
            }
        }   
        public int categoryID { get; set; }
        [ForeignKey("categoryID")]
        public Category? category { get; set; }
        public int UserID { get; set; }
        [ForeignKey("UserID")]
        public User? Author { get; set; }

    }
}
