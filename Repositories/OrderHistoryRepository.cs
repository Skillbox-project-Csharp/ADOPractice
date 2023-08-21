using ADOPractice.Medels;
using ADOPractice.Repositories.ConnectionString;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOPractice.Repositories
{
    public class OrderHistoryRepository : ConnectionMSSqlServer, IRepository<OrderHistoryModel>
    {
        public void Add(OrderHistoryModel model)
        {
            throw new NotImplementedException();
        }

        public void Delete(OrderHistoryModel model)
        {
            throw new NotImplementedException();
        }

        public void Edit(OrderHistoryModel model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderHistoryModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public OrderHistoryModel GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
