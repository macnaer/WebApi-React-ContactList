using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactList.Data.Data.Models
{
    public class UserContactList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string About { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public int Avatar { get; set; }
        public bool Favorite { get; set; }
    }
}
