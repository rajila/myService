using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceOneWCF
{
    public class ServiceOne : IServiceOne
    {
        public string getMessage(string name)
        {
            return "Hola mundo " + name;
        }
    }
}