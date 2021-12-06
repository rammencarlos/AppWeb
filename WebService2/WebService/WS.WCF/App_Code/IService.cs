using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WS.DTO.BranchOffie;

[ServiceContract]
public interface IService
{
    [OperationContract]
    BODTODetail Get(int value);

    [OperationContract]
    List<BODTODetail> List();

    [OperationContract]
    int Create(BODTOCreate value);
}

