using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagerApp.Classes
{
    public class ShowMenu
    {
        private static ShowMenu showmenu;

        private ShowMenu()
        {
        }

        public static ShowMenu GetInstance()
        {
            if (showmenu == null)
            {
                showmenu = new ShowMenu();
            }
            return showmenu;
        }
        public MenuForm menu = null;
        public void showMainForm(MenuForm fm)
        {
            menu = fm;
            menu.Enabled = false;
        }
    }
}
