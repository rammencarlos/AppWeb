using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P3.CRUD.Models
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
