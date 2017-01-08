using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            DBFactory db = new OracleFactory();

            var con = db.createConnection();
            con.Open();

            var command = db.createCommand();
            command.Execute();

            Console.ReadKey(); 
        }
    }
}
