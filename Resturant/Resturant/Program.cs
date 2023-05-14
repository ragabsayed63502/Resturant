using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using cw = System.Console;

namespace Resturant
{
    enum MenuOptions
    {
        Koshary = 1,
        Pizza,
        Crepe
    }

    enum LoginOptions
    {
        Manger = 1,
        Cashier
    }
    enum MangerOptions
    {

        AddEmployee = 1,
        RemoveEmployee,
        PrintAllEmployee,
        AddNewMenu,
        AddNewItemToMenu,
        RemoveItemfomeMenu,
        PrintAllMenu,
        PrintAllItemInMenu,
        exit

    }
    enum CashierOptions
    {
        NewOrder = 1,
        CancelLastOrder,
        PrintBill,
        logout
    }
    enum AddEmpolyeeOptions
    {
        AddCashier = 1,
    }

    class main
    {
        public static void ShowLoginOptions()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            cw.WriteLine("Login as");
            cw.WriteLine("[1] Manger");
            cw.WriteLine("[2] Cashier");
            cw.WriteLine("[3] exit");
            Console.ForegroundColor = ConsoleColor.Cyan;
            cw.Write("Select your choice: ");
            Console.ForegroundColor = ConsoleColor.Gray;

        }
        public static void ShowMangerOptions()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            cw.WriteLine("[1] Add Employee");
            cw.WriteLine("[2] Remove Employee");
            cw.WriteLine("[3] Print all employee");
            cw.WriteLine("[4] Add new Menu");
            cw.WriteLine("[5] Add new Menu Item");
            cw.WriteLine("[6] Remove Menu Item");
            cw.WriteLine("[7] Print All Menu");
            cw.WriteLine("[8] Print All Item In Menu");
            cw.WriteLine("To logout enter 0");
            Console.ForegroundColor = ConsoleColor.Cyan;
            cw.Write("Select your option : ");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public static void ShowCashierOptions()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            cw.WriteLine("[1] New Order");
            cw.WriteLine("[2] Cancel Last Order");
            cw.WriteLine("[3] Print All Bills");
            cw.WriteLine("[4] Log out");
            Console.ForegroundColor = ConsoleColor.Cyan;
            cw.Write("Select you choice: ");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public static void ShowAddEmpolyeeOptions()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            cw.WriteLine("[1] Add Cashier");
            Console.ForegroundColor = ConsoleColor.Cyan;
            cw.Write("Select your choice: ");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public static Address CreateAddress()
        {
            Address add = new Address();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter your Address");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("Country: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            add.Country = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("City: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            add.City = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("Street: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            add.Street = Console.ReadLine();
            return add;
        }
        public static Cashier AddCashier()
        {
            Cashier cashier = new Cashier();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            cw.Write("Name: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            cashier.Name = cw.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            cw.Write("Type Job: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            cashier.TypeJob = cw.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            cw.Write("UserName: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            cashier.UserName = cw.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            cw.Write("Password: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            cashier.Password = cw.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            cw.Write("Salary: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            cashier.Salary = double.Parse(cw.ReadLine());
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            cw.Write("Start Time: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            cashier.StartTime = cw.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            cw.Write("End Time: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            cashier.EndTime = cw.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            cw.Write("SSN: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            cashier.SSN = cw.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            cw.Write("phone: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            cashier.Phone = cw.ReadLine();
            cashier.Address = CreateAddress();
            return cashier;
        }
        public static Menu KosharyMenu()
        {
            MenuItem item1 = new MenuItem("Humburger", 30);
            MenuItem item2 = new MenuItem("CheeseBurger", 35);
            MenuItem item3 = new MenuItem("CheckinBurger", 45);
            MenuItem item4 = new MenuItem("FishBurger", 50);
            MenuItem item5 = new MenuItem("BigBurger", 60);

            Menu KosharyMenu = new Menu("Burger", 2020);

            KosharyMenu.AddMenu(new List<MenuItem> { item1, item2, item3, item4, item5 });
            return KosharyMenu;
        }
        public static void AddItemToMenu(ref MenuList menuList)
        {
            menuList.PrintAllMenus();
            Console.ForegroundColor = ConsoleColor.Cyan;
            cw.Write("Select menu you want to add the new item to it ");
            Console.ForegroundColor = ConsoleColor.Gray;
            int choice = int.Parse(Console.ReadLine());
            Menu menu = menuList[choice - 1];
            MenuItem item = new MenuItem();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            cw.Write("Enter Item name: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            item.Name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            cw.Write("Enter Item price: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            item.Price = double.Parse(Console.ReadLine());
            menu.AddItemToMenu(item);

        }
        public static void RemoveItemfromMenu(ref MenuList menuList)
        {
            menuList.PrintAllMenus();
            Console.ForegroundColor = ConsoleColor.Cyan;
            cw.Write("Select menu you want to remove the item from it: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            int choice = int.Parse(Console.ReadLine());
            Menu menu = menuList[choice - 1];
            menu.ShowMenue();
            Console.ForegroundColor = ConsoleColor.Cyan;
            cw.Write("Select the item you want to remove it: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            choice = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            cw.WriteLine((menu.DeleteItem(menu[choice - 1]) ? "".PadLeft(20) + "Item removed successfully" : "".PadLeft(20) + "Process Failed"));
        }

        public static void AddMenu(ref MenuList menuList)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            cw.Write("Enter menu Title you want add to list: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            string MenuName = Console.ReadLine();
            Menu NewMenu = menuList.IsFound(MenuName);
            if (NewMenu is null)
            {
                Menu m = new Menu();
                m.Title = MenuName;
                menuList.addMenu(m);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                cw.WriteLine("".PadLeft(20) + "There is a menu with the same name");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }

        public static Menu CrepeMenu()
        {
            MenuItem item1 = new MenuItem("Crepe Romy", 15);
            MenuItem item2 = new MenuItem("Crepe Mozzarella", 15);
            MenuItem item3 = new MenuItem("Crepe Variety Cheese", 20);
            MenuItem item4 = new MenuItem("Crepe Pane chicken", 25);
            MenuItem item5 = new MenuItem("Crepe Shawarma", 37);
            MenuItem item6 = new MenuItem("Crepe Potato", 20);

            Menu CrepeMenu = new Menu("Crepe", 3030);
            CrepeMenu.AddMenu(new List<MenuItem> { item1, item2, item3, item4, item5, item6 });
            return CrepeMenu;
        }
        public static Menu PizzaMenu()
        {
            MenuItem item1 = new MenuItem("Pizza Pastrami", 35);
            MenuItem item2 = new MenuItem("Pizza Sausage", 30);
            MenuItem item3 = new MenuItem("Pizza calamari", 44);
            MenuItem item4 = new MenuItem("Pizza chicken", 30);
            MenuItem item5 = new MenuItem("Pizza Shrimp", 35);
            MenuItem item6 = new MenuItem("Pizza Cheeses", 25);

            Menu PizzaMenu = new Menu("Pizza", 4040);
            PizzaMenu.AddMenu(new List<MenuItem> { item1, item2, item3, item4, item5, item6 });
            return PizzaMenu;
        }
        public static void NewOrderOption(ref MenuList menusList, ref List<Bill> BillList)
        {
            Order newOrder = new Order();
            do
            {
                menusList.PrintAllMenus();
                Console.ForegroundColor = ConsoleColor.Cyan;
                cw.Write("Select Menu you want: ");
                Console.ForegroundColor = ConsoleColor.Gray;
                int menuoption = int.Parse(cw.ReadLine());
                Menu menu = menusList[menuoption - 1];
                menu.ShowMenue();
                do
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    cw.Write("Select Item number: ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    int choice = int.Parse(cw.ReadLine());
                    OrderItem orderItem = new OrderItem(menu[choice - 1]);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    cw.Write("Enter the amount: ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    orderItem.Amount = int.Parse(cw.ReadLine());
                    newOrder.AddOrderItem(orderItem);
                    Console.ForegroundColor = ConsoleColor.Red;
                    cw.Write("Add more ? (y / n): ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                } while (cw.ReadLine() == "y");
                Console.ForegroundColor = ConsoleColor.Red;
                cw.Write("do you want menus again ? (y / n): ");
                Console.ForegroundColor = ConsoleColor.Gray;
            } while (cw.ReadLine() == "y");

            Bill bill = new Bill(newOrder);
            bill.ShowBill();
            Console.ForegroundColor = ConsoleColor.Red;
            cw.Write("Submit Process ? (y / n): ");
            Console.ForegroundColor = ConsoleColor.Gray;
            if (cw.ReadLine() == "y")
            {
                BillList.Add(bill);
            }
        }
        public static void CashierLogin(ref EmployeeList employeeList, ref MenuList menusList, ref List<Bill> BillList)
        {
            string password;
            string username;
            Cashier cashier;
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                cw.Write($"\n{"Username".PadLeft(30)} : ");
                Console.ForegroundColor = ConsoleColor.Gray;
                username = cw.ReadLine();
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                cw.Write($"\n{"Password".PadLeft(30)} : ");
                Console.ForegroundColor = ConsoleColor.Gray;
                password = cw.ReadLine();
                cashier = employeeList.vaildCashir(username, password);
                int ix = 0;
                if (cashier is null)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    cw.WriteLine("".PadLeft(40) + "Invalid username or password");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else
                {
                    cw.WriteLine("".PadLeft(40) + $"HI {cashier.Name}");
                    CashierOptions cashierOption;
                    do
                    {
                        ShowCashierOptions();
                        try
                        {
                            cashierOption = (CashierOptions)int.Parse(cw.ReadLine());
                            switch (cashierOption)
                            {
                                case CashierOptions.NewOrder:
                                    {
                                        NewOrderOption(ref menusList, ref BillList);
                                    }
                                    break;
                                case CashierOptions.CancelLastOrder:
                                    {
                                        if (BillList.Count == 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            cw.WriteLine("There is no any Bills");
                                            Console.ForegroundColor = ConsoleColor.Gray;
                                        }
                                        else cw.WriteLine(BillList.Remove(BillList[BillList.Count - 1]) ? "Process Succeeded" : "Process Failed");
                                    }
                                    break;
                                case CashierOptions.PrintBill:
                                    {
                                        if (BillList.Count == 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            cw.WriteLine("There is no bills yet");
                                            Console.ForegroundColor = ConsoleColor.Gray;
                                        }
                                        else
                                        {
                                            for (int i = 0; i < BillList.Count; i++)
                                            {
                                                BillList[i].ShowBill();
                                            }
                                        }
                                    }
                                    break;
                                case CashierOptions.logout:
                                 { 
                                   ix = 4;
                                   } 
                                    break;
                                default:
                                    break;
                            }
                        }
                        catch (Exception e)
                        {
                            cw.WriteLine(e.Message);

                        }
                        
                        //Console.Clear();

                    } while (ix != 4);
                }
                Console.ForegroundColor = ConsoleColor.Red;
                cw.Write("Do you want exit from log in Cashier (y / n) : ");
                Console.ForegroundColor = ConsoleColor.Gray;
            } while (checkYesNo());

        }

        public static void MangerLogin(ref EmployeeList employeeList, ref MenuList menusList)
        {
            Manger admin = new Manger();
            {
                string password;
                string username;
                string x;
                do
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    cw.Write($"\n{"Username".PadLeft(30)} : ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    username = cw.ReadLine();
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    cw.Write($"\n{"Password".PadLeft(30)} : ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    password = cw.ReadLine();
                    if (password != admin.Password || username != admin.UserName)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        cw.WriteLine("Invalid username or password");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                    }
                    else
                    {
                        do
                        {
                            Console.Clear();
                            cw.WriteLine("".PadLeft(40) + $"HI {admin.Name}");
                            ShowMangerOptions();
                            MangerOptions mangerOption = (MangerOptions)int.Parse(cw.ReadLine());
                            switch (mangerOption)
                            {
                                case MangerOptions.AddEmployee:
                                    {
                                        ShowAddEmpolyeeOptions();
                                        AddEmpolyeeOptions addEmpolyeeOption = (AddEmpolyeeOptions)int.Parse(cw.ReadLine());
                                        switch (addEmpolyeeOption)
                                        {
                                            case AddEmpolyeeOptions.AddCashier:
                                                employeeList.AddEmployee(AddCashier());
                                                break;
                                            default:
                                                break;
                                        }
                                    }

                                    break;
                                case MangerOptions.RemoveEmployee:
                                    {
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        cw.WriteLine("Enter SSN to Remove Employee:");
                                        Console.ForegroundColor = ConsoleColor.Gray;

                                        bool istrue = employeeList.RemoveEmployee(cw.ReadLine());
                                        if (istrue)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            cw.WriteLine("success operation");
                                            Console.ForegroundColor = ConsoleColor.Gray;
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            cw.WriteLine("Failed");
                                            Console.ForegroundColor = ConsoleColor.Gray;
                                        }
                                    }
                                    break;
                                case MangerOptions.PrintAllEmployee:
                                    {
                                        employeeList.PrintAllEmployee();
                                    }
                                    break;
                                case MangerOptions.AddNewMenu:
                                    {
                                        AddMenu(ref menusList);
                                    }
                                    break;
                                case MangerOptions.AddNewItemToMenu:
                                    {
                                        AddItemToMenu(ref menusList);
                                    }
                                    break;
                                case MangerOptions.RemoveItemfomeMenu:
                                    {
                                        RemoveItemfromMenu(ref menusList);
                                    }
                                    break;
                                case MangerOptions.PrintAllMenu:
                                    {
                                        menusList.PrintAllMenus();
                                    }
                                    break;
                                case MangerOptions.PrintAllItemInMenu:
                                    {
                                        menusList.PrintAllMenus();
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        cw.Write("Select menu you want: ");
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        int choice = int.Parse(Console.ReadLine());
                                        menusList[choice - 1].ShowMenue();
                                    }
                                    break;

                                default:
                                    break;
                            }
                            Console.ForegroundColor = ConsoleColor.Red;
                            cw.Write("Do you want any thing else (y / n) : ");
                            Console.ForegroundColor = ConsoleColor.Gray;
                        } while (cw.ReadLine() == "y");
                    }
                    Console.ForegroundColor = ConsoleColor.Red;
                    cw.Write("Do you want exit from log in Manger (y / n) : ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                } while (cw.ReadLine() != "y");
            }
        }
        public static bool checkYesNo()
        {
            bool ok = false;
            string str;
            bool ex = true;
            do
            {
                str = cw.ReadLine();
                if (str == "n" || str == "y")
                {
                    if (str == "y")
                    {
                        ok = false;
                        break;
                    }
                    else if (str == "n")
                    {
                        ok = true;
                        break;
                    }

                }
                else
                {
                    cw.WriteLine("You must enter y or n");
                    ex = false;
                }
            } while (!ex);
            return ok;
        }
        
        public static void start()
        {
            #region Bill List
            var BillList = new List<Bill>();
            #endregion

            #region Created Menus
            var menusList = new MenuList();
            menusList.addMenu(CrepeMenu());
            menusList.addMenu(KosharyMenu());
            menusList.addMenu(PizzaMenu());
            #endregion

            #region Created Cashier
            var employeeList = new EmployeeList();
            Cashier cashier = new Cashier();
            cashier.Address = new Address();
            cashier.Name = "Ali";
            cashier.TypeJob = "Cashier";
            cashier.UserName = "ali123";
            cashier.Salary = 1200.0;
            cashier.Password = "123";
            cashier.SSN = "123456789";

            cashier.Address.Country = "Egypt";
            cashier.Address.City = "Luxor";
            cashier.Address.Street = "TV";

            employeeList.AddEmployee(cashier);
            Cashier cashier2 = new Cashier();
            cashier2.TypeJob = "Cashier";
            cashier2.Name = "Mahmoud";
            cashier2.UserName = "Mahmoud123";
            cashier2.Password = "123";
            cashier2.Salary = 1200.0;
            cashier2.SSN = "123456789";
            cashier.Address.Country = "Egypt";
            cashier.Address.City = "Quna";
            cashier.Address.Street = "rt";
            employeeList.AddEmployee(cashier);
            #endregion
            bool ok = false;
            do
            {
                Console.Clear();
                ShowLoginOptions();
                LoginOptions loginOptions;

                try {

                    loginOptions = (LoginOptions)int.Parse(cw.ReadLine());
                    switch (loginOptions)
                    {
                        case LoginOptions.Manger:
                            MangerLogin(ref employeeList, ref menusList);
                            break;
                        case LoginOptions.Cashier:
                            CashierLogin(ref employeeList, ref menusList, ref BillList);
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception e)                
                {
                    cw.WriteLine(e.Message);
                }     

                Console.ForegroundColor = ConsoleColor.Red;
                cw.Write("Do you want to Exit from program (y / n): ");
                Console.ForegroundColor = ConsoleColor.Gray;
            } while (checkYesNo());
        }
        static void Main(string[] args)
        {
            start();
        }
    }

}



