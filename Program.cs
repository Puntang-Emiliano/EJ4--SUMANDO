using System;

namespace EJ4_SUMA_DOS_NUMEROS
{
    class Program
    {
        static void Main(string[] args)
        {
         Console.Clear();   
         Console.ForegroundColor = ConsoleColor.DarkMagenta;
         
         Console.WriteLine(" /////BIENBENIDO A SUMANDO/////  " );
         Console.ReadKey();
         Console.Clear();
        

         Console.WriteLine ("La suma de sus numeros es : {0}", sumar());
         Console.ReadKey();




        }

       static int sumar()
       {
        int num1,num2, resultado; 
        Console.WriteLine("ingrese el primer numero");
        num1= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("ingrese el segundo numero");
        num2= Convert.ToInt32(Console.ReadLine());
        return resultado= num1+num2;


       }






    }
}
