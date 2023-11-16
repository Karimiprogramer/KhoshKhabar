using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class EditableUserDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
        public string PhoneNumber { get; set; }
        public string? PassWordHash { get; set; }
    }
}
