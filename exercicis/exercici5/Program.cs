namespace exercici5;

/* Feu un programa que demani un nom i l’any de naixement i imprimeixi per pantalla 
“Hola [nom]!  Ja tens [edat] anys? 
nom i edat seran el nom introduït i l'edat la resta de l’any actual i l’any de naixement. */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quin es el teu nom?");
        var nom = Console.ReadLine();
        Console.WriteLine("Quin es el teu any de naixement?");
        var any = Console.ReadLine();
        int any1 = Convert.ToInt16(any);

        /* int any = Convert.ToInt16(Console.ReadLine()); */

        Console.WriteLine("Hola" + " " + nom + " " + "Ja tens" + " " + (2025-any1) + " "+ "anys?");

    }
}
