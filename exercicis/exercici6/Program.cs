namespace exercici6;

/* Declara una variable per al costat d'un quadrat. Calcula el seu perímetre (suma dels quatre costats) 
i imprimeix-lo. */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("De quant es el costat del quadrat?");
        var costat = Console.ReadLine();
        int costat1 = Convert.ToInt16(costat);

        var perimetre = 4;

        Console.WriteLine("El perímetre del teu quadrat és:" + " " + (costat1 * perimetre));
    }
}
