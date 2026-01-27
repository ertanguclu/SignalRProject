using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SignalR.BusinessLayer.Concrete
{
    public class BasketManager : IBasketService
    {
        private readonly IBasketDal _basketDal;

        public BasketManager(IBasketDal basketDal)
        {
            _basketDal = basketDal;
        }

        public void TAdd(Basket entity)
        {
            _basketDal.Add(entity);
        }

        public void TDelete(Basket entity)
        {
            _basketDal.Delete(entity);
        }

        public List<Basket> TGetBasketByTableNumber(int id)
        {
            return _basketDal.GetBasketByTableNumber(id);
        }

        public List<Basket> TGetBasketListByMenuTableWithProductName(int id)
        {
            return _basketDal.GetBasketListByMenuTableWithProductName(id);
        }

        public Basket TGetById(int id)
        {
            return _basketDal.GetById(id);
        }

        public List<Basket> TGetListAll()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Basket entity)
        {
            throw new NotImplementedException();
        }
    }
}
