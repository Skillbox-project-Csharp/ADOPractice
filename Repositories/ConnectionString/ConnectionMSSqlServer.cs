using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace ADOPractice.Repositories.ConnectionString
{
    public class ConnectionMSSqlServer : BaseConnectionString
    {
        private readonly DbConnectionStringBuilder dbConnection;
        public ConnectionMSSqlServer()
        {
            dbConnection = new DbConnectionStringBuilder();
            dbConnection.Add("Data Source", @"(local)");
            dbConnection.Add("Initial Catalog","BestBuy");
            dbConnection.Add("Integrated Security", true);
        }

        protected override string GetConnectionString()
        {
            return dbConnection.ConnectionString;
        }
    }
}
