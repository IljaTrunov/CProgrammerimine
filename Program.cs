using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CProgrammerimine
{
    class Program
    {
        static void Main(string[] args)
        {
            /*double hind;
            hind = 10;
            string pilet_tuup="täispilet";
            Console.WriteLine("Mis on sinu nimi, vene okkupand?");
            string eesnimi = Console.ReadLine();
            Console.Write("Tere tulemast! {0}", eesnimi);
            if (eesnimi.ToLower() == "okkupand")
            {
                Console.WriteLine("\nTule külla!, Kas sa tahab kino minna? ");
                string vastus = Console.ReadLine();
                if (vastus.ToUpper()=="JAH" || vastus.ToUpper()=="YES")
                {
                    Console.WriteLine("\nKui vana sa oled ");
                    int vanus = int.Parse(Console.ReadLine());
                    if (vanus < 0 || vanus > 108)
                    {
                        Console.WriteLine("Viga andmega!");
                        pilet_tuup = "0, sa oled vana ja võib olla surnud.";
                    }
                    else if (vanus < 6 || vanus >= 65)
                    {
                        hind -= hind * 1;
                        pilet_tuup = "tasuta";
                    }
                    else if (vanus >= 6 && vanus < 12)
                    {
                        hind -= hind * 0.3;
                        pilet_tuup="See on laastepilet";
                    }
                    else if (vanus >= 12 && vanus < 18)
                    {
                        hind -= hind * 0.1;
                        pilet_tuup = "See on täispilet";
                    }
                    char[] tahed = eesnimi.ToCharArray();
                    int i = 0;
                    eesnimi = "";
                    foreach (var t in tahed) 
                    {
                        if (i==0)
                        {
                            eesnimi +=t.ToString().ToUpper();

                        }
                        else
                        {
                            eesnimi +=t.ToString().ToLower();
                        }
                        i += 1;
                    }

                    Console.WriteLine("{0}, sul on {1} vaja maksta {2}", eesnimi, hind, pilet_tuup);


                }
                else
                {
                    Console.WriteLine("Mõtle valja ise...");
                }
            
            }
            else
            {
                Console.WriteLine("\nMind täna kodus pole! :( ");
            }
            Console.ReadKey();*/

            string pinginaabrid ="((Artem && Timofei ) || (German && Kevin))";
            Console.WriteLine("Mis on sinu pinginaaber täna on?");
            string vastus=Console.ReadLine();
            if (vastus.ToLower() == "artem" || vastus.ToUpper() == "Artem")
            {
                Console.WriteLine("Selge, sinu pinginaaber on ", pinginaabrid);
            }
            else if (vastus.ToLower() == "timofei" || vastus.ToUpper() == "TIMOFEI")
            {
                Console.WriteLine("Selge, sinu pinginaaber on Ilja!");
            }

        }
    }
}
