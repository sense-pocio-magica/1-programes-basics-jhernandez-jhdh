namespace exercici2;
/* Declara variables per emmagatzemar l’adreça d’una persona: 
carrer, número, codi postal i població. Imprimeix el resultat 
en una sola línia */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Carrer");
        var carrer = Console.ReadLine();

        Console.WriteLine("Número");
        var num = Console.ReadLine();
        int num1 = Convert.ToInt16(num);

        Console.WriteLine("Codi Postal");
        var codi = Console.ReadLine();
        int codi1 = Convert.ToInt16(codi);

        Console.WriteLine("Població");
        var poblacio = Console.ReadLine();

        Console.WriteLine("El teu carrer es:" + " " + carrer + ", " + "el numero es" + " " + num1 + ", " + "amb el codi postal" + " " + codi1 + ", " + "i la població" + " " + poblacio);
    }
}
