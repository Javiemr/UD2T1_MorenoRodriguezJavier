///////////////////////////////////////////
// Tarea: UD2T1
// Alumno: Javier Moreno Rodríguez
// Curso: 2023/2024
///////////////////////////////////////////


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD2T1_MorenoRodríguezJavier
{  
    /// 
    /// Se genera la clase que representa al empleado
    /// 
    public class Empleado
    {
        /// 
        /// Declaración de los atributos de la clase
        /// 
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public int Edad { get; set; }
        public string Nif { get; set; }
        public double Salario { get; set; }



        public Empleado(string nombre, string apellido1, string apellido2, int edad, string nif, double salario)
        {
            ///
            ///Se utiliza el constructor con los parámetros
            ///
            Nombre = nombre;
            Apellido1 = apellido1;
            Apellido2 = apellido2;
            Edad = edad;
            Nif = nif;
            Salario = salario;
        }
        /// 
        ///  Método para devolver el nombre completo del empleado
        /// 
        public string NombreCompleto 
        {
            get { return $"{Nombre} {Apellido1} {Apellido2}"; }
        }

        /// 
        /// Metodo para actualizar el salario del empleado para el nuevo valor introducido
        ///
        public void ActualizarSalario(double nuevoSalario) 
        {
            Salario = nuevoSalario;
        }
    }

    /// 
    /// Clase principal del programa
    /// 
    class Program
    {
        static void Main()
        {
            Empleado empleado = null;

            while (true)
            {
                ///
                /// Menú del interfaz
                ///

                Console.WriteLine("0 - Salir");
                Console.WriteLine("1 - Crear empleado");
                Console.WriteLine("2 - Actualizar salario");
                Console.WriteLine("3 - Mostrar nombre");
                Console.WriteLine("4 - Mostrar NIF");
                Console.WriteLine("5 - Actualizar NIF");
                Console.WriteLine("6 - Mostrar edad");
                Console.WriteLine("7 - Mostrar empleado");
                Console.Write("\nIntroduzca su opción: ");

                ///
                ///Variable para almacenar la opción 
                ///

                string opcion = Console.ReadLine();

               ///
               /// Ejecución de la opción elegida
               ///
                switch (opcion)
                {


                    ///
                    ///Salir del programa
                    ///

                    case "0":
                        Environment.Exit(0);
                        break;

                    ///
                    /// Crear empleado
                    ///

                    case "1":
                        Console.Write("Nombre: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Apellido1: ");
                        string apellido1 = Console.ReadLine();
                        Console.Write("Apellido2: ");
                        string apellido2 = Console.ReadLine();
                        Console.Write("Edad: ");
                        int edad = int.Parse(Console.ReadLine());
                        Console.Write("NIF: ");
                        string nif = Console.ReadLine();
                        Console.Write("Salario: ");
                        double salario = double.Parse(Console.ReadLine());

                        empleado = new Empleado(nombre, apellido1, apellido2, edad, nif, salario);
                        break;

                    ///
                    /// Actualizar salario
                    ///

                    case "2":
                        if (empleado != null)
                        {
                            Console.Write("Nuevo salario: ");
                            double nuevoSalario = double.Parse(Console.ReadLine());
                            empleado.ActualizarSalario(nuevoSalario);
                            Console.WriteLine("Salario actualizado.");
                        }
                        else
                        {
                            Console.WriteLine("No se ha creado un empleado.\n");
                        }
                        break;

                    ///
                    /// Mostrar nombre
                    ///

                    case "3":
                        if (empleado != null)
                        {
                            Console.WriteLine(empleado.NombreCompleto);
                        }
                        else
                        {
                            Console.WriteLine("No se ha creado un empleado.\n");
                        }
                        break;

                    ///
                    /// Mostrar NIF
                    ///

                    case "4":
                        if (empleado != null)
                        {
                            Console.WriteLine(empleado.Nif);
                        }
                        else
                        {
                            Console.WriteLine("No se ha creado un empleado.\n");
                        }
                        break;

                    ///
                    /// Actualizar NIF
                    ///

                    case "5":
                        if (empleado != null)
                        {
                            Console.Write("Nuevo NIF: ");
                            string nuevoNif = Console.ReadLine();
                            empleado.Nif = nuevoNif;
                            Console.WriteLine("NIF actualizado.");
                        }
                        else
                        {
                            Console.WriteLine("No se ha creado un empleado.\n");
                        }
                        break;

                    ///
                    ///Mostrar Edad
                    ///

                    case "6":
                        if (empleado != null)
                        {
                            Console.WriteLine($"Edad: {empleado.Edad} años");
                        }
                        else
                        {
                            Console.WriteLine("No se ha creado un empleado.\n");
                        }
                        break;

                    ///
                    /// Mostrar Empleado
                    ///

                    case "7":
                        if (empleado != null)
                        {
                            Console.WriteLine($"Nombre: {empleado.NombreCompleto}");
                            Console.WriteLine($"Edad: {empleado.Edad} años");
                            Console.WriteLine($"NIF: {empleado.Nif}");
                            Console.WriteLine($"Salario: {empleado.Salario}€");
                        }
                        else
                        {
                            Console.WriteLine("No se ha creado un empleado.\n");
                        }
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.\n");
                        break;
                }
            }
        }
    }
}

