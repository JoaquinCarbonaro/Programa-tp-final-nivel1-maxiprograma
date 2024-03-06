using System;

namespace TPFinal_Carbonaro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que permita ingresar una lista de números que corta 
            // cuando se ingresa un cero. A partir de dichos datos informar:
                // a. El mayor de los números pares.
                // b. La cantidad de números impares.
                // c. El menor de los números primos.
            // Nota: evaluar el uso de una función que analice si un número dado 
            // es primo o no y que devuelva true o false según corresponda.

            int n, mayorPar = 0, conImp = 0, menorPrimo = 0;
            bool banPar = false, banPrimo = false;
            
            Console.WriteLine("Ingrese un numero: ");
            n = int.Parse(Console.ReadLine());
            
            while (n != 0)
            {
                if (n % 2 == 0)
                {
                    if (!banPar)
                    {
                        mayorPar = n;
                        banPar = true;
                    }else if (n > mayorPar)
                    {
                        mayorPar = n;
                    }
                }else
                {
                    conImp ++;
                }

                if (primo(n))
                {
                    if (!banPrimo)
                    {
                        menorPrimo = n;
                        banPrimo = true;
                    }else if (n < menorPrimo)
                    {
                        menorPrimo = n;
                    }
                }

                Console.WriteLine("Ingrese un numero: ");
                n = int.Parse(Console.ReadLine()); 
            }

            Console.WriteLine("El mayor de los números pares es: " + mayorPar);
            Console.WriteLine("La cantidad de números impares es: " + conImp);
            Console.WriteLine("El menor de los números primos es es: " + menorPrimo);    
        }

        static bool primo(int a){
            int con = 0;
            for (int x = 1; x <= a; x++)
            {
                if (a % x == 0)
                {
                    con ++;
                }
            }
            if (con == 2)
            {
                return true;
            }else
            {
                return false;
            }  
        }
    }
}
