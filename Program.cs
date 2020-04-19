using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradosARadianes
{
    class Program
    {
        //Funcion para concertir grados a radianes
        static double ConvertirGrados(double grad)
        {
            double rad = 0.0f;

            rad = grad * 3.14 / 180;

            return rad;
        }
        //Funcion principal
        static void Main(string[] args)
        {
            double grados = 0.0f, radianes = 0.0f;

            Console.Write("Escriba el numero en grados que desea convertir: ");

            grados = Convert.ToDouble(Console.ReadLine());

            radianes = ConvertirGrados(grados);

            Console.WriteLine("{0} grados = {1} radianes", grados, radianes);

            Console.ReadKey();
            
        }
    }
}
