using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //Produto abstrato (Abstract product)
    public abstract class DBCommand
    {
        public abstract void Execute();
    }
}
