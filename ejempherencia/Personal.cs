using System;
using System.Collections;

namespace ejempherencia
{
	public class Personal
	{
		private int _Id;
		private string _Nombre;
		private string _Apellidos;
		
		public int Id
		{
			get { return _Id; }
			set { _Id = value; }
		}
		
		public string Nombre
		{
			get { return _Nombre; }
			set { _Nombre = value; }
		}
		
		public string Apellidos
		{
			get { return _Apellidos; }
			set { _Apellidos = value; }
		}
		
		public Personal(int pId, string pNombre, string pApellido)
		{
			Id = pId;
			Nombre = pNombre;
			Apellidos = pApellido;
		}
	}
	
	class Profesor : Personal
	{
		private string _Direccion;
		
		public string Direccion
		{
			get { return _Direccion; }
			set { _Direccion = value; }
		}
		
		public Profesor(int pId, string pNombre, string pApellido, string pDireccion)
			: base(pId, pNombre, pApellido)
		{
			Direccion = pDireccion;
		}
		
		public string _variable = "Hola Hijo";
		
		public int Metodo(int a, int b)
		{
			return a + b;
		}
	}
	
	
}
