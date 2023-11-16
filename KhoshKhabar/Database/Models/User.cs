using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
        public string PhoneNumber { get; set; }
        public string PassWordHash { get; set; }
       // public UserType Modfier { get; set; }

        [InverseProperty("Author")]
        public List<Content>? Contents { get; set; }
    }
}
        

