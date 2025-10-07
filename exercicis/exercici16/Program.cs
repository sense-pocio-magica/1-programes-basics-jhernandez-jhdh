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
        // var practiques = Console.ReadLine();
        //  int practiques2 = Convert.ToInt32(practiques);
        // float practiques3 = (float)practiques2;
        float practiques = float.Parse(Console.ReadLine()!);

        Console.WriteLine("Quina es la teva nota d'examen?");
        // var examen = Console.ReadLine();
        // int examen2 = Convert.ToInt32(examen);
        //  float examen3 = (float)examen2;
        float examen = float.Parse(Console.ReadLine()!);

        //int mitjana1 = practiques2 + examen2;
        float mitjana1 = (practiques + examen) / 2;
        int mitjana2 = (int)Math.Round((practiques + examen) / 2);
        //int mitjana2 = mitjana1 / 2;
        //float mitjana3 = practiques3 + examen3;
        //float mitjana4 = mitjana3 / 2;

        // Console.WriteLine($"La nota final és {mitjana4} o sigui un {(int)Math.Round(mitjana4)}");
        Console.WriteLine($"La nota final és {mitjana1:F2} o sigui un {mitjana2}");

    }
}
