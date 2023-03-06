using System;

class Program
{
    static void Main(string[] args)
    {
        // Solicitar al usuario que ingrese un número entero positivo mayor que 0
        Console.Write("Escriba un número entero positivo mayor que 0 ");
        Console.WriteLine("(En numeros no palabras)");
        int numero = int.Parse(Console.ReadLine());

        // Calcular el cuadrado de los números enteros positivos menores o iguales que el numero ingresado
        int[] cuadrados = new int[numero];
        for (int i = 1; i <= numero; i++)
        {
            cuadrados[i - 1] = i * i;
        }

        //Números enteros positivos menores o iguales que la variable Numero que sean primos
        Console.Write("Los números primos menores o iguales que {0} son: ", numero);
        for (int i = 2; i <= numero; i++)
        {
            bool esPrimo = true;
            for (int j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    esPrimo = false;
                    break;
                }
            }
            if (esPrimo)
            {
                Console.Write("{0} ", i);
            }
        }
        Console.WriteLine();

        //Todos los números enteros positivos menores o iguales que numero que sean múltiplos de 4
        Console.Write("Los múltiplos de 4 menores o iguales que {0} son: ", numero);
        for (int i = 4; i <= numero; i += 4)
        {
            Console.Write("{0} ", i);
        }
        Console.WriteLine();

        //Secuencia de todos los números enteros positivos que comienzan en 1 y se incrementan en 3 hasta que se alcance un valor mayor que numero
        Console.Write("La secuencia de números enteros que comienzan en 1 y se incrementan en 3 hasta alcanzar un valor mayor que {0} es: ", numero);
        int x = 1;
        while (x <= numero)
        {
            Console.Write(x + ",");
            x += 3;

        }
        Console.Write(x);

        //Todos los valores del arreglo que contiene los cuadrados de los números enteros menores o iguales que la variable Numero
        Console.Write("\nLos cuadrados de los números enteros menores o iguales que {0} son: ", numero);
        for (int i = 0; i < numero; i++)
        {
            Console.Write("{0} ", cuadrados[i]);
        }
        Console.WriteLine();
    }
}
