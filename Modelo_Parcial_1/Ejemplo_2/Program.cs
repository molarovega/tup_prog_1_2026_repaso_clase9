using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            int acum = 0;
            int cont=0;


            do
            {
                Console.Clear();
                Console.WriteLine("Titulo 1");
                Console.WriteLine("1_Ingresar numero");
                Console.WriteLine("2_Calcular y mostrar promedio");
                Console.WriteLine("Otro_Salir");
                opcion = Convert.ToInt32(Console.ReadLine());


                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Ingrese un numero");
                        int num = Convert.ToInt32(Console.ReadLine());
                        acum += num;
                        cont++;
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Titulo pantalla 3");
                        double promedio = 0;
                        if (cont > 0)
                        {
                            promedio = 1.0 * acum / cont;
                            Console.WriteLine($"Promedio: {promedio}");
                        }
                        else
                        {
                            Console.WriteLine("No hubo ingreso");
                        }
                        Console.WriteLine("Presione una tecla para volver al menu principal");
                        Console.ReadKey();
                        break;
                    default: 
                        opcion = -1;
                        break;
                }
            } while (opcion != -1);
            Console.WriteLine("Presionar una tecla para finalizar");
            Console.ReadKey();
        }
    }
}
