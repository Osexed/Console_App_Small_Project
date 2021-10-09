using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1
{
    class Calculator
    {
        MainMenu menu = new MainMenu();

        public void Calc_Skeleton()
        {
            Console.Title = "Kalkulačka - Hořejší";
            menu.ScreenSettings(menu.height, menu.width);

            Calc_Input();
        }
        private void Calc_Input()
        {
            int top = 10;
            try
            {
                Console.SetCursorPosition((menu.width / 2) - 8, top);
                Console.WriteLine("Kalkulačka");
                Console.SetCursorPosition((menu.width / 2) - 11, top + 1);
                Console.WriteLine("-----------------");

                Console.SetCursorPosition((menu.width / 2) - 10, top + 2);
                Console.WriteLine("Zadej 1. číslo: ");
                Console.SetCursorPosition((menu.width / 2) + 6, top + 2);

                double user_num_1 = double.Parse(Console.ReadLine());




                Console.SetCursorPosition((menu.width / 2) - 10, top + 3);
                Console.WriteLine("Zadej [+,-,*,/]: ");
                Console.SetCursorPosition((menu.width / 2) + 6, top + 3);

                char user_ident = Console.ReadKey().KeyChar;

                Console.SetCursorPosition((menu.width / 2) - 10, top + 4);
                Console.WriteLine("Zadej 2. číslo: ");
                Console.SetCursorPosition((menu.width / 2) + 6, top + 4);

                double user_num_2 = double.Parse(Console.ReadLine());


                bool tada = true; //very important jinak to bude dělat blbosti že se provede matematická operace před zadáním druhého písmene

                if (tada)
                {
                    switch (user_ident)
                    {
                        case '+':
                            Console.SetCursorPosition((menu.width / 2) - 10, top + 5);
                            Calc_Plus(user_num_1, user_num_2);
                            break;
                        case '-':
                            Console.SetCursorPosition((menu.width / 2) - 10, top + 5);
                            Calc_Minus(user_num_1, user_num_2);
                            break;
                        case '/':
                            Console.SetCursorPosition((menu.width / 2) - 10, top + 5);
                            Calc_Dele(user_num_1, user_num_2);
                            break;
                        case '*':
                            Console.SetCursorPosition((menu.width / 2) - 10, top + 5);
                            Calc_Krat(user_num_1, user_num_2);
                            break;
                        default:
                            menu.Wrong();
                            break;
                    }
                }
            }
            catch (FormatException)
            {
                menu.Wrong();
            }
        }

        private void Calc_Plus(double user_num_1, double user_num_2)
        {
            Console.WriteLine($"Výsledek: {user_num_1 + user_num_2}");
            Thread.Sleep(5500);
        }
        private void Calc_Minus(double user_num_1, double user_num_2)
        {
            Console.WriteLine($"Výsledek: {user_num_1 - user_num_2}");
            Thread.Sleep(5500);
        }
        private void Calc_Dele(double user_num_1, double user_num_2)
        {
            Console.WriteLine($"Výsledek: {user_num_1 / user_num_2}");
            Thread.Sleep(5500);
        }
        private void Calc_Krat(double user_num_1, double user_num_2)
        {
            Console.WriteLine($"Výsledek: {user_num_1 * user_num_2}");
            Thread.Sleep(5500);
        }
    }
}
