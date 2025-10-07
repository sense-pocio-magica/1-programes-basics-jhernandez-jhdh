namespace exercici15;

    // Assigna un nom i un cognom en variables. Imprimeix el nom complet, 
    // assegurant-te que la primera lletra de cada paraula estigui en majúscula
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quin es el teu nom?");
        string nom = Console.ReadLine();

        Console.WriteLine("Quin es el teu cognom?");
        string cognom = Console.ReadLine();

        char primeralletranom = char.ToUpper(nom[0]);
        char primeralletracognom = char.ToUpper(cognom[0]);

        string inicialnom = primeralletranom.ToString();
        string inicialcognom = primeralletracognom.ToString();

        string nomsensemajuscula = nom.Substring(1);
        string cognomsensemajuscula = cognom.Substring(1);

        Console.WriteLine(primeralletranom + nomsensemajuscula + " " +  primeralletracognom + cognomsensemajuscula);

       


    }
}
