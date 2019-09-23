using System;
using System.Threading;
namespace program{
	public class primeraopcion{
		public string nombre{get; set;}
		public string apellido{get; set;}
		public int edad{get; set;}
		public int tiempo{get; set;}
		public string fecha_nacimiento{get; set;}
		public string color_fav{get;set;}
		public double sueldo{get; set;}
	}
	class main{
		public static void Menu(){
			Console.WriteLine("Introduce una opcion: \na) Crear empleado.\nb) Ver empleados\nc) Borrar empleados\nd) Salir\n");
			string r = Console.ReadLine().ToLower();
			switch(r){
				case "a":
					Console.Clear();
					Console.WriteLine("Inicializando...");
					Thread.Sleep(1000);
					Crear();
					Console.ReadKey();
				break;
				case "b":
					Console.WriteLine("En desarrollo...");
					//ver
					Console.ReadKey();
				break;
				case "c":
					Console.WriteLine("En desarrollo...");
					//borrar
					Console.ReadKey();
				break;
				case "d":
					Console.WriteLine("Vuelva pronto...");
					Console.ReadKey();
				break;
				default:
					Console.WriteLine("Introduce una opcion valida.");
					Menu();
				break;
			}
		}
		public static void Main(string[] args){
			Console.WriteLine("Bienvenido sea usted la empresa de licores dominicanos, elija una opción");
			Menu();
		}
		public static void Crear(){
			primeraopcion ob = new primeraopcion();
			Console.WriteLine("Introduce el nombre: ");
			ob.nombre = Console.ReadLine();
			Console.Clear();
			Console.WriteLine("Introduce el apellido: ");
			ob.apellido = Console.ReadLine();
			Console.Clear();
			Console.WriteLine("Introduce el edad: ");
			ob.edad = int.Parse(Console.ReadLine());
			Console.Clear();
			Console.WriteLine("Introduce el tiempo laborando (meses): ");
			ob.tiempo = int.Parse(Console.ReadLine());
			Console.Clear();
			Console.WriteLine("Introduce la fecha de nacimiento: (MM/dd/yyy) ejemplo: 08/03/1999");
			Console.WriteLine("Dia: ");string dia = Console.ReadLine();
			Console.WriteLine("Mes: ");string mes = Console.ReadLine();
			Console.WriteLine("Año: ");string año = Console.ReadLine();
			ob.fecha_nacimiento = (""+dia+"/"+mes+"/"+año);
			Console.Clear();
			Console.WriteLine("Introduce el color favorito: ");
			ob.color_fav = Console.ReadLine();
			Console.Clear();
			Console.WriteLine("Introduce el sueldo: (Salario quincenal) Ejemplo: 14.500");
			ob.sueldo = double.Parse(Console.ReadLine());
			Console.Clear();
			Console.WriteLine("Datos introducidos correctamente. \nVolviendo al menu de inicio...");
			Console.ReadKey();
			Console.Clear();
			Menu();
		}
	}
}