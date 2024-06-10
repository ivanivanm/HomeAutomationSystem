using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.CRUD
{
    public interface IDb<T,K>
    {
        void Add(T entity);
        T Get(K key, bool useNavigationalProperties, bool isReadOnly);
        ICollection<T> GetAll(bool useNavigationalProperties, bool isReadOnly);
        void Update(T entity, bool useNavigationalProperties);
        void Remove(K key);
    }
}
