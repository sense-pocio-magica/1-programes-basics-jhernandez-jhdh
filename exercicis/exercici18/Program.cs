namespace exercici18;

/* Un rellotger està perdent la memòria i necessita un programa que a partir de l'hora actual li puguem dir
 quina hora serà d’aquí un nombre determinat d’hores.

Hora actual: 9
Hores a incrementar: 3
D'aquí a 3 hores seran les 12


Hora actual: 11
Hores a incrementar: 3
D'aquí a 3 hores seran les 2
*/ 

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quina hora és actualment?");
        int hora_actual = Convert.ToInt16(Console.ReadLine()!);

        Console.WriteLine("Quantes hores vols incrementar?");
        int hora_incrementar = Convert.ToInt16(Console.ReadLine()!);

        int hora_final = (hora_actual + hora_incrementar) % 12;
        if (hora_final == 0) hora_final = 12;


        Console.WriteLine($"D'aqui a {hora_incrementar} hores l'hora actual sera {hora_final}");
        
    }
}
