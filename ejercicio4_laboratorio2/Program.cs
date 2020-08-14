using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4_laboratorio2
{
    class Program
    {
        static void Main(string[] args)
        {


            int numero;
            Random random = new Random();
            int aleatorio = random.Next(1, 10000);
            int intentos = 0;
            int bandera = 0;


            do
            {
                intentos = intentos + 1;
                Console.WriteLine("Este es el intento numero {0}", intentos);

                Console.WriteLine("Indica el numero que creas: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero == aleatorio)
                {
                    Console.WriteLine("Correcto, has acertado el numero");
                }

                else
                {
                    if (numero < aleatorio && intentos < 13)
                    {
                        Console.WriteLine("Prueba un numero mas alto");
                        
                    }


                    if (numero > aleatorio && intentos < 13)
                    {
                        Console.WriteLine("Prueba un numero mas bajo");
                        
                    }


                    if (numero == aleatorio)
                    {
                        bandera = 1;
                    }

                    else
                    {
                        bandera = 0;
                    }


                }

            } while (intentos < 13);

            if (bandera == 1)
            {
                Console.WriteLine("Correcto, has acertado el numero");
            }

            else
            {
                Console.WriteLine("No has acertado y ya no tienes mas intentos, el numero era {0}", aleatorio);
            }

            Console.ReadKey();
        }
    }
}
