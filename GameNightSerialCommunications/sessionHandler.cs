using GameNightSerialCommunications.Models;
using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace GameNightSerialCommunications
{
    internal static class SessionHandler
    {
        public static string ToXml(this object obj)
        {
            XmlSerializer s = new XmlSerializer(obj.GetType());
            using (StringWriter writer = new StringWriter())
            {
                s.Serialize(writer, obj);
                return writer.ToString();
            }
        }

        public static T FromXml<T>(this string data)
        {
            XmlSerializer s = new XmlSerializer(typeof(T));
            using (StringReader reader = new StringReader(data))
            {
                object obj = s.Deserialize(reader);
                return (T)obj;
            }
        }

        /// <summary>
        /// Add score to a team session
        /// </summary>
        /// <param name="session"></param>
        /// <param name="score"></param>
        /// <param name="team"></param>
        public static void AddScore(Session session, Score score, int team)
        {
            if (team == 1)
            {
                var resultLocation =session.team1.scores.FindIndex(s => s.question == score.question);
                if (resultLocation != -1)
                {
                    session.team1.scores[resultLocation] = score;
                } else
                {
                    session.team1.scores.Add(score);
                }
            }

            if (team == 2)
            {
                var resultLocation = session.team2.scores.FindIndex(s => s.question == score.question);
                if (resultLocation != -1)
                {
                    session.team2.scores[resultLocation] = score;
                }
                else
                {
                    session.team2.scores.Add(score);
                }
            }
        }
    }
}
