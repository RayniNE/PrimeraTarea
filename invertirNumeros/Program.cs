using System;

namespace invertirNumeros
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declarando las variables.
            string numString;
            int numInt;

            Console.WriteLine("Primera tarea: Invertir número de dos cifra.");
            Console.Write("Ingrese el número de dos cifras: ");
            numString = Console.ReadLine();
            //Se chequea si el valor introducido es un número y si tiene doble digitos.
            if (int.TryParse(numString, out numInt))
            {
                double countDigits = Math.Floor(Math.Log10(numInt)) + 1;
                if (countDigits == 2)
                {
                    string num = numInt.ToString();
                    char[] numArray = num.ToCharArray();
                    Console.Write("El inverso es: ");

                    for (int i = numArray.Length - 1; i >= 0; i--)
                    {
                        Console.Write("" + numArray[i]);
                    }
                }
                else
                {
                    Console.WriteLine("El número que introdujo no tiene dos digitos.");
                }

            }
            else
            {
                Console.WriteLine("Lo que ha introducido no es un número, el programa se cerrara.");
            }
            Console.ReadKey();


        }

    }
}
