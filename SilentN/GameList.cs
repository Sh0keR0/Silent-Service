using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sn;
using ProcessManager;
using System.Xml;
namespace SilentN
{
    public static class GameList // handle the games list and some useful functions
    {
        public static List<Game> Games = new List<Game>();
        public static void LoadGames(string xmlData)
        {
            XmlDocument DataXml = new XmlDocument();
            DataXml.LoadXml(xmlData);
            foreach(XmlNode node in DataXml.SelectNodes("/Games/Game"))
            {
                int id = Convert.ToInt32(node.SelectSingleNode("ID").InnerText);
                string name = node.SelectSingleNode("Name").InnerText;
                string processName = node.SelectSingleNode("Process").InnerText;
                int timeSpamSeconds = Convert.ToInt32(node.SelectSingleNode("TimeSpan").InnerText);
                Games.Add(new Game(id, name, new ProcessLog(processName, new TimeSpan(0,0,timeSpamSeconds))));
                
            }
        }
        public static void AddNewGame(string GameName, string GameProcess)
        {
            Games.Add(new Game(Games.Count+1,GameName, new ProcessLog(GameProcess, new TimeSpan())));
        }
        public static void RemoveGame(Game game)
        {
            Games.Remove(game);
        }
        public static Game GameByID(int id)
        {
            foreach(Game game in Games)
            {
                if (game.ID == id)
                    return game;
            }
            return null;
        }
        public static Game GameByName(string name)
        {
            foreach(Game game in Games)
            {
                if (game.Name == name)
                    return game;
            }
            return null;
        }
    }
}
