using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOPractice.Repositories
{
    public interface IRepository<T> where T : class
    {
        public void Add(T model);
        public void Edit(T model);
        public void Delete(T model);
        public IEnumerable<T> GetAll();
        public T GetById(string id);
    }
}
