namespace exercici12;

/* Fes un programa que a partir de dos números imprimeixi per pantalla la seva suma, la seva resta, 
la seva multiplicació i la seva divisió

Entra el primer número: 3
Entra el segon número: 4

4 + 3 = 7
4 - 3 = 1
4 * 5 = 12
4 / 3 = 1  i en sobra 1


Entra el primer número: 25
Entra el segon número: 5

25 + 5 = 30
25 - 5 = 20
25 * 5 = 125
25 / 5 = 5  i en sobra 0
*/



class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Dona'm el primer número");
        int num1 = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Dona'm el segon número");
        int num2 = Convert.ToInt16(Console.ReadLine());

     var suma = num1 + num2;

        var resta = num1 - num2;

        var multiplicacio = num1 * num2;

        var divisio = num1 / num2;

        var residu = num1 % num2;

        Console.WriteLine("La suma és: " + suma);
        Console.WriteLine("La resta és: " + resta);
        Console.WriteLine("La multiplicació és: " + multiplicacio);
        Console.WriteLine("La divisió és:" + " " + divisio + " " + "i" + " " + residu + " " + "el residu");


    }
}
