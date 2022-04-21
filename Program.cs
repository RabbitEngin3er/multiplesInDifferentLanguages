// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

class multiples
{
    static void Main()
    {
        Console.WriteLine("----------Insert number to calculate its multiples----------");
        int numero = Convert.ToInt32(Console.ReadLine());
        calculateMultiples(numero);
    }
    static void calculateMultiples(int numero)
    {
        int sizeX = 4;
        int sizeY = 10;
        
        int[,] tabellina = new int[sizeX, sizeY];

        // for(int i = 0; i < 4; i++)
        // {
        //     for(int j=0; j < 5; j++)
        //     {
        //         numeri[i,j] = 25*i + (j+1)*5;
        //     }
        // }
        
        Console.WriteLine("     ---------------------Tabellina del {0}--------------------", numero);

        int a = 1;
        for(int i = 0; i < sizeX; i++)
        {
            for(int j=0; j < sizeY; j++)
            {
                tabellina[i,j] = a*numero;
                a+=1;
            }
        }

        for(int i = 0; i < sizeX; i++)
        {
            for(int j = 0; j < sizeY; j++)
            {
                Console.Write(tabellina[i,j] + "\t");
            }

            Console.WriteLine();
        }
    }
}