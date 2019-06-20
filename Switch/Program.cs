using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables
            float a = 0.0f;
            float b = 0.0f;
            float resultado = 0.0f;
            int opcion = 0;

            //Mostrar el menú
            //dividendo = Convert.ToSingle(Console.ReadLine());


            Console.WriteLine("1 Suma ");
            Console.WriteLine("2 Resta ");
            Console.WriteLine("3 División ");
            Console.WriteLine("4 Multiplicación ");
            Console.WriteLine(" Que operación quiere hacer");

            //Pedimos la opción

            opcion = Convert.ToInt32(Console.ReadLine());


            //Pedimos el primer número

            Console.WriteLine("Dame el primer número: ");
            a = Convert.ToSingle(Console.ReadLine());

            //Pedimos el segundo número

            Console.WriteLine("Dame el segundo número: ");
            b = Convert.ToSingle(Console.ReadLine());

            // Uso del switch

            switch(opcion)
            {
                //Suma
                case 1:
                    resultado = a + b;
                    break;
                //Resta
                case 2:
                    resultado = a - b;
                    break;
                //División
                case 3:
                    if (b!=0)
                    { resultado = a / b; }
                    else
                    {
                        Console.WriteLine("El divisor no es válido ");
                    }
                    break;
                //Multiplicación
                case 4:
                    resultado = a * b;
                    break;

                                                         
            }








        }
    }
}
