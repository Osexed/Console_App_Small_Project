using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Pexeso
    {
        MainMenu menu = new MainMenu();
        Random ran = new Random();
        private string[] Pole = new string[] {"0", "1", "2", "3", "4", "5", "6", "7", "8","9"};
        private string[] Pole_animals = new string[] {"vlk", "lev", "ovce", "koza", "pes", };
        private int[] Ran_an = new int[5];
        private int[] Ran_an1 = new int[5];
        private bool Internal_Bool = true;
        private int user_incard1 = 0;
        private int user_incard2 = 0;
        private int citac1 = 0;

        public void Pexeso_Skeleton()
        {
            Console.Title = "Pexeso - Hořejší";
            menu.ScreenSettings(menu.height, menu.width);
            Card_Mix();

            while (Internal_Bool)
            {
                Pexeso_Input();

                if (citac1 == 5)
                {
                    Internal_Bool = false;
                }
            }


        }
        private void Pexeso_Cards()
        {            
            Console.WriteLine("---  ---  ---  ---  ---");
            Console.WriteLine($"|{Pole[0]}|  |{Pole[1]}|  |{Pole[2]}|  |{Pole[3]}|  |{Pole[4]}|");
            Console.WriteLine("---  ---  ---  ---  ---");
            Console.WriteLine();
            Console.WriteLine("---  ---  ---  ---  ---");
            Console.WriteLine($"|{Pole[5]}|  |{Pole[6]}|  |{Pole[7]}|  |{Pole[8]}|  |{Pole[9]}|");
            Console.WriteLine("---  ---  ---  ---  ---");
            Console.WriteLine();
        }
        private void Pexeso_Input()
        {
            bool cyklus = true;
            while (cyklus)
            {
                try
                {
                    Pexeso_Cards();

                    Console.Write("Vyber si kartu na 1. řádku(číslo 0-4): ");
                    user_incard1 = int.Parse(Console.ReadLine());
                    switch (user_incard1)
                    {
                        case 0:
                            Console.WriteLine($"Vybral jsis kartu číslo {user_incard1} se zvířetem {Pole_animals[Ran_an[0]]}");
                            break;
                        case 1:
                            Console.WriteLine($"Vybral jsis kartu číslo {user_incard1} se zvířetem {Pole_animals[Ran_an[1]]}");
                            break;
                        case 2:
                            Console.WriteLine($"Vybral jsis kartu číslo {user_incard1} se zvířetem {Pole_animals[Ran_an[2]]}");
                            break;
                        case 3:
                            Console.WriteLine($"Vybral jsis kartu číslo {user_incard1} se zvířetem {Pole_animals[Ran_an[3]]}");
                            break;
                        case 4:
                            Console.WriteLine($"Vybral jsis kartu číslo {user_incard1} se zvířetem {Pole_animals[Ran_an[4]]}");
                            break;
                        default:
                            menu.Wrong();
                            break;
                    }

                    Console.WriteLine();

                    Console.Write("Vyber si kartu na 2. řádku(číslo 5-9): ");
                    user_incard2 = int.Parse(Console.ReadLine());
                    switch (user_incard2)
                    {
                        case 5:
                            Console.WriteLine($"Vybral jsis kartu číslo {user_incard2} se zvířetem {Pole_animals[Ran_an1[0]]}");

                            if (Ran_an[user_incard1] == Ran_an1[0])
                            {
                                Pole[user_incard1] = " ";
                                Pole[5] = " ";
                                Console.WriteLine("Uhádl jsi!");
                                citac1++;
                            }
                            break;
                        case 6:
                            Console.WriteLine($"Vybral jsis kartu číslo {user_incard2} se zvířetem {Pole_animals[Ran_an1[1]]}");

                            if (Ran_an[user_incard1] == Ran_an1[1])
                            {
                                Pole[user_incard1] = " ";
                                Pole[6] = " ";
                                Console.WriteLine("Uhádl jsi!");
                                citac1++;
                            }
                            break;
                        case 7:
                            Console.WriteLine($"Vybral jsis kartu číslo {user_incard2} se zvířetem {Pole_animals[Ran_an1[2]]}");

                            if (Ran_an[user_incard1] == Ran_an1[2])
                            {
                                Pole[user_incard1] = " ";
                                Pole[7] = " ";
                                Console.WriteLine("Uhádl jsi!");
                                citac1++;
                            }
                            break;
                        case 8:
                            Console.WriteLine($"Vybral jsis kartu číslo {user_incard2} se zvířetem {Pole_animals[Ran_an1[3]]}");

                            if (Ran_an[user_incard1] == Ran_an1[3])
                            {
                                Pole[user_incard1] = " ";
                                Pole[8] = " ";
                                Console.WriteLine("Uhádl jsi!");
                                citac1++;
                            }
                            break;
                        case 9:
                            Console.WriteLine($"Vybral jsis kartu číslo {user_incard2} se zvířetem {Pole_animals[Ran_an1[4]]}");

                            if (Ran_an[user_incard1] == Ran_an1[4])
                            {
                                Pole[user_incard1] = " ";
                                Pole[9] = " ";
                                Console.WriteLine("Uhádl jsi!");
                                citac1++;
                            }
                            break;
                        default:
                            menu.Wrong();
                            break;
                    }

                    if ((user_incard1 != user_incard2) && (user_incard1 >= 0 && user_incard1 < 10) && (user_incard2 >= 0 && user_incard2 < 10))
                    {
                        cyklus = false;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Něco jsi zadal špatně - odklikni klavesu");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                catch (FormatException)
                {
                    menu.Wrong();
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Odklikni");
            Console.ReadKey();
            Console.Clear();
        }
        private void Card_Mix()
        {
            bool cyklus = true;
            bool cyklus1 = true;
            Ran_an = new int[] { ran.Next(0, 5), ran.Next(0, 5), ran.Next(0, 5), ran.Next(0, 5), ran.Next(0, 5) };
            Ran_an1 = new int[] { ran.Next(0, 5), ran.Next(0, 5), ran.Next(0, 5), ran.Next(0, 5), ran.Next(0, 5) };

            while (cyklus)
            {
                if ((Ran_an[0] != Ran_an[1]) && (Ran_an[0] != Ran_an[2]))
                {
                    if ((Ran_an[0] != Ran_an[3]) && (Ran_an[0] != Ran_an[4]))
                    {
                        if ((Ran_an[1] != Ran_an[2]) && (Ran_an[1] != Ran_an[3]) && (Ran_an[1] != Ran_an[4]))
                        {
                            if ((Ran_an[2] != Ran_an[3]) && (Ran_an[2] != Ran_an[4]))
                            {
                                if (Ran_an[3] != Ran_an[4])
                                {
                                    cyklus = false;
                                }
                                else if (Ran_an[3] == Ran_an[4])
                                {
                                    cyklus1 = true;
                                    while (cyklus1)
                                    {
                                        Ran_an[4] = ran.Next(0, 5);

                                        if (Ran_an[3] != Ran_an[4])
                                        {
                                            cyklus1 = false;
                                        }
                                    }
                                }
                            }
                            else if (Ran_an[2] == Ran_an[3])
                            {
                                cyklus1 = true;
                                while (cyklus1)
                                {
                                    Ran_an[3] = ran.Next(0, 5);

                                    if (Ran_an[3] != Ran_an[1])
                                    {
                                        cyklus1 = false;
                                    }
                                }
                            }
                            else if (Ran_an[2] == Ran_an[4])
                            {
                                cyklus1 = true;
                                while (cyklus1)
                                {
                                    Ran_an[4] = ran.Next(0, 5);

                                    if (Ran_an[4] != Ran_an[2])
                                    {
                                        cyklus1 = false;
                                    }
                                }
                            }
                        }
                        else if (Ran_an[1] == Ran_an[2])
                        {
                            cyklus1 = true;
                            while (cyklus1)
                            {
                                Ran_an[2] = ran.Next(0, 5);

                                if (Ran_an[1] != Ran_an[2])
                                {
                                    cyklus1 = false;
                                }
                            }
                        }
                        else if (Ran_an[1] == Ran_an[3])
                        {
                            cyklus1 = true;
                            while (cyklus1)
                            {
                                Ran_an[3] = ran.Next(0, 5);

                                if (Ran_an[3] != Ran_an[1])
                                {
                                    cyklus1 = false;
                                }
                            }
                        }
                        else if (Ran_an[1] == Ran_an[4])
                        {
                            cyklus1 = true;
                            while (cyklus1)
                            {
                                Ran_an[4] = ran.Next(0, 5);

                                if (Ran_an[4] != Ran_an[1])
                                {
                                    cyklus1 = false;
                                }
                            }
                        }
                    }
                    else if (Ran_an[0] == Ran_an[3])
                    {
                        cyklus1 = true;
                        while (cyklus1)
                        {
                            Ran_an[3] = ran.Next(0, 5);

                            if (Ran_an[3] != Ran_an[0])
                            {
                                cyklus1 = false;
                            }
                        }
                    }
                    else if (Ran_an[0] == Ran_an[4])
                    {
                        cyklus1 = true;
                        while (cyklus1)
                        {
                            Ran_an[4] = ran.Next(0, 5);

                            if (Ran_an[4] != Ran_an[0])
                            {
                                cyklus1 = false;
                            }
                        }
                    }
                }
                else if (Ran_an[0] == Ran_an[1])
                {
                    cyklus1 = true;
                    while (cyklus1)
                    {
                        Ran_an[1] = ran.Next(0, 5);

                        if (Ran_an[1] != Ran_an[0])
                        {
                            cyklus1 = false;
                        }
                    }
                }
                else if (Ran_an[0] == Ran_an[2])
                {
                    cyklus1 = true;
                    while (cyklus1)
                    {
                        Ran_an[2] = ran.Next(0, 5);

                        if (Ran_an[2] != Ran_an[0])
                        {
                            cyklus1 = false;
                        }
                    }
                }
            } //algortimus :)

            cyklus = true;
            cyklus1 = true;

            while (cyklus)
            {
                if ((Ran_an1[0] != Ran_an1[1]) && (Ran_an1[0] != Ran_an1[2]))
                {
                    if ((Ran_an1[0] != Ran_an1[3]) && (Ran_an1[0] != Ran_an1[4]))
                    {
                        if ((Ran_an1[1] != Ran_an1[2]) && (Ran_an1[1] != Ran_an1[3]) && (Ran_an1[1] != Ran_an1[4]))
                        {
                            if ((Ran_an1[2] != Ran_an1[3]) && (Ran_an1[2] != Ran_an1[4]))
                            {
                                if (Ran_an1[3] != Ran_an1[4])
                                {
                                    cyklus = false;
                                }
                                else if (Ran_an1[3] == Ran_an1[4])
                                {
                                    cyklus1 = true;
                                    while (cyklus1)
                                    {
                                        Ran_an1[4] = ran.Next(0, 5);

                                        if (Ran_an1[3] != Ran_an1[4])
                                        {
                                            cyklus1 = false;
                                        }
                                    }
                                }
                            }
                            else if (Ran_an1[2] == Ran_an1[3])
                            {
                                cyklus1 = true;
                                while (cyklus1)
                                {
                                    Ran_an1[3] = ran.Next(0, 5);

                                    if (Ran_an1[3] != Ran_an1[1])
                                    {
                                        cyklus1 = false;
                                    }
                                }
                            }
                            else if (Ran_an1[2] == Ran_an1[4])
                            {
                                cyklus1 = true;
                                while (cyklus1)
                                {
                                    Ran_an1[4] = ran.Next(0, 5);

                                    if (Ran_an1[4] != Ran_an1[2])
                                    {
                                        cyklus1 = false;
                                    }
                                }
                            }
                        }
                        else if (Ran_an1[1] == Ran_an1[2])
                        {
                            cyklus1 = true;
                            while (cyklus1)
                            {
                                Ran_an1[2] = ran.Next(0, 5);

                                if (Ran_an1[1] != Ran_an1[2])
                                {
                                    cyklus1 = false;
                                }
                            }
                        }
                        else if (Ran_an1[1] == Ran_an1[3])
                        {
                            cyklus1 = true;
                            while (cyklus1)
                            {
                                Ran_an1[3] = ran.Next(0, 5);

                                if (Ran_an1[3] != Ran_an1[1])
                                {
                                    cyklus1 = false;
                                }
                            }
                        }
                        else if (Ran_an1[1] == Ran_an1[4])
                        {
                            cyklus1 = true;
                            while (cyklus1)
                            {
                                Ran_an1[4] = ran.Next(0, 5);

                                if (Ran_an1[4] != Ran_an1[1])
                                {
                                    cyklus1 = false;
                                }
                            }
                        }
                    }
                    else if (Ran_an1[0] == Ran_an1[3])
                    {
                        cyklus1 = true;
                        while (cyklus1)
                        {
                            Ran_an1[3] = ran.Next(0, 5);

                            if (Ran_an1[3] != Ran_an1[0])
                            {
                                cyklus1 = false;
                            }
                        }
                    }
                    else if (Ran_an1[0] == Ran_an1[4])
                    {
                        cyklus1 = true;
                        while (cyklus1)
                        {
                            Ran_an1[4] = ran.Next(0, 5);

                            if (Ran_an1[4] != Ran_an1[0])
                            {
                                cyklus1 = false;
                            }
                        }
                    }
                }
                else if (Ran_an1[0] == Ran_an1[1])
                {
                    cyklus1 = true;
                    while (cyklus1)
                    {
                        Ran_an1[1] = ran.Next(0, 5);

                        if (Ran_an1[1] != Ran_an1[0])
                        {
                            cyklus1 = false;
                        }
                    }
                }
                else if (Ran_an1[0] == Ran_an1[2])
                {
                    cyklus1 = true;
                    while (cyklus1)
                    {
                        Ran_an1[2] = ran.Next(0, 5);

                        if (Ran_an1[2] != Ran_an1[0])
                        {
                            cyklus1 = false;
                        }
                    }
                }
            } //algortimus 2 :) přepiš tam ty proměnný cyklus
        }

        /*public void Test()
        {
            bool cyklus = true;
            bool cyklus1 = true;

            int[] Ran_an = new int[] { ran.Next(0, 5), ran.Next(0, 5), ran.Next(0, 5), ran.Next(0, 5), ran.Next(0, 5) };

            while (cyklus)
            {
                if ((Ran_an[0] != Ran_an[1]) && (Ran_an[0] != Ran_an[2]))
                {
                    if ((Ran_an[0] != Ran_an[3]) && (Ran_an[0] != Ran_an[4]))
                    {
                        if ((Ran_an[1] != Ran_an[2]) && (Ran_an[1] != Ran_an[3]) && (Ran_an[1] != Ran_an[4]))
                        {
                            if ((Ran_an[2] != Ran_an[3]) && (Ran_an[2] != Ran_an[4]))
                            {
                                if (Ran_an[3] != Ran_an[4])
                                {
                                    cyklus = false;
                                }
                                else if (Ran_an[3] == Ran_an[4])
                                {
                                    cyklus1 = true;
                                    while (cyklus1)
                                    {
                                        Ran_an[4] = ran.Next(0, 5);

                                        if (Ran_an[3] != Ran_an[4])
                                        {
                                            cyklus1 = false;
                                        }
                                    }
                                }
                            }
                            else if (Ran_an[2] == Ran_an[3])
                            {
                                cyklus1 = true;
                                while (cyklus1)
                                {
                                    Ran_an[3] = ran.Next(0, 5);

                                    if (Ran_an[3] != Ran_an[1])
                                    {
                                        cyklus1 = false;
                                    }
                                }
                            }
                            else if (Ran_an[2] == Ran_an[4])
                            {
                                cyklus1 = true;
                                while (Ran_an[4] == Ran_an[2])
                                {
                                    Ran_an[4] = ran.Next(0, 5);

                                    if (Ran_an[4] != Ran_an[2])
                                    {
                                        cyklus1 = false;
                                    }
                                }
                            }
                        }
                        else if (Ran_an[1] == Ran_an[2])
                        {
                            cyklus1 = true;
                            while (cyklus1)
                            {
                                Ran_an[2] = ran.Next(0, 5);

                                if (Ran_an[1] != Ran_an[2])
                                {
                                    cyklus1 = false;
                                }
                            }
                        }
                        else if (Ran_an[1] == Ran_an[3])
                        {
                            cyklus1 = true;
                            while (cyklus1)
                            {
                                Ran_an[3] = ran.Next(0, 5);

                                if (Ran_an[3] != Ran_an[1])
                                {
                                    cyklus1 = false;
                                }
                            }
                        }
                        else if (Ran_an[1] == Ran_an[4])
                        {
                            cyklus1 = true;
                            while (cyklus1)
                            {
                                Ran_an[4] = ran.Next(0, 5);

                                if (Ran_an[4] != Ran_an[1])
                                {
                                    cyklus1 = false;
                                }
                            }
                        }
                    }
                    else if (Ran_an[0] == Ran_an[3])
                    {
                        cyklus1 = true;
                        while (cyklus1)
                        {
                            Ran_an[3] = ran.Next(0, 5);

                            if (Ran_an[3] != Ran_an[0])
                            {
                                cyklus1 = false;
                            }
                        }
                    }
                    else if (Ran_an[0] == Ran_an[4])
                    {
                        cyklus1 = true;
                        while (cyklus1)
                        {
                            Ran_an[4] = ran.Next(0, 5);

                            if (Ran_an[4] != Ran_an[0])
                            {
                                cyklus1 = false;
                            }
                        }
                    }
                }
                else if (Ran_an[0] == Ran_an[1])
                {
                    cyklus1 = true;
                    while (cyklus1)
                    {
                        Ran_an[1] = ran.Next(0, 5);

                        if (Ran_an[1] != Ran_an[0])
                        {
                            cyklus1 = false;
                        }
                    }
                }
                else if (Ran_an[0] == Ran_an[2])
                {
                    cyklus1 = true;
                    while (cyklus1)
                    {
                        Ran_an[2] = ran.Next(0, 5);

                        if (Ran_an[2] != Ran_an[0])
                        {
                            cyklus1 = false;
                        }
                    }
                }
            }


            Console.WriteLine($"Fina: |a: {Ran_an[0]}|b: {Ran_an[1]}|c: {Ran_an[2]}|d: {Ran_an[3]}|e: {Ran_an[4]}|");
            Console.ReadKey();
        }*///algortimus na to "zamychani" karet
    }
}
