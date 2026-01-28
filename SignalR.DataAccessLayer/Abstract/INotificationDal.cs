using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SignalR.DataAccessLayer.Abstract
{
    public interface INotificationDal : IGenericDal<Notification>
    {
        int NotificationCountByStatusFalse();
        List<Notification> GetAllNotificationByFalse();
        void NotificationStatusChangeToTrue(int id);
        void NotificationStatusChangeToFalse(int id);
    }
}
