/******* Fuente de Info. http://codigofuentenet.wordpress.com/2012/07/17/herencia-en-c/ ***********/

using System;

namespace ejempherencia
{
	class Program
	{
		public static void Main(string[] args)
		{
			Profesor _Profesor = new Profesor(1, "Marcos", "Aguilar", "Sonsonate");
			Personal _Personal = new Personal(1, "Nestor", "Infante");
			
			Console.WriteLine("Clase Profesor");
			Console.WriteLine(_Profesor._variable);
			Console.WriteLine(_Profesor.Metodo(1,2));
			Console.WriteLine("Id : {0} ", _Profesor.Id);
			Console.WriteLine("Nombre : {0} ", _Profesor.Nombre);
			Console.WriteLine("Apellido : {0} ", _Profesor.Apellidos);
			Console.WriteLine("Direccion : {0} ", _Profesor.Direccion);
			Console.WriteLine("------------------------------");
			Console.WriteLine("Clase Personal");
			Console.WriteLine("Id : {0} ", _Personal.Id);
			Console.WriteLine("Nombre : {0} ", _Personal.Nombre);
			Console.WriteLine("Apellido : {0} ", _Personal.Apellidos);
		    
			Console.ReadKey();
		}
	}
}

