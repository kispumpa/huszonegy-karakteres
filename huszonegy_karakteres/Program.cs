using ConsoleTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace huszonegy_karakteres
{
    internal class Program
    {
        static Random r = new Random();
        static void Main(string[] args)
        {
            var difficulty = new ConsoleMenu(args, level: 1)
                .Add("Könnyű", () => Jatek(1))
                .Add("Közepes", () => Jatek(2))
                .Add("Nehéz", () => Jatek(3))
                .Add("Vissza", ConsoleMenu.Close);

            var menu = new ConsoleMenu(args, level: 0)
                .Add("Játékszabály", () => Jatekszabaly())
                .Add("Start", () => difficulty.Show())
                .Add("Kilépés", ConsoleMenu.Close);

            menu.Show();

            Console.Write("Kilépéshez nyomj egy Entert ...");
            Console.ReadKey();
        }

        static void Jatekszabaly()
        {
            Console.WriteLine("HUSZONEGY (Magyar kártyajáték)" +
                "\n");
            Console.WriteLine("Játékszabály:");
            Console.WriteLine("\t- a Huszonegy nevezetű kártyajáték lényege, hogy a kézben levő kártyák összege megközelítse, optimális esetben elérje a 21-et, de túllépni nem szabad" +
                "\n\t- 16 összegű eredménynél már meg lehet állni, vagy lehet kockáztatni azzal, hogy új kártyát húzol" +
                "\n\t- ellenfeled egy robot lesz; az a játékos nyer, akinek nagyobb összegű lapja lesz a kör végén" +
                "\n\t- a 0. körben két lappal kezdesz, a két lap összege fog megjelenni a képernyőn" +
                "\n\t- abban az esetben, ha egyenlő a két szám, az osztóé fog nyerni" +
                "\n\t- ha a 0. körben 22 pontod van - ergo az első két kártyád 11-et és 11-et ér -, akkor azzal instant nyersz" +
                "\n\t- ");
            Console.WriteLine("Játékmódok: ");
            Console.WriteLine("\n\t1. Könnyű: ellenfeled robot eredménye túllépheti a 22-őt, és te vagy az osztó" +
                "\n\t2. Közepes: ellenfeled eredménye túllépheti a 22-őt maximum 4 számmal, és te vagy az osztó" +
                "\n\t3. Nehéz: ellenfeled eredménye minimum 16, maximum 22 lehet, és ő az osztó");

            Console.ReadLine();
        }

        static void Jatek(int diff)
        {
            int[] szamok = { 2, 3, 4, 7, 8, 9, 10, 11 };
            bool vegevan = false;
            int x = 0;
            int osszeg = 0;
            int robotdif = Nehezseg(diff);
            int robotalap = r.Next(0, 8);
            osszeg += szamok[robotalap];
            while (!vegevan)
            {
                Console.Clear();
                Console.WriteLine($"{x}. kör");
                int randomszam = r.Next(0, 8);
                osszeg += szamok[randomszam];

                Console.WriteLine("Lapjaid összege: {0}", osszeg);
                bool correct = false;
                int gomb = 0;
                while (!correct)
                {
                    Console.Write("Kérsz még lapot?" +
                    "\n\t1: igen" +
                    "\n\t2: nem" +
                    "\nÍrd ide a választásod számát: ");
                    
                    try
                    {
                        gomb = int.Parse(Console.ReadLine());
                        if (gomb < 1 || gomb > 2)
                        {
                            throw new FormatException();
                        }
                        else
                        {
                            correct = true;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Nem megfelelő értéket adtál meg");
                    }
                }

                switch (gomb)
                {
                    case 1:
                        x++;
                        break;
                    case 2:
                        Console.WriteLine($"\nVÉGEREDMÉNY: {osszeg}/{robotdif}");

                        if ((osszeg >= 16 && osszeg < 22 && (robotdif > 22 || robotdif < osszeg || (robotdif == osszeg && diff < 3))) || (x == 0 && osszeg == 22 && (diff < 3 || (diff == 3 && robotdif != osszeg))))
                        {

                        }


                        if ((osszeg >= 16 && osszeg < 22 && robotdif > 22) || (osszeg >= 16 && osszeg < 22 && robotdif < osszeg) || (osszeg >= 16 && osszeg < 22 && robotdif == osszeg && diff < 3) || (x == 0 && osszeg == 22 && diff < 3) || (x == 0 && osszeg == 22 && diff == 3 && robotdif != osszeg))
                        {
                            Console.WriteLine("\nNYERTÉL! C:");
                            bool joe = false;
                            int uj = 0;
                            while (!joe)
                            {
                                Console.Write("Szeretnél új játékot?" +
                                "\n\t1: igen" +
                                "\n\t2: nem" +
                                "\nÍrd ide a választásod számát: ");
                                
                                try
                                {
                                    uj = int.Parse(Console.ReadLine());
                                    if (uj < 1 || uj > 2)
                                    {
                                        throw new FormatException();
                                    }
                                    else
                                    {
                                        joe = true;
                                    }
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Nem megfelelő értéket adtál meg");
                                }
                            }
                            
                            switch (uj)
                            {
                                case 1:
                                    Console.Clear();
                                    vegevan = true;
                                    break;
                                case 2:
                                    vegevan = true;
                                    break;
                                default:
                                    break;

                            }
                            
                        }
                        else
                        {
                            Console.WriteLine("\nVESZTETTÉL! :C");
                            int uj = 0;
                            bool joe = false;
                            while (!joe)
                            {
                                Console.Write("Szeretnél új játékot?" +
                                "\n\t1: igen" +
                                "\n\t2: nem" +
                                "\nÍrd ide a választásod számát: ");

                                try
                                {
                                    uj = int.Parse(Console.ReadLine());
                                    if (uj < 1 || uj > 2)
                                    {
                                        throw new FormatException();
                                    }
                                    else
                                    {
                                        joe = true;
                                    }
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Nem megfelelő értéket adtál meg");
                                }
                            }

                            switch (uj)
                            {
                                case 1:
                                    Console.Clear();
                                    vegevan = true;
                                    break;
                                case 2:
                                    vegevan = true;
                                    break;
                                default:
                                    break;

                            }
                        }
                        break;

                    default:
                        break;
                }
            }
        }

        static int Nehezseg(int number)
        {
            if (number == 1)
            {
                return r.Next(16, 31);
            }
            else if (number == 2)
            {
                return r.Next(16, 27);
            }
            else
            {
                return r.Next(16, 23);
            }
        }
    }
}
