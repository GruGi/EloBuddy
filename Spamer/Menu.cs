using EloBuddy.SDK.Menu;



namespace SPAM
{
    public static class MENU
    {
        private const string MenuName = "TEST";

        private static readonly Menu Menu;

        static MENU()
        {
            
            Menu = MainMenu.AddMenu(MenuName, MenuName.ToLower());

            Menu.AddGroupLabel("TEST");

            Menu.AddLabel("TEST");

            Menu.AddLabel("TEST");



        }

    }

}