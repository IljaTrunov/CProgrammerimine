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
			
			//Console.WriteLine("Tere nimeta nime pinginaabri => ");
			//string n1 = Console.ReadLine();
			//Console.WriteLine("Nimeta nime pinginaabri => ");
			//string n2 = Console.ReadLine();
			//if ((n1 == "Mihhail" && n2 == "Marco") || (n2 == "Mihhail" && n1 == "Marco") || (n1 == "Edgar" && n2 == "Marco") || (n2 == "Edgar" && n1 == "Marco") || (n1 == "Aleksandr" && n2 == "Aleksandr") || (n1 == "Aleksandr" && n2 == "Daniil") || (n2 == "Aleksandr" && n1 == "Daniil") || (n1 == "Alina" && n2 == "Jelena") || (n2 == "Alina" && n1 == "Jelena") || (n1 == "Ervin" && n2 == "Vlademir") || (n2 == "Ervin" && n1 == "Vlademir"))
			//{
			//	Console.WriteLine("Nad on pinginaabrid!");
			//}
			//else
			//{
			//	Console.WriteLine("Nad ei ole pinginaabrid!");
			//}



			Console.ReadKey();
		}




	}
}	
//			double hind = 15;
//			string pilet_tuup = "tais";
//			Console.WriteLine("Tere tulemast !!! Mis on sinu nimi ");//метод
//			Console.Title="Pealkiri";//свойство 
//			string nimi = Console.ReadLine();
//			Console.WriteLine("Tere {0}",nimi);
//			if (nimi.ToUpper()=="JUKU" || nimi.ToLower()=="alina")
//			{
//				Console.WriteLine($"Tule küla {nimi} Kas tahad kinno ");
//				string vastus = Console.ReadLine();
//				if (vastus.ToLower()=="jah"|| vastus.ToLower()=="yes")
//				{
//					Console.WriteLine("Kui vana sa oled?");
//					int vanus = int.Parse(Console.ReadLine());
//					if (vanus < 0 || vanus > 108)
//					{
//						Console.WriteLine("Viga andmega!");
//						pilet_tuup = "0, sa oled vana ja võib olla surnud.";
//					}
//					else if (vanus < 6 || vanus >= 65)
//					{
//						hind -= hind * 1;
//						pilet_tuup = "tasuta";
//					}
//					else if (vanus >= 6 && vanus < 12)
//					{
//						hind -= hind * 0.3;
//						pilet_tuup = "See on laastepilet";
//					}
//					else if (vanus >= 12 && vanus < 18)
//					{
//						hind -= hind * 0.1;
//						pilet_tuup = "See on täispilet";
//					}
//					char[] tahed = nimi.ToCharArray();//juku->['j','u','k','u']
//					int i = 0;
//					nimi = "";
//					foreach (var t in tahed)
//					{
//						if (i == 0)
//						{
//							nimi += t.ToString().ToUpper();// программа делает букву большой
//						}
//						else
//						{
//							nimi += t.ToString().ToLower();
//						}
//						i++;
//					}
//						Console.WriteLine("{0},sul on {2}pilet vaja maksata {1}", nimi, hind,pilet_tuup);
//				}
//				else
//				{
//					Console.WriteLine("Ei taha?!:(");
//				}
//			}
//			else 
//			{
//				Console.WriteLine("Täna ma olen hõivatud! :(");
//			}
			
//		
//		}
//	}
//}
