namespace exercici16;

/* Ningú entén res del nou sistema d’avaluació. Necessitem un programa que calculi la part que és més senzilla: 
a partir de la mitjana de les notes les pràctiques i la nota de l’examen ens calculi la nota final

Nota de pràctiques: 8
Nota de l’examen: 9
La nota final és 8.7 o sigui un 8

Nota de pràctiques: 10
Nota de l’examen: 5
La nota final és 6.5 o sigui un 7 
*/

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quina es la teva nota de pràctiques?");
       
        float practiques = float.Parse(Console.ReadLine()!);

        Console.WriteLine("Quina es la teva nota d'examen?");
      
        float examen = float.Parse(Console.ReadLine()!);

      
        float mitjana1 = (practiques + examen) / 2;
        int mitjana2 = (int)Math.Round((practiques + examen) / 2);
       

     
        Console.WriteLine($"La nota final és {mitjana1:F2} o sigui un {mitjana2}");

    }
}
