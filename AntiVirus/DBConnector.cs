using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace AntiVirus
{
    class DBConnector
    {
        SqliteConnection connection;

        DBConnector(String source)
        {
            var connection = new SqliteConnection("Data Source=" + source);
            connection.Open();
        }
    }
}
