using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WS.Core;
using WS.DTO.BranchOffie;

public class Service : IService
{
    public BODTODetail Get(int value)
    {
        var bo = new BOCore().Get(value);
        return bo;
    }

    public List<BODTODetail> List()
    {
        var bos = new BOCore().List();
        return bos;
    }

    public int Create(BODTOCreate bo)
    {
        int id = new BOCore().Create(bo);
        return id;
    }
}
