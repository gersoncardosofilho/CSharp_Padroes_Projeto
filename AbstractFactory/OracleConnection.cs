using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class OracleConnection : DBConnection
    {
        public override void Open()
        {
            Console.WriteLine("Método Open do OracleConnection foi chamado");
        }
    }
}
