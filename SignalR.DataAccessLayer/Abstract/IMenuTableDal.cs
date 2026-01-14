using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SignalR.DataAccessLayer.Abstract
{
    public interface IMenuTableDal :IGenericDal<MenuTable>
    {
        int MenuTableCount();
    }
}
