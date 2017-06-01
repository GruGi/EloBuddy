using EloBuddy;
using EloBuddy.SDK.Menu;
using EloBuddy.SDK.Menu.Values;

namespace Spamer
{
    internal class Menus
    {
        public static Menu FirstMenu;
        
        

        public static void CreateMenu()
        {
         //
            FirstMenu = MainMenu.AddMenu("Tilter" + Player.Instance.ChampionName, Player.Instance.ChampionName.ToLower() + "Events");
            FirstMenu.AddGroupLabel("Addon by GruGi / Thanks for using it :)");
            FirstMenu.AddLabel("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
            FirstMenu.Add("MinionSpawn", new CheckBox("", true));


            FirstMenu.AddLabel("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");

            
            
         
          
            

            
        
           
        }
    }
}