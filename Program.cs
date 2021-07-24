using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            //Algoritmo que faz a tabuada básica(até 10) de qualquer número
            //autor: Bruno Silva Rodrigues


            int contador = 0, numero, resultado;

            Console.WriteLine("Digite um número");
            numero = int.Parse(Console.ReadLine());
            Console.Clear();

            do
            {
                resultado = numero * contador;
                Console.WriteLine("{0} X {1} = {2}", numero, contador, resultado);
                Console.WriteLine("\t");
                contador++;
            } while (contador <= 10);


            Console.ReadKey();
        }
    }
}
