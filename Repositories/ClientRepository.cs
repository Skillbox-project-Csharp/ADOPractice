using ADOPractice.Medels;
using ADOPractice.Repositories.ConnectionString;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOPractice.Repositories
{
    public class ClientRepository : ConnectionOleDb, IRepository<Clienmodel>
    {
        public void Add(Clienmodel model)
        {
            throw new NotImplementedException();
        }

        public void Delete(Clienmodel model)
        {
            throw new NotImplementedException();
        }

        public void Edit(Clienmodel model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Clienmodel> GetAll()
        {
            throw new NotImplementedException();
        }

        public Clienmodel GetById(string id)
        {
            throw new NotImplementedException();
        }

    }
}
