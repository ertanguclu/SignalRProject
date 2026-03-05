using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SignalR.BusinessLayer.Abstract
{
    public interface IDiscountService : IGenericService<Discount>
    {
        void TChangeStatusToTrue(int id);
        void TChangeStatusToFalse(int id);
        List<Discount> TGetListByStatusTrue();
    }
}
