using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1
{
    class Samohlasky
    {
        MainMenu menu = new MainMenu();

        public void Samo_Skeleton()
        {
            Console.Title = "Samohlásky - Hořejší";
            menu.ScreenSettings(menu.height, menu.width);

            Samo_Input();
        }
        private void Samo_Input() 
        {
            int top = 10;

            Console.SetCursorPosition((menu.width / 2) - 8, top);
            Console.WriteLine("Samohlásky");
            Console.SetCursorPosition((menu.width / 2) - 11, top + 1);
            Console.WriteLine("-----------------");

            Console.SetCursorPosition((menu.width / 2) - 10, top + 2);
            Console.WriteLine("Zadej slovo/větu : ");
            Console.SetCursorPosition((menu.width / 2) - 10, top + 3);
            string user_input = Console.ReadLine();

            Samo_Vypocet(user_input);
        }

        private void Samo_Vypocet(string user_input)
        {
            int top = 10;
            char[] Pole_znaky = new char[] { 'a', 'e', 'i', 'o', 'u', 'á', 'é', 'í', 'ó', 'ú' };
            int[] Pole_Pocet = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            string user_input_lower = user_input.ToLower();

            for (int i = 0; i < user_input.Length; i++)
            {
                for (int y = 0; y < Pole_znaky.Length; y++)
                {
                    if (user_input_lower[i] == Pole_znaky[y])
                    {
                        Pole_Pocet[y]++;
                    }
                }
            }


            Console.SetCursorPosition((menu.width / 2) - 21, top + 5);
            Console.WriteLine( " a   e   i   o   u   á   é   í   ó   ú ");
            Console.SetCursorPosition((menu.width / 2) - 21, top + 6);
            Console.WriteLine( "--- --- --- --- --- --- --- --- --- ---");
            Console.SetCursorPosition((menu.width / 2) - 21, top + 7);
            Console.WriteLine($"|{Pole_Pocet[0]}| |{Pole_Pocet[1]}| |{Pole_Pocet[2]}| |{Pole_Pocet[3]}| |{Pole_Pocet[4]}| |{Pole_Pocet[5]}| |{Pole_Pocet[6]}| |{Pole_Pocet[7]}| |{Pole_Pocet[8]}| |{Pole_Pocet[9]}|");
            Console.SetCursorPosition((menu.width / 2) - 21, top + 8);
            Console.WriteLine( "--- --- --- --- --- --- --- --- --- ---");


            Thread.Sleep(8500);

        }
    }
}
