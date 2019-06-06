using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceOneWCF
{
    public class ServiceOne : IServiceOne
    {
        public int add(int x, int y)
        {
            return x + y;
        }

        public string getMessage(string name)
        {
            return "Hola mundo " + name;
        }
    }
}