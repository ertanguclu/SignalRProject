using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SignalR.DataAccessLayer.Abstract
{
    public interface IDiscountDal : IGenericDal<Discount>
    {
        void ChangeStatusToTrue(int id);
        void ChangeStatusToFalse(int id);
        List<Discount> GetListByStatusTrue();
    }
}
