using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using ProcessManager;
using sn;

namespace SilentN
{
    public static class SaveFile
    {
      public const string  SaveFileName = "Data.xml";
      public static string SaveFilePath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SilentService");
      public static string NotificatinosSaveFileName = "Notifications.xml";

        public static void SaveDataToFile() // Save the games list to xml file
        {
            XmlDocument saveFile = new XmlDocument();
            XmlNode gamesList = saveFile.CreateElement("Games");
            saveFile.AppendChild(gamesList);
            foreach(Game gameList in GameList.Games)
            {
              XmlNode game = saveFile.CreateElement("Game");

              XmlNode GameID = saveFile.CreateElement("ID");
              GameID.AppendChild(saveFile.CreateTextNode(gameList.ID.ToString()));
              game.AppendChild(GameID);

              XmlNode GameName = saveFile.CreateElement("Name");
              GameName.AppendChild(saveFile.CreateTextNode(gameList.Name));
              game.AppendChild(GameName);

              XmlNode GameProcess = saveFile.CreateElement("Process");
              GameProcess.AppendChild(saveFile.CreateTextNode(gameList.GameProcess.ProcessName));
              game.AppendChild(GameProcess);

              XmlNode GameTimeSpan = saveFile.CreateElement("TimeSpan");
              GameTimeSpan.AppendChild(saveFile.CreateTextNode(Math.Round(gameList.GameProcess.GetTime.TotalSeconds).ToString()));
              game.AppendChild(GameTimeSpan);

              gamesList.AppendChild(game);
            }
            if (!Directory.Exists(SaveFilePath))
                System.IO.Directory.CreateDirectory(SaveFilePath);

            File.WriteAllText(SaveFilePath + "\\" + SaveFileName, saveFile.InnerXml);
        }
            
        public static void SaveNotificationsToFile()
        {
            XmlDocument saveFile = new XmlDocument();
            XmlNode notificationsList = saveFile.CreateElement("Notifications");
            saveFile.AppendChild(notificationsList);

            foreach(Notification n in NotificationsList.Notifications)
            {
                XmlNode notification = saveFile.CreateElement("Notification");

                XmlNode notificationID = saveFile.CreateElement("ID");
                notificationID.AppendChild(saveFile.CreateTextNode(n.ID.ToString()));
                notification.AppendChild(notificationID);

                XmlNode notificationName = saveFile.CreateElement("Name");
                notificationName.AppendChild(saveFile.CreateTextNode(n.Name));
                notification.AppendChild(notificationName);

                XmlNode notificationType = saveFile.CreateElement("Type");
                notificationType.AppendChild(saveFile.CreateTextNode(n.Type.ToString()));
                notification.AppendChild(notificationType);

                XmlNode notificationDescription = saveFile.CreateElement("Description");
                notificationDescription.AppendChild(saveFile.CreateTextNode(n.Description));
                notification.AppendChild(notificationDescription);

                XmlNode notificationTime = saveFile.CreateElement("Time");
                notificationTime.AppendChild(saveFile.CreateTextNode(Math.Round(n.Time.TotalMilliseconds).ToString()));
                notification.AppendChild(notificationTime);

                XmlNode notificationIsActive = saveFile.CreateElement("IsActive");
                notificationIsActive.AppendChild(saveFile.CreateTextNode(Convert.ToInt32(n.IsActive).ToString()));
                notification.AppendChild(notificationIsActive);

                XmlNode notificationIsRepeating = saveFile.CreateElement("IsRepeating");
                notificationIsRepeating.AppendChild(saveFile.CreateTextNode(Convert.ToInt32(n.IsRepeating).ToString()));
                notification.AppendChild(notificationIsRepeating);

                XmlNode notificationAlertType = saveFile.CreateElement("AlertType");
                notificationAlertType.AppendChild(saveFile.CreateTextNode(n.AlertType.ToString()));
                notification.AppendChild(notificationAlertType);

                notificationsList.AppendChild(notification);
            } 

            if (!Directory.Exists(SaveFilePath))
                    System.IO.Directory.CreateDirectory(SaveFilePath);

                File.WriteAllText(SaveFilePath + "\\" + NotificatinosSaveFileName, saveFile.InnerXml);
        }
    }
}
