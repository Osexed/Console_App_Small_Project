using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1
{
    class MainMenu
    {
        public int height = 40; 
        public int width = 80; //veřejná proměnná kterou použivám pro pozicování
        public void ScreenSettings(int height, int width)
        {
            Console.Clear();
            try
            {
                Console.SetBufferSize(width + 40, height);
                Console.SetWindowSize(width, height);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.SetCursorPosition((width / 2) - 10, 10);
                Console.WriteLine(" Přístě prosím nezvětšuj nebo jakkoliv upravuj velikost okna! Děkuji!");
                Thread.Sleep(8000);
                Console.Clear();
                Console.SetWindowSize(width, height);
            }
        }//Nastavení velikosti obrazovky pro pozicování 
        private void WelcomeText()
        {
            int top = 2;
            int left = 11;
            for (int i = 0; i < 5; i++) //cyklus pro vypsání W
            {
                Console.SetCursorPosition(left, top);
                Console.Write("W");
                Console.SetCursorPosition(left + 4, top);
                Console.Write("W");
                switch (left)
                {
                    case 11:
                        Console.SetCursorPosition(left + 8, top);
                        Console.Write("W");
                        Console.SetCursorPosition(left + 12, top);
                        Console.Write("W");
                        break;
                    case 12:
                        Console.SetCursorPosition(left + 6, top);
                        Console.Write("W");
                        Console.SetCursorPosition(left + 10, top);
                        Console.Write("W");
                        break;
                    case 13:
                        Console.SetCursorPosition(left + 4, top);
                        Console.Write("W");
                        Console.SetCursorPosition(left + 8, top);
                        Console.Write("W");
                        break;
                    case 14:
                        Console.SetCursorPosition(left + 2, top);
                        Console.Write("W");
                        Console.SetCursorPosition(left + 6, top);
                        Console.Write("W");
                        break;
                }
                left++;top++;
            } //W
            left = 25;top = 2;
            for (int i = 0; i < 5; i++) //cyklus pro vypsání E
            {
                switch (top)
                {
                    case 2:
                        for (int j = 0; j < 5; j++)
                        {
                            Console.SetCursorPosition(left, top);
                            Console.Write("E");
                            left++;
                        }
                        top++; left = 25;
                        Console.SetCursorPosition(left, top);
                        Console.Write("E");                        
                        break;
                    case 4:
                        for (int j = 0; j < 5; j++)
                        {
                            Console.SetCursorPosition(left, top);
                            Console.Write("E");
                            left++;
                        }
                        top++; left = 25;
                        Console.SetCursorPosition(left, top);
                        Console.Write("E");
                        break;
                    case 6:
                        for (int j = 0; j < 5; j++)
                        {
                            Console.SetCursorPosition(left, top);
                            Console.Write("E");
                            left++;
                        }
                        break;
                }
                top++;
            } //E
            left = 31;top=2;
            for (int i = 0; i < 5; i++) //cyklus pro L
            {
                Console.SetCursorPosition(left, top);
                Console.Write("L");
                top++;
                if (top==6)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        Console.SetCursorPosition(left, top);
                        Console.Write("L");
                        left++;
                    }
                }
            } //L
            left = 37; top = 2;
            for (int i = 0; i < 2; i++) //cyklus pro C
            {
                switch (top)
                {
                    case 2:
                        for (int j = 0; j < 4; j++)
                        {
                            Console.SetCursorPosition(left + 1, top);
                            Console.Write("C");
                            left++;
                        }
                        top++; left = 37;
                        for (int y = 0; y < 3; y++)
                        {
                            Console.SetCursorPosition(left, top);
                            Console.Write("C");
                            top++;
                        }
                        break;
                    case 6:
                        for (int j = 0; j < 4; j++)
                        {
                            Console.SetCursorPosition(left + 1, top);
                            Console.Write("C");
                            left++;
                        }
                        break;
                }
            } //C
            left = 43; top = 2;
            for (int i = 0; i < 5; i++) //cyklus pro O
            {
                switch (top)
                {
                    case 2:
                        left = 44;
                        for (int j = 0; j < 4; j++)
                        {
                            Console.SetCursorPosition(left, top);
                            Console.Write("O");
                            left++;
                        }
                        break;
                    case 6:
                        left = 44;
                        for (int j = 0; j < 4; j++)
                        {
                            Console.SetCursorPosition(left, top);
                            Console.Write("O");
                            left++;
                        }
                        break;
                    default:
                        left = 43;
                        Console.SetCursorPosition(left, top);
                        Console.Write("O");
                        left = 48;
                        Console.SetCursorPosition(left, top);
                        Console.Write("O");
                        break;
                }
                top++;
            } //O
            left = 50; top = 2;
            for (int i = 0; i < 5; i++) //cyklus pro M
            {
                switch (top)
                {
                    case 2:
                        for (int y = 0; y < 2; y++)
                        {
                            Console.SetCursorPosition(left, top);
                            Console.Write("M");
                            left++;
                        }
                        left = 56;
                        for (int x = 0; x < 2; x++)
                        {
                            Console.SetCursorPosition(left, top);
                            Console.Write("M");
                            left++;
                        }
                        break;
                    case 3:
                        Console.SetCursorPosition(left, top);
                        Console.Write("M");
                        Console.SetCursorPosition(left + 5, top);
                        Console.Write("M");
                        Console.SetCursorPosition(left + 2, top);
                        Console.Write("M");
                        Console.SetCursorPosition(left + 7, top);
                        Console.Write("M");
                        break;
                    case 4:
                        Console.SetCursorPosition(left, top);
                        Console.Write("M");
                        Console.SetCursorPosition(left + 4, top);
                        Console.Write("M");
                        Console.SetCursorPosition(left + 3, top);
                        Console.Write("M");
                        Console.SetCursorPosition(left + 7, top);
                        Console.Write("M");

                        break;
                    default:
                        Console.SetCursorPosition(left, top);
                        Console.Write("M");
                        Console.SetCursorPosition(left + 7, top);
                        Console.Write("M");
                        break;
                }
                top++;left = 50;
            } //M
            left = 59; top = 2;
            for (int i = 0; i < 5; i++) //cyklus pro vypsání E
            {
                switch (top)
                {
                    case 2:
                        for (int j = 0; j < 5; j++)
                        {
                            Console.SetCursorPosition(left, top);
                            Console.Write("E");
                            left++;
                        }
                        top++; left = 59;
                        Console.SetCursorPosition(left, top);
                        Console.Write("E");
                        break;
                    case 4:
                        for (int j = 0; j < 5; j++)
                        {
                            Console.SetCursorPosition(left, top);
                            Console.Write("E");
                            left++;
                        }
                        top++; left = 59;
                        Console.SetCursorPosition(left, top);
                        Console.Write("E");
                        break;
                    case 6:
                        for (int j = 0; j < 5; j++)
                        {
                            Console.SetCursorPosition(left, top);
                            Console.Write("E");
                            left++;
                        }
                        break;
                }
                top++;
            } //E
        }//metoda pro vypsání Welcome
        public void Menu()
        {
            Calculator kalku = new Calculator(); //instance tříd kdybych je dal mimo metodu dělá to propodivný exception
            Samohlasky samo = new Samohlasky();
            NumberGuessing numg = new NumberGuessing();
            Pexeso pexeso = new Pexeso();

            Console.Title = "Main Menu - Hořejší";
            bool cyklus = true;
            while (cyklus)
            {
                ScreenSettings(height, width);
                WelcomeText();
                int top = 10; //preměnná pro pozicování na řádcích
                try //pasivní ošetření když by se user překlikl nebo se snažil záměrně rozbít chod programu
                {
                    Console.SetCursorPosition((width / 2) - 5, top);
                    Console.WriteLine("MENU");
                    Console.SetCursorPosition((width / 2) - 6, top + 1);
                    Console.WriteLine("------");
                    Console.SetCursorPosition((width / 2) - 10, top + 2);
                    Console.WriteLine("1. Kalkulačka");
                    Console.SetCursorPosition((width / 2) - 10, top + 3);
                    Console.WriteLine("2. Samohlásky");
                    Console.SetCursorPosition((width / 2) - 10, top + 4);
                    Console.WriteLine("3. Hád. čísla");
                    Console.SetCursorPosition((width / 2) - 10, top + 5);
                    Console.WriteLine("4. Pexeso nepexeso");
                    Console.SetCursorPosition((width / 2) - 10, top + 6);
                    Console.WriteLine("5. Ukončit");

                    Console.SetCursorPosition((width / 2) - 6, top + 7);
                    Console.WriteLine("--------");
                    Console.SetCursorPosition((width / 2) - 5, top + 8);
                    Console.WriteLine("Vyber: ");
                    Console.SetCursorPosition((width / 2) - 6, top + 9);
                    Console.WriteLine("--------");

                    Console.SetCursorPosition((width / 2) + 1, top + 8);
                    int user_pick = int.Parse(Console.ReadLine()); 

                    switch (user_pick)
                    {
                        case 1:
                            kalku.Calc_Skeleton(); //Kalkulačka
                            break;
                        case 2:
                            samo.Samo_Skeleton(); //Samohlásky
                            break;
                        case 3:
                            numg.Guess_Skeleton(); //Hádání čísla
                            break;
                        case 4:
                            pexeso.Pexeso_Skeleton(); //Pexeso nepexeso
                            break;
                        case 5:
                            cyklus = false; //Konec programu
                            break;
                        default:
                            Wrong(); //když by uživatel zadal číslo <0 nebo číslo >5 nefunguje to pro formatexception pro to tu mám try catch
                            break;
                    }
                }
                catch (FormatException)
                {
                    Wrong();
                }
            }

        }

        public void Wrong()
        {
            int top = 10;

            Console.Clear();
            Console.SetCursorPosition((width / 2) - 11, top + 7);
            Console.WriteLine("Něco se pokazilo!");
            int procento = 0;
            int left = (width / 2) - 40;
            for (int i = 0; i <= 100; i++)
            {
                if (procento <= 79)
                {
                    Console.SetCursorPosition(left, top + 8);
                    Console.Write("-");
                }
                else
                {
                    left = 2;
                    Console.SetCursorPosition(left, top + 9);
                    Console.Write(" ");
                }
                Console.SetCursorPosition((width / 2) - 5, top + 10);
                Console.WriteLine($"{procento} %");
                procento++; left++;
                Thread.Sleep(50);
            }
            Thread.Sleep(100);
            Console.Clear();

        } //metoda pro text když se něco pokazí
    }
}
