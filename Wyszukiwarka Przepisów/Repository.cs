using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyszukiwarka_Przepisów
{
    interface Repository<ID, T>
    {
        List<T> FindAll();
        T FindById(ID id);
        void Save(T entity);
        void SaveAll(List<T> list);
        void Clear();

    }
}
