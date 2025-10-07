namespace exercici8;

/* Assigna un nombre total de minuts a una variable. 
Calcula quantes hores senceres i minuts restants són i imprimeix el resultat. */

class Program
{
    static void Main(string[] args)
    {
        var minuts = 140;

        var hores = minuts / 60;

        var minutsrestants = minuts % 60;

        Console.WriteLine("La mitjana es de" + " " + hores + " " + "i" + " " + minutsrestants + " " + "minuts");


    }
}
