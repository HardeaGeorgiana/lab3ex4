using System;

namespace lab3ex4
{
    /*  Se citeste de la tastatura un vector continand n numere intregi, 
        n fiind si el citit la randul sau citit de la tastatura. 
        Scrieti functii care vor returna
         • Cel mai mare numar din vector
         • Cel mai mic numar din vector
         • Numerele divizibile cu 3
        Dificultate ridicata
         • Numerele prime din vector
           Apelati functiile si afisati-le rezultatele.
    */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cate numere sa contina vectorul?");
            int contor = int.Parse(Console.ReadLine());
            int[] vector = PopulateVector(contor);

           // Console.WriteLine($"Cel mai mare numar este {CelMaiMare(vector)}");
           // Console.WriteLine($"Cel mai mic numar este {CelMaiMic(vector)}");
           // Console.WriteLine($"Numere divizibile cu 3: {Divizibil(vector)}");
           // Console.WriteLine($"Numerele prime din vector sunt: {NumarPrim(vector)}");


        }

        static int[] PopulateVector(int contor)
        {
            int[] newVector = new int[contor];

            for (int i = 0; i < contor; i++)
            {
                int num = int.Parse(Console.ReadLine());
                newVector[i] = num;
            }
            return newVector;
        }

        static int Max(int a, int b)
        {
            if (a > b)
            {
                return a;
            }

            else
            {
                return b;
            }
        }

        static int CelMaiMare(int[] vector)
        {
            int mare = vector[0];

            for (int i = 0; i < vector.Length; i++)
            {
                mare = Max(mare, vector[i]);
            }
            return mare;
        }

        static int Min(int a, int b)
        {
            if (a > b)
            {
                return b;
            }

            else
            {
                return a;
            }
        }

        static int CelMaiMic(int[] vector)
        {
            int mic = vector[0];

            for (int i = 0; i < vector.Length; i++)
            {
                mic = Min(mic, vector[i]);
            }
            return mic;
        }
        static string Divizibil(int[] vector)
        {
            string numere = "";

            for (int i = 0; i < vector.Length; i++)
            { 
                if(vector[i] % 3 == 0)
                {
                    numere = numere + $", {vector[i]}";
                
                }
            }
            return numere;
        }

       static string NumarPrim(int[] vector)
        {
            string numere = "";

           for(int i = 0; i < vector.Length; i++)
            {
                if (vector[i] <= 1)
                {
                    continue;
                }
                for (int j = 2; j <= vector[i] / 2; j++)
                {
                    if(vector[i] % j == 0)
                    {

                    }
                    else
                    {
                        numere = numere + $"{vector[i]}, ";
                        break;
                    }
                }
            }
            return numere;
               
        }
       
    }
}
