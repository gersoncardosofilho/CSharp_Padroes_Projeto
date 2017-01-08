using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class SqlConnection : DBConnection
    {
        //Produto concreto (Concrete product)
        public override void Open()
        {
            Console.WriteLine("Método Open do SqlConnection foi chamado");
        }
    }
}
