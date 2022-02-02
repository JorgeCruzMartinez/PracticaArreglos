using System;

// http://venkatcsharpinterview.blogspot.com/2011/05/c-interview-questions-by-topic.html
namespace Practica_Arreglos
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	class Class1
	{		
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		static string[] discos = new string [4];
		static string cadena = "";
		static string varaux = "";
		[STAThread]
		static void Main()
		{
            string[] discos = new string[] { "Best Of Van Halen Volumen 1", "Billy Joel (Greatest Hits)", "White Snake (Greatest Hits)", "Hysteria", "Dark Side Of The Moon" };

            for (byte contador = 0; contador < 4; contador++)
            {
                cadena = "discos[" + contador + "] = ";
                AsignaValor(contador);
                discos[contador] = cadena + varaux;
            }

            for (byte contador = 0;contador < 4;contador++)
			{   
                if (contador < 3)
                    Console.WriteLine (discos[contador]);
                else
                    Console.Write (discos[contador]);
			}
			Console.Read();
		}

		static void AsignaValor(byte counter)
		{ 
			switch (counter)
			{  
				case 0:
					varaux = " Van Halen (Best Of Van Halen Volumen 1)";										
					break;
				case 1:
				    varaux = "Billy Joel (Greatest Hits)";
					break;
				case 2:
				    varaux = "White Snake (Greatest Hits)";
					break;
				case 3:
					varaux = "Deff Lepard (Hysteria)";
					break;
				case 4:
					varaux = "Pink Floyd (Dark Side Of The Moon)";
					break;
			}
		}
	}
}
