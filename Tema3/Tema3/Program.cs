using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema3
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Scrieti un program care stocheaza intr-un vector 3 variabile de tip double declarate de voi si le afiseaza parcurgand vectorul.
            double[] doubleArray = new double[] { 4.72, 9.34, 12.84 };
            for (int i = 0; i < doubleArray.Length; i++)
            {
                Console.WriteLine("Elementul de la indexul " + i + " este: " + doubleArray[i]);
            }

            //2.Scrieti un program care afiseaza minimul, respectiv maximul dintr-un array de lungime 10.

            int[] intArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Numarul maxim este:" + intArray.Max());
            Console.WriteLine("Numarul minim este:" + intArray.Min());

            //3.Scrieti o clasa ce declara un array de tip int cu o singura valoare negativa si restul pozitive.Afisati pozitia valorii negative din array.

            int[] array = new int[] { 3, 7, -4, 12 };
            for (int a = 0; a < array.Length; a++)
            {
                if (array[a] < 0)
                {
                    Console.WriteLine("Valoarea negativa este la indexul:" + a);
                }
            }

            //4.Scrieti o clasa ce transforma un String intr-un array de caractere.

            String sir = "Transforma un String intr-un array de caractere";
            char[] sirDeCaractere = new char[sir.Length];
            for (int b = 0; b < sir.Length; b++)
            {
                sirDeCaractere[b] = sir[b];
                Console.WriteLine("Caracterul de la indexul " + b + " este " + sirDeCaractere[b]);
            }

            //5.Transformati un sir de caractere astfel: fiecare litera de pe pozitie para sa fie uppercase.

            String sirCaractere = "Fiecare litera de pe pozitie para sa fie uppercase";
            char[] caractere = new char[sirCaractere.Length];
            for (int c=0; c< sirCaractere.Length; c++)
            {
                if (c % 2 == 0)
                {
                    caractere[c] = sirCaractere.ToUpper()[c];
                }
                else
                {
                    caractere[c] = sirCaractere[c];
                }
            }
            String sirCaractereNou = new String(caractere);
            Console.WriteLine(sirCaractereNou);

            //6.Avand un vector de numere intregi, adunati un nr double la valorile stocate si pastrati rezultatul in alt vector corespunzator.

            int[] vector = new int[] { 11, 7, 104, 78 };
            double doubleNumar = 21.7;
            for (int y = 0; y < vector.Length; y++)
            {
                vector[y] = vector[y] + (int)doubleNumar;
            }
            for (int x = 0; x < vector.Length; x++)

            {
                Console.WriteLine(vector[x]);
            }
            Console.ReadLine();

        }
    }
}
