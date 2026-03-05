using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repositories;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EfDiscountDal : GenericRepository<Discount>, IDiscountDal
    {
        public EfDiscountDal(SignalRContext context) : base(context)
        {
        }

        public void ChangeStatusToFalse(int id)
        {
            var context = new SignalRContext();
            var values = context.Discounts.Find(id);
            if (values != null)
            {
                values.Status = false;
                context.SaveChanges();
            }
        }

        public void ChangeStatusToTrue(int id)
        {
            var context = new SignalRContext();
            var values = context.Discounts.Find(id);
            if (values != null)
            {
                values.Status = true;
                context.SaveChanges();
            }
        }
    }
}
