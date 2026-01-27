using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SignalR.DataAccessLayer.Abstract
{
    public interface IBasketDal : IGenericDal<Basket>
    {
        List<Basket> GetBasketByTableNumber(int id);
        List<Basket> GetBasketListByMenuTableWithProductName(int id);
    }
}
