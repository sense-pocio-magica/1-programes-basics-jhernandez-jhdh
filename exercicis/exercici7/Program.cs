namespace exercici7;

/* Defineix tres variables amb tres notes numèriques. 
Calcula la mitjana i mostra el resultat per pantalla. */ 

class Program
{
    static void Main(string[] args)
    {
        
        var num1 = 4.5;
        var num2 = 4.8;
        var num3 = 6.4;

        var numnotes = 3;

        Console.WriteLine("La mitjana de les teves notes numèriques és:" + " " + (num1 + num2 + num3) / numnotes);

    }
}
