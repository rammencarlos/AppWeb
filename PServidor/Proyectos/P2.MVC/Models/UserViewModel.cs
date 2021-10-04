using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P2.MVC.Models
{
    public class UserViewModel
    {
        public Int32 Id { get; set; }
        public string Name { get; set; }
        public bool IsEnabled { get; set; }
    }
}
