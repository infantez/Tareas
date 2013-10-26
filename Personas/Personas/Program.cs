using System;

namespace Personas
{
	class Program
	{
		public string nombre;
		public string correo;
		public int edad;
		
		public static void Main(string[] args)
		{
			Program p = new Program();
		
			Console.WriteLine("Ingresa tu nombre \n");
			p.nombre = Console.ReadLine();
			Console.Clear();
			
			Console.WriteLine("Ingresa tu correo \n");
			p.correo = Console.ReadLine();
			Console.Clear();
				
			Console.WriteLine("Ingresa tu edad \n");
			p.edad=int.Parse(Console.ReadLine());
			Console.Clear();
				
			Console.WriteLine("Tus datos son: \n" + p.nombre + ("\n") + p.correo + ("\n") + p.edad );
			Console.ReadLine();
		}
	}
}