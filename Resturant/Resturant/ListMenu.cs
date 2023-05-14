using System;
using System.Collections.Generic;
using System.Text;
using cw = System.Console;

namespace Resturant
{
    internal class MenuList
    {
        List<Menu> ListMenues = new List<Menu>();

        public Menu this[int idx]
        {
            get
            {
                return ListMenues[idx];
            }
        }
        public void addMenu(Menu menu)
        {
            ListMenues.Add(menu);
            //Console.WriteLine("success operation");
        }


        public Menu IsFound(string nameMenu)
        {
            //Console.WriteLine(ListMenues.Count);

            for (int i = 0; i < ListMenues.Count; i++)
            {
                if (ListMenues[i].Title == nameMenu)
                    return ListMenues[i];
            }
            return null;
        }


        public void PrintAllMenus()
        {
            cw.WriteLine("".PadLeft(30) + "------------------------");
            cw.WriteLine("".PadLeft(30) + "|        Menus         |");
            cw.WriteLine("".PadLeft(30) + "------------------------");
            for (int i = 0; i < ListMenues.Count; i++)
            {
                Console.WriteLine("".PadLeft(30) + $"[{i + 1}]{"".PadRight(6)}{ListMenues[i].ToString().PadRight(14)}|");
            }
            cw.WriteLine("".PadLeft(30) + "------------------------");


        }
    }
}
