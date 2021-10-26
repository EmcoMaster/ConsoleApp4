using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp4
{
    interface Menu
    {

       
        public class program
        {
            
            public void TestMethod1()
            {
                InitializeComponent();
                mainMenu = new MainMenu();
                MenuItem File = mainMenu.MenuItems.Add("&File");
                File.MenuItems.Add(new MenuItem("&New"));
                File.MenuItems.Add(new MenuItem("&Open"));
                File.MenuItems.Add(new MenuItem("&Exit"));
                this.Menu = mainMenu;
                MenuItem About = mainMenu.MenuItems.Add("&About");
                About.MenuItems.Add(new MenuItem("&About"));
                this.Menu = mainMenu;
                mainMenu.GetForm().BackColor = Color.Indigo;


            }

            private void InitializeComponent()
            {
                throw new NotImplementedException();
            }
        }
    }
}

