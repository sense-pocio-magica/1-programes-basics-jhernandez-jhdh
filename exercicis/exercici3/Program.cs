namespace exercici3;

/* Defineix quatre variables per al nom d’un producte, el seu preu 
i si està en estoc o no. Imprimeix la informació de forma clara. */
class Program
{
    static void Main(string[] args)
    {
        string Nom_producte = "Ordenador";
        int preu = 10;
        bool estoc = false;


        Console.WriteLine("El meu producte anomenat" + " " + (Nom_producte) + " " + "té un preu de" + " " + (preu));

        if (estoc == true)
        {

            Console.WriteLine("Si, hi ha estoc");

        }

        else {

            Console.WriteLine("No, no hi ha estoc");


        }

    }

}