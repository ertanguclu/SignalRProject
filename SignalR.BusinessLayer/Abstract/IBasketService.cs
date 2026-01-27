using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SignalR.BusinessLayer.Abstract
{
    public interface IBasketService : IGenericService<Basket>
    {
        List<Basket> TGetBasketByTableNumber(int id);
        List<Basket> TGetBasketListByMenuTableWithProductName(int id);
    }
}
