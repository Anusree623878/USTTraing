using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallengeTeamPlayer
{
    public class Team
    {
        private string _playerName;
        public string PlayerName

        {

            get { return _playerName; }

            set { _playerName = value; }

        }

        private string _teamName;
        public string TeamName

        {

            get { return _teamName; }

            set { _teamName = value; }

        }

        private long _raidPoints;

        public long RaidPoints

        {

            get { return _raidPoints; }

            set { _raidPoints = value; }

        }

        public Team(string pn, string tn, long po)

        {

            this.PlayerName = pn;

            this.TeamName = tn;

            this.RaidPoints = po;

        }
    }

}

