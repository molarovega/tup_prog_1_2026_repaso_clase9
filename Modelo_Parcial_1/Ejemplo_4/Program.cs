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
        public static Program p = new Program();
        public int acum = 0;
        public int cont = 0;
        #endregion

        #region metodos
        public void IngresarNumero(int num)
        {
            acum += num;
            cont++;
        }

        public double CalcularPromedio()
        {
            double promedio = 0;
            if (cont > 0)
            {
                promedio = 1.0 * acum / cont;

            }
            return promedio;
        }

        public int MostarPantalla_SolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine("Titulo 1");
            Console.WriteLine("1_Ingrese numero");
            Console.WriteLine("2_Calcualr y mostrar promedio");
            Console.WriteLine("Otro_Salir");

            int opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }

        public void MostrarPantallaIngresarNumero()
        {
            Console.Clear();
            Console.WriteLine("Ingrese ele numero");
            int num = Convert.ToInt32(Console.ReadLine());
            p.IngresarNumero(num);

        }

        public void MostrarPantallaCalcularYMostrarPromedio()
        {
            Console.Clear();
            Console.WriteLine("Titulo Pantalla 3");
            double promedio = p.CalcularPromedio();
            Console.WriteLine($"Promedio: {promedio}");
            Console.WriteLine("Presionar una tecla");
            Console.ReadKey();
        }

        #endregion

        static void Main(string[] args)
        {
            int opcion = 0;

            do
            {
                opcion = p.MostarPantalla_SolicitarOpcionMenu();
                switch (opcion)
                {
                    case 1:
                        p.MostrarPantallaIngresarNumero();
                        break;
                    case 2:
                        p.MostrarPantallaCalcularYMostrarPromedio();
                        break;
                    default:
                        opcion = -1;
                        break;
                }
            } while (opcion != -1);

            Console.WriteLine("Presione una tecla para finalizar el programa");
            Console.ReadKey();
        }
    }
}
