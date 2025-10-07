namespace exercici11;

// A partir de dues variables (nom d'usuari i domini), crea i imprimeix una adreça de correu electrònic completa.
class Program
{
    static void Main(string[] args)
    {
        string nom = "jhernandezdeharo";
        string domini = "cendrassos.cat";

        string simbol = "@";

        string resultat = String.Concat(nom, simbol, domini);

        Console.WriteLine("La teva adreça de correu és:" + " " + resultat);
    }
}
