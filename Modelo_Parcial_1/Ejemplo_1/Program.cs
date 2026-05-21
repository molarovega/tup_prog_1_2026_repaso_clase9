using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Inicializar Acum y Cont

            int opcion = 0;
            int acum = 0;
            int cont = 0;

            #endregion

            #region Iterar 20 numeros

            for (int n=0;n>20;n++)
            {
                #region Solicitar un numero
                Console.WriteLine("Ingrese");
                int num = Convert.ToInt32(Console.ReadLine());
                #endregion

                #region Actualizar acumulador
                acum += num;
                #endregion

                #region Actualizar contador 
                cont++;
                #endregion

            }
            #endregion

            #region calcular promedio
            double promedio =1.0*acum / cont;
            #endregion

            #region mostrar promedio
            Console.WriteLine($"Promedio: {promedio}");
            #endregion
            Console.WriteLine("Presione cualquier tecla");
            Console.ReadKey();



            
        }
    }
}
