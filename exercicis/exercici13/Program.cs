﻿namespace exercici13;

/* Un alumne ha inventat un sistema per codificar dates que consisteix a eliminar els separadors de les dates 
per fer no es vegi que són dates (la data 24/09/2024 la converteix en 24092024). 
El problema és que ho ha aplicat a tots els documents de l’institut i ara la direcció no sap 
ordenar els documents.

Necessitem un programa que faci el procés invers

Entra la data sense formatar: 25092024
La data és 25/09/2024

Entra la data sense formatar: 12031970
La data és 12/03/1970 */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quina es la data sense formatar?");
        string data = Console.ReadLine();

        string dia = data.Substring(0, 2);
        string mes = data.Substring(2, 2);
        string any = data.Substring(4, 4);

        string dataformada = dia + "/" + mes + "/" + any;

        Console.WriteLine("La data formatada és:" + " " + dataformada);
    }
}
