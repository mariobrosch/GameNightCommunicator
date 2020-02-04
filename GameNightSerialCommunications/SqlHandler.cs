using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace GameNightSerialCommunications
{
    internal static class SqlHandler
    {
        private static readonly string cs = @"server=" + config.dbLocation
            + "; Port=" + config.dbPort
            + "; userid=" + config.dbUsername
            + "; password=" + config.dbPassword
            + "; database=" + config.dbName;

        internal static void writeSessionToDb(Session session)
        {
            var con = new MySqlConnection(cs);
            con.Open();

            cleanCurrentDb(con);

            writeTeamDataToDb(1, session.team1, con);
            writeTeamDataToDb(2, session.team2, con);

            con.Close();
        }

        private static void writeTeamDataToDb(int id, Models.Team team, MySqlConnection con)
        {
            // insert team
            var query = "INSERT INTO team (id, name, com) VALUES ('" + id.ToString() + "', '" + team.teamName + "', '" + team.comPortUsed + "')";
            var cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();

            query = "INSERT INTO score (fastest, miliseconds, points, question, team) VALUES ";
            var scores = new string[team.scores.Count];
            var counter = 0;
            team.scores.ForEach(score =>
            {
                scores[counter] = "('" + score.fastest + "', '" + score.miliseconds + "', '" + score.points + "','" + score.question + "','" + id.ToString() + "')";
                counter++;
            });
            query += string.Join(", ", scores);
            cmd = new MySqlCommand(query, con);
            if (counter > 0)
            {
                cmd.ExecuteNonQuery();
            }
        }

        private static void cleanCurrentDb(MySqlConnection con)
        {
            var stm = "TRUNCATE score";
            var cmd = new MySqlCommand(stm, con);
            cmd.ExecuteNonQuery();

            stm = "TRUNCATE team";
            cmd = new MySqlCommand(stm, con);
            cmd.ExecuteNonQuery();
        }
    }
}
