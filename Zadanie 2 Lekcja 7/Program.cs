using System;

namespace KatoApp
{

    class Program
    {
        static void Main(string[] args)
        {

            //Nadanie zmiennej int wartości
            int liczba = 15;


            //Porównanie zmiennych przy użyciu operatora 
            if (liczba % 2 == 0)
            {
                Console.WriteLine(liczba + " jest liczbą parzystą"); //Wyświetlenie komunikatu, gdy liczba jest parzysta
            }
            else
            {
                Console.WriteLine(liczba + " jest liczbą nieparzystą"); //Wyświetlenie komunikatu, gdy liczba jest nieparzysta
            }
        }

    }


}