using GameNightSerialCommunications.Models;
using System;
using System.IO;
using System.Linq;
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

        /// <summary>
        /// Get the latest question
        /// </summary>
        /// <param name="session"></param>
        /// <returns></returns>
        internal static int GetLatestQuestion(Session session)
        {
            var scores1 = session.team1.scores;
            var scores2 = session.team2.scores;

            var question1 = scores1.Count > 0 ? scores1.Max(t => t.question) : 0;
            var question2 = scores2.Count > 0 ?scores2.Max(t => t.question) : 0;
                       
            return question1 > question2 ? question1 : question2;
        }

        /// <summary>
        /// Get the total score for a team
        /// </summary>
        /// <param name="team"></param>
        /// <param name="session"></param>
        /// <returns></returns>
        internal static int GetScoreForTeam(int team, Session session)
        {
            if (team == 1)
            {
                var scores = session.team1.scores;
                int returnValue = 0;
                foreach(Score score in scores)
                {
                    returnValue += score.points;
                }

                return returnValue;
            }
            if ( team == 2)
            {
                var scores = session.team2.scores;
                int returnValue = 0;
                foreach (Score score in scores)
                {
                    returnValue += score.points;
                }

                return returnValue;
            }
            return 0;
        }
    }
}
