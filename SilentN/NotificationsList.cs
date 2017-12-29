using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sn;
using System.ComponentModel;
using System.Xml;
namespace SilentN
{
    public static class NotificationsList
    {
        public static BindingList<Notification> Notifications = new BindingList<Notification>();

        public static void LoadNotifications(string xml)
        {
            XmlDocument saveFile = new XmlDocument();
            saveFile.LoadXml(xml);

            foreach(XmlNode node in saveFile.SelectNodes("/Notifications/Notification"))
            {
                Notifications.Add(new Notification(
                    Convert.ToInt32(node.SelectSingleNode("ID").InnerText),
                    node.SelectSingleNode("Name").InnerText,
                    Convert.ToInt32(node.SelectSingleNode("Type").InnerText),
                    node.SelectSingleNode("Description").InnerText,
                    new TimeSpan(0,0,0,0,Convert.ToInt32(node.SelectSingleNode("Time").InnerText)),
                    Convert.ToBoolean(Convert.ToInt32(node.SelectSingleNode("IsActive").InnerText)),
                    Convert.ToBoolean(Convert.ToInt32(node.SelectSingleNode("IsRepeating").InnerText)),
                    Convert.ToInt32(node.SelectSingleNode("AlertType").InnerText)
                    ));
            }

        }
        public static void AddNewNotifiction(int id, string name,string description, int type, TimeSpan time, bool isActive, bool isRepeating,int alertType)
        {
            Notifications.Add(new Notification(id, name,type,description,time,isActive,isRepeating, alertType));
        }
        public static Notification NotificationByID(int id)
        {
            foreach(Notification notification in Notifications)
            {
                if (notification.ID == id)
                    return notification;
            }
            return null;
        }
        public static Notification NotificationByName(string name)
        {
            foreach(Notification notifcation in Notifications)
            {
                if (notifcation.Name == name)
                    return notifcation;
            }
            return null;
        }
    }
}
