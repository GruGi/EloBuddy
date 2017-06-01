using EloBuddy;
using EloBuddy.SDK.Menu;
using EloBuddy.SDK.Menu.Values;

namespace Spamer
{
    internal class Menus
    {
        public static Menu FirstMenu;
        public static Menu EventsMenu;
        

        public static void CreateMenu()
        {
         //
            FirstMenu = MainMenu.AddMenu(Player.Instance.ChampionName, Player.Instance.ChampionName.ToLower() + "Events");
           
           
         //
            EventsMenu = FirstMenu.AddSubMenu("Events");
          
          
            

            
        
           
        }
    }
}