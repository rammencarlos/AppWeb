using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS.DTO.Laptop;

namespace WS.DA
{
    public class LaptopDA
    {
        public LaptopDTODetail Get(int id)
        {
            LaptopDTODetail newLap = new LaptopDTODetail();

            using (var context = new OxxoEntities())
            {
                var lap = (from c in context.Laptop.ToList()
                            where c.Id == id 
                            select c).SingleOrDefault();

                newLap.Id = lap.Id;
                newLap.Name = lap.Name;
               
            }
            return newLap;
        }

        public int Create(LaptopDTOCreate bo)
        {
            Laptop newBo = new Laptop();
            newBo.Name = bo.Name;
            newBo.CreateDate = DateTime.Now;

            using (var context = new OxxoEntities())
            {
                context.Laptop.Add(newBo);
                context.SaveChanges();
            }
            return newBo.Id;
        }

        public int Update(LaptopDTOUpdate bo)
        {
            using (var context = new OxxoEntities())
            {
                var data = context.Laptop.FirstOrDefault(x => x.Id == bo.Id);

                if (data != null)
                {
                    data.Name = bo.Name;
                    data.UpdateDate = DateTime.Now;
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Error registro no actualizado");
                }


            }
            return bo.Id;
        }

        public List<LaptopDTODetail> List()
        {
            List<LaptopDTODetail> list = new List<LaptopDTODetail>();
            using (var context = new OxxoEntities())
            {
                var data = context.Laptop.ToList();

                foreach (Laptop bo in data)
                {
                    LaptopDTODetail newBo = new LaptopDTODetail();
                    newBo.Id = bo.Id;
                    newBo.Name = bo.Name;
                    list.Add(newBo);
                }

            }
            return list;
        }

        public bool Delete(int id)
        {
            using (var context = new OxxoEntities())
            {
                var bo = (from c in context.Laptop.ToList()
                          where c.Id == id
                          select c).SingleOrDefault();
                if (bo != null)
                {
                    context.Laptop.Remove(bo);
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
