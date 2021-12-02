using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS.DA;
using WS.DTO.BranchOffie;

namespace WS.Core
{
    public class BOCore
    {
        public BODTODetail Get(int id)
        {
            return new BODA().Get(id);
        }

        public int Create(BODTOCreate bo)
        {
            return new BODA().Create(bo);
        }

        public List<BODTODetail> List()
        {
            return new BODA().List();
        }

        public int Update(BODTOUpdate bo)
        {
            return new BODA().Update(bo);
        }
    }
}
