using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace WindowsForms_TicTacToe.TicTacToe_Game
{
    internal class FileWorker
    {
        private const string fileName = "PlayersInfo.xml";

        public bool SaveToXMLFile(List<PlayerInfo> players)
        {
            if (players.Count > 0)
            {
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<PlayerInfo>));

                    using (FileStream stream = File.Open(fileName, FileMode.OpenOrCreate))
                    {
                        serializer.Serialize(stream, players);
                    }

                    return true;
                }
                catch (Exception exc)
                {

                }
            }
            else
            {
                return false;
            }

            return false;
        }

        public bool ReadFromXMLFile(List<PlayerInfo> players)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(fileName);
                XmlNodeList playersInfoNode = xmlDoc.GetElementsByTagName("PlayerInfo", xmlDoc.DocumentElement.NamespaceURI);

                foreach (XmlNode node in playersInfoNode)
                {
                    players.Add(new PlayerInfo { Nickname = node["Nickname"].InnerText, GameLevel = node["GameLevel"].InnerText, GameResult = node["GameResult"].InnerText });
                }

                return true;
            }
            catch (Exception exc)
            {

            }

            return false;
        }
    }
}