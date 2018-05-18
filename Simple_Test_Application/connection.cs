using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Test_Application
{
    class connection
    {
        public OracleConnection thisConnection = new OracleConnection("Data Source=XE; User ID =info;Password=info;");

    }
}
