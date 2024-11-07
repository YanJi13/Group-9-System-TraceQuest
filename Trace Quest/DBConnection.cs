using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trace_Quest {
    internal class DBConnection {

        public SqlConnection connection = new SqlConnection();

        public DBConnection() {

            connection = new SqlConnection("Data Source=YANJI13;Initial Catalog=TraceQuestDB;Integrated Security=True;Encrypt=False");
        }
    }
}
