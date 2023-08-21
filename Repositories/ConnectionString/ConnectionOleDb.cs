using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace ADOPractice.Repositories.ConnectionString
{
    public class ConnectionOleDb : BaseConnectionString
    {
        private readonly DbConnectionStringBuilder dbConnection;
        public ConnectionOleDb()
        {
            dbConnection = new DbConnectionStringBuilder();
            dbConnection.Add("Data Source", @"D:\Zub\Programming\C#\skillbox\ADOPractice\DB\BestBuy.accdb");
            dbConnection.Add("Provider", "Microsoft.ACE.OLEDB.12.0");
        }

        protected override string GetConnectionString()
        {
            return dbConnection.ConnectionString;
        }
    }
}
