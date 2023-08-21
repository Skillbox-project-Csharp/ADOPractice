using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOPractice.Repositories.ConnectionString
{
    public abstract class BaseConnectionString
    {
        protected abstract string GetConnectionString();
    }
}
