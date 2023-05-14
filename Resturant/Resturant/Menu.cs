using System;
using System.Collections.Generic;
using System.Text;

namespace Resturant
{
    internal class Menu
    {
        private List<MenuItem> MenuItems = new List<MenuItem>();
        private static int Cnt = 1;
        private int Id;
        public string Title { get; set; }


        public Menu()
        {
            this.Id = Cnt++;
        }

        public Menu(string title, int id)
        {
            Id = id;
            Title = title;
        }

        public MenuItem this[int idx]
        {
            get
            {
                return MenuItems[idx];

            }
            set
            {
                MenuItems[idx] = value;
            }
        }

        public MenuItem? getItemByName(string name)
        {
            for (int i = 0; i < MenuItems.Count; i++)
            {
                if (MenuItems[i].Name == name)
                    return MenuItems[i];
            }
            return null;
        }

        public void AddMenu(List<MenuItem> newMenu)
        {
            MenuItems.AddRange(newMenu);
        }


        public void AddItemToMenu(MenuItem newMenuItem)
        {
            MenuItems.Add(newMenuItem);
        }

        public bool DeleteItem(MenuItem item)
        {
            for (int i = 0; i < MenuItems.Count; i++)
            {
                if (MenuItems[i] == item)
                {
                    MenuItems.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
        public void ShowMenue()
        {
            MenuItems.Sort();
            Console.WriteLine("".PadLeft(20) + "--------------------------------------------");
            Console.WriteLine("".PadLeft(20) + $"|{"Name".PadLeft(15)}{"|".PadLeft(11)} {"Price".PadLeft(10)}{"|".PadLeft(6)}");
            Console.WriteLine("".PadLeft(20) + "--------------------------------------------");
            for (int i = 0; i < MenuItems.Count; i++)
            {
                Console.WriteLine("".PadLeft(20) + $"[{i + 1}] {MenuItems[i]}");
            }
            Console.WriteLine("".PadLeft(20) + "--------------------------------------------");


        }
        public override string ToString()
        {
            return $"{Title}";
        }

    }
}
