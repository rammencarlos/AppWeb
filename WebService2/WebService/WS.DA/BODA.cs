using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS.DTO.BranchOffie;

namespace WS.DA
{
    public class BODA
    {
        public BODTODetail Get(int id)
        {
            return new BODTODetail();
        }

        public int Create(BODTOCreate bo)
        {
            BranchOffice newBo = new BranchOffice();
            newBo.Name = bo.Name;
            newBo.Code  = bo.Code;
            newBo.Country  = bo.Country;
            newBo.State  = bo.State;
            newBo.City  = bo.City;
            newBo.ZIP  = bo.Zip;
            newBo.Street  = bo.Street;
            newBo.ExternalNumber  = bo.ExternalNumber;
            newBo.Manager  = bo.Manager;
            newBo.PhoneNumber  = bo.PhoneNumber;
            newBo.Email  = bo.Email;
            newBo.UrlMaps  = bo.UrlMaps;
            newBo.CreateDate = DateTime.Now;
            newBo.IsEnabled  = true;

            using (var context = new OxxoEntities())
            {

                context.BranchOffice.Add(newBo);
                context.SaveChanges();
            }
            return newBo.Id;
        }

        public BODTODetail Update(BODTOUpdate bo)
        {
            return new BODTODetail();
        }

        public List<BODTODetail> List()
        {
            return new List<BODTODetail>();
        }


    }
}
