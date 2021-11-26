using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WS.DTO.BranchOffie
{
    public class BODTODetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Country { get; set; }
        public string State { set; get; }
        public string City { set; get; }
        public string Zip { set; get; }
        public string Street { set; get; }
        public string ExternalNumber { set; get; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string UrlMaps { get; set; }
    }
}
