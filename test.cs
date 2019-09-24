using System;
using System.Threading;
using System.Net;
using System.IO;  
using System.Runtime.Serialization.Formatters.Binary; 
using System.Runtime.Serialization;
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
					Console.Clear();
					Console.WriteLine("Inicializando...");
					Thread.Sleep(1000);
					VerUsuario();
					Console.ReadKey();
				break;
				case "c":
					Console.WriteLine("En desarrollo...");
					//borrar
					Menu();
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
			Thread.Sleep(1000);
			Console.Clear();
			string pathCarpeta = @"C:\";
			string nombreArchivo = @"Log.txt";
			string rutaArchivo = Path.Combine(pathCarpeta, nombreArchivo);

			try{if(!(Directory.Exists(pathCarpeta)))
				{
				Directory.CreateDirectory(pathCarpeta);
			}
			if(Directory.Exists(pathCarpeta)){

				if(!File.Exists(rutaArchivo)){

					using(var stream = File.Create(rutaArchivo));
				}
			}StreamWriter ficherotpm = new StreamWriter(rutaArchivo);
			ficherotpm.WriteLine("Nombre: {"+ob.nombre+"} Apellido: {"+ob.apellido+"} Edad: {"+" Edad: "+ob.edad+"} Tiempo_Laborando: {"+ob.tiempo+"} fecha_nacimiento: {"+ob.fecha_nacimiento+"} Color_Favorito: {"+ob.color_fav+"} Sueldo: {"+ob.sueldo+"}");
			ficherotpm.Close();

				}catch(Exception E){
					Console.WriteLine(E.Message);
				}Menu();
		}public static void VerUsuario(){
			string log = System.IO.File.ReadAllText(@"C:\log.txt");
			Console.WriteLine("Empelados actuales: "+log);
			Console.WriteLine("\nPresiona cualquier tecla para salir...");
			Menu();
		}
	}
}
