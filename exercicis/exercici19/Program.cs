﻿namespace exercici19;

// Assigna una paraula a una variable de text. Utilitza una funció per a obtenir la seva longitud i 
// imprimeix la paraula i el seu nombre de caràcters.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Dona'm una paraula");
        string paraula = Console.ReadLine()!;

        Console.WriteLine("La paraula" + " " + paraula + " " + "conté un total de" + " " + paraula.Length + " " + "lletres");
    }
}
