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
            BODTODetail newBo = new BODTODetail();

            using (var context = new OxxoEntities())
            {
                var bo = (from c in context.BranchOffice.ToList()
                            where c.Id == id 
                            select c).SingleOrDefault();

                newBo.Id = bo.Id;
                newBo.Name = bo.Name;
                newBo.Code = bo.Code;
                newBo.Country = bo.Country;
                newBo.State = bo.State;
                newBo.City = bo.City;
                newBo.ZIP = bo.ZIP;
                newBo.Street = bo.Street;
                newBo.ExternalNumber = bo.ExternalNumber;
                newBo.PhoneNumber = bo.PhoneNumber;
                newBo.Email = bo.Email;
                newBo.UrlMaps = bo.UrlMaps;
            }
            return newBo;
        }

        public int Create(BODTOCreate bo)
        {
            BranchOffice newBo = new BranchOffice();
            newBo.Name = bo.Name;
            newBo.Code = bo.Code;
            newBo.Country = bo.Country;
            newBo.State = bo.State;
            newBo.City = bo.City;
            newBo.ZIP = bo.ZIP;
            newBo.Street = bo.Street;
            newBo.ExternalNumber = bo.ExternalNumber;
            newBo.Manager = bo.Manager;
            newBo.PhoneNumber = bo.PhoneNumber;
            newBo.Email = bo.Email;
            newBo.UrlMaps = bo.UrlMaps;
            newBo.CreateDate = DateTime.Now;
            newBo.IsEnabled = true;

            //throw new Exception("Errror en la capa de acceso a datos");

            using (var context = new OxxoEntities())
            {

                context.BranchOffice.Add(newBo);
                context.SaveChanges();
            }
            return newBo.Id;
        }

        public int Update(BODTOUpdate bo)
        {
            using (var context = new OxxoEntities())
            {
                //Lambda
                var data = context.BranchOffice.FirstOrDefault(x => x.Id == bo.Id);

                //LINQ
                //var bo = (from c in context.BranchOffice.ToList()
                //          where c.Id == id
                //          select c).SingleOrDefault();
                if (data != null)
                {
                    data.Name = bo.Name;
                    data.Code = bo.Code;
                    data.City = bo.City;
                    data.Street = bo.Street;
                    data.ExternalNumber = bo.ExternalNumber;
                    data.Manager = bo.Manager;
                    data.PhoneNumber = bo.PhoneNumber;
                    data.Email = bo.Email;
                    data.UrlMaps = bo.UrlMaps;
                    data.UpdateDate = DateTime.Now;
                    data.IsEnabled = bo.IsEnabled;
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Error registro no actualizado");
                }


            }
            return bo.Id;
        }

        public List<BODTODetail> List()
        {
            List<BODTODetail> list = new List<BODTODetail>();
            using (var context = new OxxoEntities())
            {
                var data = context.BranchOffice.ToList();

                foreach (BranchOffice bo in data)
                {
                    BODTODetail newBo = new BODTODetail();
                    newBo.Id = bo.Id;
                    newBo.Name = bo.Name;
                    newBo.Code = bo.Code;
                    newBo.Country = bo.Country;
                    newBo.State = bo.State;
                    newBo.City = bo.City;
                    newBo.ZIP = bo.ZIP;
                    newBo.Street = bo.Street;
                    newBo.ExternalNumber = bo.ExternalNumber;
                    newBo.PhoneNumber = bo.PhoneNumber;
                    newBo.Email = bo.Email;
                    newBo.UrlMaps = bo.UrlMaps;

                    list.Add(newBo);
                }

            }
            return list;
        }

        public bool Delete(int id)
        {
            using (var context = new OxxoEntities())
            {
                var bo = (from c in context.BranchOffice.ToList()
                          where c.Id == id
                          select c).SingleOrDefault();
                if (bo != null)
                {
                    context.BranchOffice.Remove(bo);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Error registro no eliminado");
                }
            }
            return true;
        }

    }
}
