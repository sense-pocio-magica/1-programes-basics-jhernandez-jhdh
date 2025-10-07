namespace exercici20;

/* Ens cal un programa que quan li entrem un número de tres xifres i ens retorni 
el número amb els dígits invertits. 

Ex. 245 -> 542
Entra el número a invertir: 347
El número invertit és: 743
*/

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Dona'm un número de 3 xifres");
        string num = Console.ReadLine()!;
        int num1 = Convert.ToInt16(num);

        int unitats = num1 % 10;
        int desenes = (num1 / 10)% 10;
        int centenes = num1 / 100;

        Console.WriteLine($"El teu número invertit és {unitats}{desenes}{centenes}");

    }
}
