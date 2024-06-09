using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace huszonegy_karakteres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //a szamok letrehozasa
            int[] szamok = new int[8];
            szamok[0] = 2;
            szamok[1] = 3;
            szamok[2] = 4;
            szamok[3] = 7;
            szamok[4] = 8;
            szamok[5] = 9;
            szamok[6] = 10;
            szamok[7] = 11;
            Random random = new Random();
            //
            //jatekszabaly kiirasa
            Console.WriteLine("HUSZONEGY (Magyar kártyajáték)");
            Console.WriteLine();
            Console.WriteLine("Játékszabály:");
            Console.WriteLine("- A huszonegy nevezetű kártyajáték lényege, hogy a kézben levő kártyák összege megközelítse, optimális esetben elérje a 21-et, de túllépni nem szabad.");
            Console.WriteLine("- 16 összegű eredménynél már meg lehet állni, vagy lehet kockáztatni azzal, hogy új kártyát húzol.");
            Console.WriteLine("- Ellenfeled egy robot lesz; az a játékos nyer, akinek több összegű lapja lesz a kör végén.");
            Console.WriteLine("- A 0. körben két lappal kezdesz, a két lap összege fog megjelenni a képernyőn.");
            Console.WriteLine("- Abban az esetben, ha egyenlő a két szám, az osztóé fog nyerni.");
            Console.WriteLine("- Ha a 0. körben 22 pontod van, ergo az első két kártyád 11-et és 11-et ér, akkor azzal is lehet nyerni, sőt, az a huszonegy Joker-e.");
            Console.WriteLine();
            Console.WriteLine("Háromféle játékmód közül választhatsz:");
            Console.WriteLine("Könnyű: Ellenfeled (robot) eredménye túllépheti a 22-őt, és te vagy az osztó.");
            Console.WriteLine("Közepes: Ellenfeled (robot) eredménye túllépheti a 22-őt maximum 4 számmal, és te vagy az osztó.");
            Console.WriteLine("Nehéz: Ellenfeled (robot) eredménye minimum 16, maximum 22 lehet, és ő az osztó.");
            //
            bool vegevan = true;
            while (vegevan)
            {
                for (int j = 0; j < 99999; j++)
                {
                    Console.WriteLine();
                    //nehezseg kivalasztasa
                    Console.Write("Kérlek válassz nehézséget ('könnyű', 'közepes' vagy 'nehéz'): ");
                    string nehezseg;
                    nehezseg = Console.ReadLine();
                    Console.WriteLine();
                    //
                    //konnyu jatek
                    if (nehezseg == "könnyű")
                    {
                        int osszeg = 0;
                        int robotkonnyu = random.Next(16, 31);
                        int robotalap = random.Next(0, 8);
                        osszeg += szamok[robotalap];
                        for (int i = 0; i < 100; i++)
                        {
                            Console.WriteLine("{0}. kör", i);
                            int randomszam = random.Next(0, 8);
                            osszeg += szamok[randomszam];
                            Console.WriteLine("Lapjaid összege: {0}", osszeg);
                            Console.Write("Kérsz még lapot? ('igen' vagy 'nem') ");
                            string dontes;
                            dontes = Console.ReadLine();
                            Console.WriteLine();

                            if (dontes == "igen")
                            {
                                continue;
                            }
                            else
                            {
                                if (osszeg == 22)
                                {
                                    string huszonketto;
                                    Console.Write("A 0. körben gyűlt ki a 22 pont? ('igen' vagy 'nem') ");
                                    huszonketto = Console.ReadLine();
                                    if (huszonketto == "nem")
                                    {
                                        Console.WriteLine("VÉGEREDMÉNY: {0}/{1}", osszeg, robotkonnyu);
                                        Console.WriteLine("VESZTETTÉL! :C");
                                        Console.Write("Szeretnél új játékot? ('igen' vagy 'nem') ");
                                        string valasz;
                                        valasz = Console.ReadLine();
                                        if (valasz == "igen")
                                        {
                                            break;
                                        }
                                        if (valasz == "nem")
                                        {
                                            i += 100 - i;
                                            j += 99999 - j;
                                            vegevan = false;
                                        }
                                    }
                                }
                                Console.WriteLine("VÉGEREDMÉNY: {0}/{1}", osszeg, robotkonnyu);
                                if ((osszeg >= 16 && osszeg <= 22 && robotkonnyu > 22) || (osszeg >= 16 && osszeg <= 22 && robotkonnyu < osszeg) || (osszeg >= 16 && osszeg <= 22 && robotkonnyu == osszeg))
                                {
                                    Console.WriteLine("NYERTÉL! C:");
                                    Console.Write("Szeretnél új játékot? ('igen' vagy 'nem') ");
                                    string valasz;
                                    valasz = Console.ReadLine();
                                    if (valasz == "igen")
                                    {
                                        break;
                                    }
                                    if (valasz == "nem")
                                    {
                                        i += 100 - i;
                                        j += 99999 - j;
                                        vegevan = false;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("VESZTETTÉL! :C");
                                    Console.Write("Szeretnél új játékot? ('igen' vagy 'nem') ");
                                    string valasz;
                                    valasz = Console.ReadLine();
                                    if (valasz == "igen")
                                    {
                                        break;
                                    }
                                    if (valasz == "nem")
                                    {
                                        i += 100 - i;
                                        j += 99999 - j;
                                        vegevan = false;
                                    }
                                }
                            }
                        }
                    }
                    //
                    //kozepes jatek
                    if (nehezseg == "közepes")
                    {
                        int osszeg = 0;
                        int robotkozepes = random.Next(16, 27);
                        int robotalap = random.Next(0, 8);
                        osszeg += szamok[robotalap];
                        for (int i = 0; i < 100; i++)
                        {
                            Console.WriteLine("{0}. kör", i);
                            int randomszam = random.Next(0, 8);
                            osszeg += szamok[randomszam];
                            Console.WriteLine("Lapjaid összege: {0}", osszeg);
                            Console.Write("Kérsz még lapot? ('igen' vagy 'nem') ");
                            string dontes;
                            dontes = Console.ReadLine();
                            Console.WriteLine();

                            if (dontes == "igen")
                            {
                                continue;
                            }
                            else
                            {
                                if (osszeg == 22)
                                {
                                    string huszonketto;
                                    Console.Write("A 0. körben gyűlt ki a 22 pont? ('igen' vagy 'nem') ");
                                    huszonketto = Console.ReadLine();
                                    if (huszonketto == "nem")
                                    {
                                        Console.WriteLine("VÉGEREDMÉNY: {0}/{1}", osszeg, robotkozepes);
                                        Console.WriteLine("VESZTETTÉL! :C");
                                        Console.Write("Szeretnél új játékot? ('igen' vagy 'nem') ");
                                        string valasz;
                                        valasz = Console.ReadLine();
                                        if (valasz == "igen")
                                        {
                                            break;
                                        }
                                        if (valasz == "nem")
                                        {
                                            i += 100 - i;
                                            j += 99999 - j;
                                            vegevan = false;
                                        }
                                    }
                                }
                                Console.WriteLine("VÉGEREDMÉNY: {0}/{1}", osszeg, robotkozepes);
                                if ((osszeg >= 16 && osszeg <= 22 && robotkozepes > 22) || (osszeg >= 16 && osszeg <= 22 && robotkozepes < osszeg) || (osszeg >= 16 && osszeg <= 22 && robotkozepes == osszeg))
                                {
                                    Console.WriteLine("NYERTÉL! C:");
                                    Console.Write("Szeretnél új játékot? ('igen' vagy 'nem') ");
                                    string valasz;
                                    valasz = Console.ReadLine();
                                    if (valasz == "igen")
                                    {
                                        break;
                                    }
                                    if (valasz == "nem")
                                    {
                                        i += 100 - i;
                                        j += 99999 - j;
                                        vegevan = false;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("VESZTETTÉL! :C");
                                    Console.Write("Szeretnél új játékot? ('igen' vagy 'nem') ");
                                    string valasz;
                                    valasz = Console.ReadLine();
                                    if (valasz == "igen")
                                    {
                                        break;
                                    }
                                    if (valasz == "nem")
                                    {
                                        i += 100 - i;
                                        j += 99999 - j;
                                        vegevan = false;
                                    }
                                }
                            }
                        }
                    }
                    //
                    //nehez jatek
                    if (nehezseg == "nehéz")
                    {
                        int osszeg = 0;
                        int robotnehez = random.Next(16, 23);
                        int robotalap = random.Next(0, 8);
                        osszeg += szamok[robotalap];
                        for (int i = 0; i < 100; i++)
                        {
                            Console.WriteLine("{0}. kör", i);
                            int randomszam = random.Next(0, 8);
                            osszeg += szamok[randomszam];
                            Console.WriteLine("Lapjaid összege: {0}", osszeg);
                            Console.Write("Kérsz még lapot? ('igen' vagy 'nem') ");
                            string dontes;
                            dontes = Console.ReadLine();
                            Console.WriteLine();

                            if (dontes == "igen")
                            {
                                continue;
                            }
                            else
                            {
                                if (osszeg == 22)
                                {
                                    string huszonketto;
                                    Console.Write("A 0. körben gyűlt ki a 22 pont? ('igen' vagy 'nem') ");
                                    huszonketto = Console.ReadLine();
                                    if (huszonketto == "nem")
                                    {
                                        Console.WriteLine("VÉGEREDMÉNY: {0}/{1}", osszeg, robotnehez);
                                        Console.WriteLine("VESZTETTÉL! :C");
                                        Console.Write("Szeretnél új játékot? ('igen' vagy 'nem') ");
                                        string valasz;
                                        valasz = Console.ReadLine();
                                        if (valasz == "igen")
                                        {
                                            break;
                                        }
                                        if (valasz == "nem")
                                        {
                                            i += 100 - i;
                                            j += 99999 - j;
                                            vegevan = false;
                                        }
                                    }
                                }
                                Console.WriteLine("VÉGEREDMÉNY: {0}/{1}", osszeg, robotnehez);
                                if ((osszeg >= 16 && osszeg <= 22 && robotnehez > 22) || (osszeg >= 16 && osszeg <= 22 && robotnehez < osszeg))
                                {
                                    Console.WriteLine("NYERTÉL! C:");
                                    Console.Write("Szeretnél új játékot? ('igen' vagy 'nem') ");
                                    string valasz;
                                    valasz = Console.ReadLine();
                                    if (valasz == "igen")
                                    {
                                        break;
                                    }
                                    if (valasz == "nem")
                                    {
                                        i += 100 - i;
                                        j += 99999 - j;
                                        vegevan = false;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("VESZTETTÉL! :C");
                                    Console.Write("Szeretnél új játékot? ('igen' vagy 'nem') ");
                                    string valasz;
                                    valasz = Console.ReadLine();
                                    if (valasz == "igen")
                                    {
                                        break;
                                    }
                                    if (valasz == "nem")
                                    {
                                        i += 100 - i;
                                        j += 99999 - j;
                                        vegevan = false;
                                    }
                                }
                            }
                        }
                    }
                    //
                }
            }
            Console.WriteLine();
            Console.Write("Kilépéshez nyomj egy Entert ...");
            Console.ReadKey(true);
        }
    }
}
