using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1
{
    class NumberGuessing
    {
        MainMenu menu = new MainMenu();
        Random ran = new Random();
        private bool diff_1 = false;
        private bool diff_2 = false;
        private bool diff_3 = false;
        public void Guess_Skeleton()
        {
            Console.Title = "Hádání čísla - Hořejší";
            menu.ScreenSettings(menu.height, menu.width);

            int top = 10;

            Console.SetCursorPosition((menu.width / 2) - 8, top);
            Console.WriteLine("Hádání čísla");
            Console.SetCursorPosition((menu.width / 2) - 11, top + 1);
            Console.WriteLine("-----------------");

            Console.SetCursorPosition((menu.width / 2) - 10, top + 2);
            Console.WriteLine("1. Hádání 1-10");

            Console.SetCursorPosition((menu.width / 2) - 10, top + 3);
            Console.WriteLine("2. Hádání 1-30");

            Console.SetCursorPosition((menu.width / 2) - 10, top + 4);
            Console.WriteLine("3. Hádání 1-50");

            Ask_Diff();
            Guess_Diff_Picked();

        }
        private void Ask_Diff()
        {
            int top = 10;
            try
            {
                Console.SetCursorPosition((menu.width / 2) - 11, top + 5);
                Console.WriteLine("-----------------");
                Console.SetCursorPosition((menu.width / 2) - 10, top + 6);
                Console.WriteLine("Vyber:");
                Console.SetCursorPosition((menu.width / 2) - 3, top + 6);
                int user_pick_guess = int.Parse(Console.ReadLine());

                switch (user_pick_guess)
                {
                    case 1:
                        diff_1 = true;
                        break;
                    case 2:
                        diff_2 = true;
                        break;
                    case 3:
                        diff_3 = true;
                        break;
                    default:
                        menu.Wrong();
                        break;
                }
            }
            catch (FormatException)
            {
                menu.Wrong();
            }
        }
        private void Guess_Diff_Picked()
        {
            if (diff_1 == true)
            {
                Guess_Diff_1();
            }
            else if (diff_2 == true)
            {
                Guess_Diff_2();
            }
            else if (diff_3 == true)
            {
                Guess_Diff_3();
            }
        }
        private void Guess_Diff_1()
        {
            int top = 10;
            int pokusy = 5;
            while (diff_1)
            {
                pokusy--;
                Console.Clear();
                bool cyklus = true;
                int ran_hodn = ran.Next(1, 11);
                int user_guess = 0;

                while (cyklus)
                {
                    try
                    {
                        Console.SetCursorPosition((menu.width / 2) - 8, top);
                        Console.WriteLine("Hádání 1-10");
                        Console.SetCursorPosition((menu.width / 2) - 11, top + 1);
                        Console.WriteLine("-----------------");
                        Console.SetCursorPosition((menu.width / 2) - 10, top + 2);
                        Console.WriteLine($"Pokusy (zbývající):{pokusy}");
                        Console.SetCursorPosition((menu.width / 2) - 10, top + 3);
                        Console.WriteLine("Hádej: ");
                        Console.SetCursorPosition((menu.width / 2) - 3, top + 3);

                        user_guess = int.Parse(Console.ReadLine());



                        if (user_guess > 0 && user_guess < 11)
                        {
                            cyklus = false;
                        }
                        else
                        {
                            Console.Clear();
                            Console.SetCursorPosition((menu.width / 2) - 25, top);
                            Console.WriteLine("Něco si zadal špatně ale neboj pokus jsi neztratil :)");
                            Console.SetCursorPosition((menu.width / 2) - 25, top + 1);
                            Console.WriteLine("(zmáčkni libovolnou klávesu)");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }
                    catch (FormatException)
                    {
                        Console.Clear();
                        Console.SetCursorPosition((menu.width / 2) - 25, top);
                        Console.WriteLine("Něco si zadal špatně ale neboj pokus jsi neztratil :)");
                        Console.SetCursorPosition((menu.width / 2) - 25, top + 1);
                        Console.WriteLine("(zmáčkni libovolnou klávesu)");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }

                    if (user_guess==ran_hodn)
                    {
                        Console.SetCursorPosition((menu.width / 2) - 10, top + 5);
                        Console.WriteLine("Uhádl jsi!");
                        Thread.Sleep(2500);
                        Console.Clear();
                    }
                    else
                    {
                        Console.SetCursorPosition((menu.width / 2) - 10, top + 5);
                        Console.WriteLine("Špatně! Zkus to znovu!");
                        Thread.Sleep(2500);
                        Console.Clear();
                    }
                    if (pokusy == 0)
                    {
                        Console.Clear();
                        Console.SetCursorPosition((menu.width / 2) - 8, top);
                        Console.WriteLine("(Stiskni libovolnou klávesu)");
                        Console.ReadKey();
                        diff_1 = false;
                    }

            }
        }
        private void Guess_Diff_2()
        {
            int top = 10;
            int pokusy = 5;
            while (diff_2)
            {
                pokusy--;
                Console.Clear();
                bool cyklus = true;
                int ran_hodn = ran.Next(1, 31);
                int user_guess = 0;

                while (cyklus)
                {
                    try
                    {
                        Console.SetCursorPosition((menu.width / 2) - 8, top);
                        Console.WriteLine("Hádání 1-30");
                        Console.SetCursorPosition((menu.width / 2) - 11, top + 1);
                        Console.WriteLine("-----------------");
                        Console.SetCursorPosition((menu.width / 2) - 10, top + 2);
                        Console.WriteLine($"Pokusy (zbývající):{pokusy}");
                        Console.SetCursorPosition((menu.width / 2) - 10, top + 3);
                        Console.WriteLine("Hádej: ");
                        Console.SetCursorPosition((menu.width / 2) - 3, top + 3);

                        user_guess = int.Parse(Console.ReadLine());



                        if (user_guess > 0 && user_guess < 31)
                        {
                            cyklus = false;
                        }
                        else
                        {
                            Console.Clear();
                            Console.SetCursorPosition((menu.width / 2) - 25, top);
                            Console.WriteLine("Něco si zadal špatně ale neboj pokus jsi neztratil :)");
                            Console.SetCursorPosition((menu.width / 2) - 25, top + 1);
                            Console.WriteLine("(zmáčkni libovolnou klávesu)");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }
                    catch (FormatException)
                    {
                        Console.Clear();
                        Console.SetCursorPosition((menu.width / 2) - 25, top);
                        Console.WriteLine("Něco si zadal špatně ale neboj pokus jsi neztratil :)");
                        Console.SetCursorPosition((menu.width / 2) - 25, top + 1);
                        Console.WriteLine("(zmáčkni libovolnou klávesu)");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }


                if (user_guess == ran_hodn)
                {
                    Console.SetCursorPosition((menu.width / 2) - 10, top + 5);
                    Console.WriteLine("Uhádl jsi!");
                    Thread.Sleep(2500);
                    Console.Clear();
                }
                else
                {
                    Console.SetCursorPosition((menu.width / 2) - 10, top + 5);
                    Console.WriteLine("Špatně! Zkus to znovu!");
                    Thread.Sleep(2500);
                    Console.Clear();
                }
                if (pokusy == 0)
                {
                    Console.Clear();
                    Console.SetCursorPosition((menu.width / 2) - 8, top);
                    Console.WriteLine("(Stiskni libovolnou klávesu)");
                    Console.ReadKey();
                    diff_2 = false;
                }

            }           
        }
        private void Guess_Diff_3()
        {
            int top = 10;
            int pokusy = 5;
            while (diff_3)
            {
                pokusy--;
                Console.Clear();
                bool cyklus = true;
                int ran_hodn = ran.Next(1, 51);
                int user_guess = 0;

                while (cyklus)
                {
                    try
                    {
                        Console.SetCursorPosition((menu.width / 2) - 8, top);
                        Console.WriteLine("Hádání 1-50");
                        Console.SetCursorPosition((menu.width / 2) - 11, top + 1);
                        Console.WriteLine("-----------------");
                        Console.SetCursorPosition((menu.width / 2) - 10, top + 2);
                        Console.WriteLine($"Pokusy (zbývající):{pokusy}");
                        Console.SetCursorPosition((menu.width / 2) - 10, top + 3);
                        Console.WriteLine("Hádej: ");
                        Console.SetCursorPosition((menu.width / 2) - 3, top + 3);

                        user_guess = int.Parse(Console.ReadLine());



                        if (user_guess > 0 && user_guess < 51)
                        {
                            cyklus = false;
                        }
                        else
                        {
                            Console.Clear();
                            Console.SetCursorPosition((menu.width / 2) - 25, top);
                            Console.WriteLine("Něco si zadal špatně ale neboj pokus jsi neztratil :)");
                            Console.SetCursorPosition((menu.width / 2) - 25, top + 1);
                            Console.WriteLine("(zmáčkni libovolnou klávesu)");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }
                    catch (FormatException)
                    {
                        Console.Clear();
                        Console.SetCursorPosition((menu.width / 2) - 25, top);
                        Console.WriteLine("Něco si zadal špatně ale neboj pokus jsi neztratil :)");
                        Console.SetCursorPosition((menu.width / 2) - 25, top + 1);
                        Console.WriteLine("(zmáčkni libovolnou klávesu)");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }


                if (user_guess == ran_hodn)
                {
                    Console.SetCursorPosition((menu.width / 2) - 10, top + 5);
                    Console.WriteLine("Uhádl jsi!");
                    Thread.Sleep(2500);
                    Console.Clear();
                }
                else
                {
                    Console.SetCursorPosition((menu.width / 2) - 10, top + 5);
                    Console.WriteLine("Špatně! Zkus to znovu!");
                    Thread.Sleep(2500);
                    Console.Clear();
                }
                if (pokusy == 0)
                {
                    Console.Clear();
                    Console.SetCursorPosition((menu.width / 2) - 8, top);
                    Console.WriteLine("(Stiskni libovolnou klávesu)");
                    Console.ReadKey();
                    diff_3 = false;
                }

            }
        }
    }
}
