namespace exercici9;

/* Demana un valor en metres. Converteix el valor a peus (1 metre = 3,28084 metres) 
i imprimeix el resultat. */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Dona'm un valor en metres");
        double valor = Convert.ToDouble(Console.ReadLine());

        var peus = valor * 3.28084;

        Console.WriteLine("Tens" + " " + peus + " " + "peus");
    }
}
