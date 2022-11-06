using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Model
{
    internal interface IRepositorio<T>
    {
        void  Add(T obj);
        void  Update(T obj);
        void  Delete(T obj);
    }
}
