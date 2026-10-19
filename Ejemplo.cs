using System;

namespace SistemaRegistroEstudiantes
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.Clear();

                Console.WriteLine("=================================================");
                Console.WriteLine("SISTEMA DE REGISTRO DE ESTUDIANTES");
                Console.WriteLine("Programación II");
                Console.WriteLine("Práctica de Menús en Consola");
                Console.WriteLine("Año Académico 2026");
                Console.WriteLine("=================================================");
               
                Console.WriteLine("================ MENÚ PRINCIPAL ================");
             
                Console.WriteLine("1. Registrar estudiante");
                Console.WriteLine("2. Consultar estudiante");
                Console.WriteLine("3. Listar estudiantes");
                Console.WriteLine("4. Eliminar estudiante");
                Console.WriteLine("5. Configuración");
                Console.WriteLine("6. Acerca del sistema");
                Console.WriteLine("7. Salir");
        
                Console.WriteLine("Seleccione una opción:");

                opcion = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ha seleccionado:");
                        Console.WriteLine("Registrar estudiante");
                        Console.WriteLine("Aquí se registraría un nuevo estudiante.");
                        break;

                    case 2:
                        Console.WriteLine("Ha seleccionado:");
                        Console.WriteLine("Consultar estudiante");
                        Console.WriteLine("Aquí se consultaría la información de un estudiante.");
                        break;

                    case 3:
                        Console.WriteLine("Ha seleccionado:");
                        Console.WriteLine("Listar estudiantes");
                        Console.WriteLine("Aquí se mostraría la lista de estudiantes registrados.");
                        break;

                    case 4:
                        Console.WriteLine("Ha seleccionado:");
                        Console.WriteLine("Eliminar estudiante");
                        Console.WriteLine();
                        Console.WriteLine("Aquí se eliminaría un estudiante del sistema.");
                        break;

                    case 5:
                        Console.WriteLine("Ha seleccionado:");
                        Console.WriteLine("Configuración");
                        Console.WriteLine();
                        Console.WriteLine("Aquí se mostrarían las opciones de configuración.");
                        break;

                    case 6:
                        Console.WriteLine("Ha seleccionado:");
                        Console.WriteLine("Acerca del sistema");
                        Console.WriteLine();
                        Console.WriteLine("Sistema de Registro de Estudiantes");
                        Console.WriteLine("Práctica de Programación II");
                        Console.WriteLine("Año Académico 2026");
                        break;

                    case 7:
                        Console.WriteLine("Saliendo del sistema...");
                        break;

                    default:
                        Console.WriteLine("Opción incorrecta.");
                        Console.WriteLine("Debe seleccionar una opción del 1 al 7.");
                        break;
                }

                if (opcion != 7)
                {
                    Console.WriteLine();
                    Console.WriteLine("Presione una tecla para volver al menú...");
                    Console.ReadKey();
                }

            } while (opcion != 7);
        }
    }
}