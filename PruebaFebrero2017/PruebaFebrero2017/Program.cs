﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PruebaFebrero2017
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1, Num2, Total;//DEFINIR LA VARIABLESSSS
            Console.Clear(); //LIMPIOLAPANTALLAHHHH
            Console.SetCursorPosition(5,3);
            Console.Write("Digite el Monto: ");
            Num1 = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(5,4);
            Console.Write("Digite otro Monto: ");
            Num2 = int.Parse(Console.ReadLine());
            Total=Num1+Num2;
            Console.SetCursorPosition(5,6);
            Console.Write("El resultado es: "); Console.Write(Total);
            Console.ReadLine();


        }
    }
}