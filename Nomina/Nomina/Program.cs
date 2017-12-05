using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomina
{
    class Nomina
    {
        //Programa que permita ingresar el nombre de cinco operarios y sus sueldos respectivos.
        //Mostrar el sueldo mayor y el nombre del operario

        private string[] nombres;
        private float[] sueldos;
        public void Cargar()
        {
            nombres = new string[5];
            sueldos = new float[5];

            for (int f = 0; f < nombres.Length; f++)
            {
                Console.Write("Ingrese el nombre del empleado " + (f + 1) + ": ");
                nombres[f] = Console.ReadLine();

                Console.Write("Ingrese el sueldo del empleado " + (f + 1) + ": ");
                string linea;
                linea = Console.ReadLine();
                sueldos[f] = float.Parse(linea);
            }
        }
        public void MayorSueldo()
        {
            float mayor;
            int pos;
            mayor = sueldos[0];
            pos = 0;

            for (int f = 1; f < nombres.Length; f++)
            {
                if (sueldos[f] > mayor)
                {
                    mayor = sueldos[f];
                    pos = f;
                }
            }
            Console.WriteLine("El empleado con sueldo mayor es: " + nombres[pos]);
            Console.WriteLine("Tiene un sueldo de: " + mayor);
            Console.ReadKey();

        }
        static void Main(string[] args)
        {
            Nomina  pv = new Nomina();
            pv.Cargar();
            pv.MayorSueldo();
        }
    }
}
