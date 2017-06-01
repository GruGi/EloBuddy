using System;
using EloBuddy;
using EloBuddy.SDK.Events;


namespace SPAM
{


    public static class Program
    {
        public static void Main(string[] args)
        {

            Loading.OnLoadingComplete += OnLoadingComplete;
        }
        
    
        private static void OnLoadingComplete(EventArgs args)
        {
            Game.OnNotify += eventArgs =>
            {
                if (eventArgs.EventId.Equals(GameEventId.OnChampionKill) && eventArgs.NetworkId == Player.Instance.NetworkId && !Chat.IsOpen && !Shop.IsOpen)
                {
                    Chat.Say("/all ez");
                    Chat.Say("/masterybadge");

                }
            };
            Game.OnNotify += EventArgs =>
            {
                if (EventArgs.EventId.Equals(GameEventId.OnChampionDie) && EventArgs.NetworkId == Player.Instance.NetworkId && !Chat.IsOpen && !Shop.IsOpen)
                {

                    Chat.Say("/all OMG LAG");
                    Chat.Say("/ff");
                    Chat.Say("/masterybadge");


                }
            };
            Game.OnNotify += EventArgs =>
            {
                if (EventArgs.EventId.Equals(GameEventId.OnSurrenderFailedVotes) && EventArgs.NetworkId == Player.Instance.NetworkId && !Chat.IsOpen && !Shop.IsOpen)
                {
                    Chat.Say("plz go surr");



                }
            };
            Game.OnNotify += EventArgs =>
            {
                if (EventArgs.EventId.Equals(GameEventId.OnSurrenderVoteAlready) && EventArgs.NetworkId == Player.Instance.NetworkId && !Chat.IsOpen && !Shop.IsOpen)
                {
                    Chat.Say("/all REPORT MY TEAM");


                }
            };
            Game.OnNotify += EventArgs =>
            {
                if (EventArgs.EventId.Equals(GameEventId.OnKillDragon) && EventArgs.NetworkId == Player.Instance.NetworkId && !Chat.IsOpen && !Shop.IsOpen)
                {
                    Chat.Say("Good Job");



                }
            };
            Game.OnNotify += EventArgs =>
            {
                if (EventArgs.EventId.Equals(GameEventId.OnKillDragonSteal) && EventArgs.NetworkId == Player.Instance.NetworkId && !Chat.IsOpen && !Shop.IsOpen)
                {
                    Chat.Say("/all Report jungler ");



                }
            };
            Game.OnNotify += EventArgs =>
            {
                if (EventArgs.EventId.Equals(GameEventId.OnMinionsSpawn) && EventArgs.NetworkId == Player.Instance.NetworkId && !Chat.IsOpen && !Shop.IsOpen)
                {
                    Chat.Say("/all CHARGE MY MINIONS!!!");



                }
            };
            Game.OnNotify += EventArgs =>
            {
                if (EventArgs.EventId.Equals(GameEventId.OnFirstBlood) && EventArgs.NetworkId == Player.Instance.NetworkId && !Chat.IsOpen && !Shop.IsOpen)
                {
                    Chat.Print("");

                }
            };






         }


    }
}

