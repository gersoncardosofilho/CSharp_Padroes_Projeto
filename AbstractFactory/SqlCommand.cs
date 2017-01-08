using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //Produto concreto (Concrete product)
    public class SqlCommand : DBCommand
    {
        public override void Execute()
        {
            Console.WriteLine("Método Execute do SqlCommand foi chamado");
        }
    }
}
