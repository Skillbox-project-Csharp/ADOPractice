using ADOPractice.Medels;
using ADOPractice.Repositories.ConnectionString;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOPractice.Repositories
{
    public class ProductRepository : ConnectionMSSqlServer, IRepository<ProductModel>
    {
        public void Add(ProductModel model)
        {
            throw new NotImplementedException();
        }

        public void Delete(ProductModel model)
        {
            throw new NotImplementedException();
        }

        public void Edit(ProductModel model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public ProductModel GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
