using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //Fábrica concreta (Concrete factory)
    public class SqlFactory : DBFactory
    {
        public override DBCommand createCommand()
        {
            return new SqlCommand();
        }

        public override DBConnection createConnection()
        {
            return new SqlConnection();
        }
    }
}
