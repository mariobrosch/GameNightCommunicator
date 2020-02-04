using GameNightSerialCommunications.Models;
using System;

namespace GameNightSerialCommunications
{
    [Serializable]
    public class Session
    {
        public Team team1;
        public Team team2;

        public Session ShallowCopy()
        {
            return (Session)MemberwiseClone();
        }
    }


}
