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
        }




    }
}
