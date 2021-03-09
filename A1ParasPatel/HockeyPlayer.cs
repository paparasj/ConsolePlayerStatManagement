﻿using System;
using System.Collections.Generic;
using System.Text;

namespace A1ParasPatel
{
    class HockeyPlayer : Player
    {
        private int _assists;

        public int Assists
        {
            get { return _assists; }
            set { _assists = value; }
        }
        private int _goals;

        public int Goals
        {
            get { return _goals; }
            set { _goals = value; }
        }

        public HockeyPlayer(int playerId, PlayerType playerType, string playerName, string teamName,
            int gamesPlayed, int assists, int goals) : base(playerId, playerType, playerName, teamName, gamesPlayed)
        {
            Assists = assists;
            Goals = goals;
        }
        /*overriding the base class abstract method*/
        public override int Points()
        {
            return Assists + (2 * Goals);
        }

        public override string ToString()
        {
            return base.ToString() + $"\t{Assists,+11}\t{Goals,+14}\t{Points(),+6}";
        }

    }

}
