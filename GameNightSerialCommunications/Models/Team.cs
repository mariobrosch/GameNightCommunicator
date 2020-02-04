using System;
using System.Collections.Generic;

namespace GameNightSerialCommunications.Models
{
    [Serializable]
    public class Team
    {
        public string teamName;
        public List<Score> scores;
        public string comPortUsed;
    }
}
