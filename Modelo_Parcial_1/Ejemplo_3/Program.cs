using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_3
{
    internal class Program
    {
        #region atributos
        static int acum = 0;
        static int cont = 0;
        #endregion

        #region metodos
        static void IngresarNumero(int num) 
        {
            acum += num;
            cont++;
        }

        static double CalcularPromedio() 
        {
            double promedio = 0;
            if (cont>0) 
            {
                promedio=1.0 * acum / cont;

            } 
            return promedio;
        }

        static int MostarPantalla_SolicitarOpcionMenu() 
        {
            Console.Clear();
            Console.WriteLine("Titulo 1");
            Console.WriteLine("1_Ingrese numero");
            Console.WriteLine("2_Calcualr y mostrar promedio");
            Console.WriteLine("Otro_Salir");

            int opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }

        static void MostrarPantallaIngresarNumero()
        {
            Console.Clear ();
            Console.WriteLine("Ingrese ele numero");
            int num=Convert.ToInt32(Console.ReadLine());
            Program.IngresarNumero(num);

        }

        static void MostrarPantallaCalcularYMostrarPromedio() 
        {
            Console.Clear();
            Console.WriteLine("Titulo Pantalla 3");
            double promedio= Program.CalcularPromedio();
            Console.WriteLine($"Promedio: {promedio}");
            Console.WriteLine("Presionar una tecla");
            Console.ReadKey();
        }

        #endregion

        static void Main(string[] args)
        {
            int opcion = 0;

            do {
                opcion = Program.MostarPantalla_SolicitarOpcionMenu();
                switch (opcion)
                {
                    case 1:
                        Program.MostrarPantallaIngresarNumero();
                        break;
                    case 2:
                        Program.MostrarPantallaCalcularYMostrarPromedio();
                        break;
                    default:
                        opcion = -1;
                        break;
                }
            } while (opcion!=-1);

            Console.WriteLine("Presione una tecla para finalizar el programa");
            Console.ReadKey();
        }
    }
}
