using System;
using System.Collections.Generic;
using System.Text;

namespace SignalR.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void TAdd(T entity);
        void TUpdate(T entity);
        void TDelete(T entity);
        List<T> TGetListAll();
        T TGetById(int id);
    }
}
