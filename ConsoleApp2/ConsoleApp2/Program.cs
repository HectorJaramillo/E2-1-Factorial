using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp2
{
    public class Factorial
    {   
        public int CalculoFactorial(int Numero)
        {
            int NumeroFactorial = 1;
            for(int Indice=1;Indice<Numero+1;Indice++)
            { NumeroFactorial = NumeroFactorial * Indice; }
            Console.Write("El numero a calcular es: {0}! y su resultado es: ", Numero);   
            return NumeroFactorial;
        }
          public int FactorialRecursivo(int Numerador)
        {
            if(Numerador==0)
            {return 1;}
            else
            {
                return Numerador * FactorialRecursivo(Numerador - 1);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Numeros Factoriales con y sin Recursividad";
            Stopwatch Tiempo = new Stopwatch();
            int Numero;
            Console.WriteLine("Ingrese el numero del que desea sacar el factorial");
            Numero = Convert.ToInt32(Console.ReadLine());
            Factorial Factor = new Factorial();
            Tiempo.Start();
            Console.WriteLine(Factor.CalculoFactorial(Numero));  
            Console.WriteLine("Proceso Realizado en un tiempo de:  {0}", Tiempo.Elapsed.ToString());
            Tiempo.Stop();
            Tiempo.Start();
            Console.WriteLine("El numero a Calcular es: {0}! y el resultado es: {1}", Numero,Factor.FactorialRecursivo(Numero));
            Console.WriteLine("Proceso Realizado en un tiempo de:  {0}", Tiempo.Elapsed.ToString());
            Tiempo.Stop();
            Console.ReadKey(true);
            
            
            

        }
    }
}
