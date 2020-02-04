using System;

namespace GameNightSerialCommunications.Models
{
    [Serializable]
    public class Score
    {
        public int question;
        public int points;
        public int miliseconds;
        public int fastest;
    }
}
