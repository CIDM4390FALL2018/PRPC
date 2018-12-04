/* using System;
using System.Threading.Tasks;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Sqlite;
using dotenv.net;
using Microsoft.Data.Sqlite;
using System.Data;

namespace MySqlLite
{
      class DataClass
      {
        private SqliteConnection sqlite;

        public DataClass()
        {
              //This part killed me in the beginning.  I was specifying "DataSource"
              //instead of "Data Source"
              sqlite = new SqliteConnection("Data Source=C:/CIDM4390/PRPC/Data/PRPCRepository.db");

        }
        public DataTable selectQuery(string query)
        {
              SqliteDataAdapter ad;
              DataTable dt = new DataTable();
        }
      }
}
*/