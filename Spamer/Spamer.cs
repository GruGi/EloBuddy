
namespace SPAM
{
    using System;
    using EloBuddy;
    using EloBuddy.SDK.Events;
    using EloBuddy.SDK.Menu;

    public static class Program
    {
        static void Main(string[] args)
        {

            Loading.OnLoadingComplete += OnLoadingComplete;
        }
        public static Menu EventsMenu;
        private static void OnLoadingComplete(EventArgs args)
        {
            /////////////////////////////////////////////////////
            Chat.Print("Spamer by Grugi");
            Chat.Print("Version 0.0.0");
            Chat.Print("Loaded Successfully");
            /////////////////////////////////////////////////////

            EventsMenu = MainMenu.AddMenu("test", "test");












            Game.OnNotify += eventArgs =>
            {
                if (eventArgs.EventId.Equals(GameEventId.OnChampionKill) && eventArgs.NetworkId == Player.Instance.NetworkId && !Chat.IsOpen && !Shop.IsOpen)
                {
                    Chat.Say("/all ez");
                    Chat.Say("/masterybadge");
                    // Player.DoMasteryBadge();
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

                }
            };
            Game.OnNotify += EventArgs =>
            {
                if (EventArgs.EventId.Equals(GameEventId.OnAce) && EventArgs.NetworkId == Player.Instance.NetworkId && !Chat.IsOpen && !Shop.IsOpen)
                {

                }
            };

        }


    }
}


