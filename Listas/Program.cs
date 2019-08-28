using System;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            var diasSemana = new List<string>();
            numeros.Add(5);
            numeros.Add(10);
            numeros.Add(15);
            numeros.Add(20);
            numeros.Add(25);
            diasSemana.Add("Lunes");
            diasSemana.Add("Domingo");
            diasSemana.Add("Martes");

            Console.WriteLine("Esta es la lista de numeros");
            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Esta es la lista de Dias Semanas");
            foreach (var item2 in diasSemana)
            {
                Console.WriteLine(item2);
            }

            Console.WriteLine("Eliminando 25 lista numeros");
            numeros.Remove(25);
            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }

        }
    }
}