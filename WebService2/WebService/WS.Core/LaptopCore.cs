using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS.DA;
using WS.DTO.Laptop;

namespace WS.Core
{
    public class LaptopCore
    {
        public LaptopDTODetail Get(int id)
        {
            return new LaptopDA().Get(id);
        }

        public int Create(LaptopDTOCreate bo)
        {
            return new LaptopDA().Create(bo);
        }

        public List<LaptopDTODetail> List()
        {
            return new LaptopDA().List();
        }

        public int Update(LaptopDTOUpdate bo)
        {
            return new LaptopDA().Update(bo);
        }
        public bool Delete(int id)
        {
            return new LaptopDA().Delete(id);
        }
    }
}
