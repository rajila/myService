using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Librerias
using System.ServiceModel;

namespace ServiceOneWCF
{
    [ServiceContract]
    public interface IServiceOne
    {
        [OperationContract]
        string getMessage(string name);
    }
}