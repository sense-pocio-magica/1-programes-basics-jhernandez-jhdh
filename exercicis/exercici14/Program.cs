namespace exercici14;

// Declara una paraula i fes que el programa imprimeixi només la primera lletra, l'última lletra i la lletra del mig 
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quina es la paraula que vols declarar?");
        var paraula = Console.ReadLine();

        char primeralletra = paraula[0];
        Console.WriteLine(primeralletra);

        //char ultimalletra = ;

        Console.WriteLine(paraula[paraula.Length - 1]);
        Console.WriteLine(paraula[paraula.Length / 2]);



    }
}

/* nom.Lenght
    nom.ToUpper()
    nom.ToLower()
    nom[nom.Lenght-1]
    nom[nom.Lenght/2]
    */
    /* string nom = papallona;
        char inicial = nom[0].ToUpper();
        string paraula = nom.Substring(1);
        Console.WriteLine(inicial + paraula)
        */