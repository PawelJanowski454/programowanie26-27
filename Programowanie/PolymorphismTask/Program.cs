using PolymorphismTask;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

DrukDokumentu drukDokumentu= new DrukDokumentu("D-101", 15);
DrukPlakatu drukPlakatu = new DrukPlakatu("P-102", 15);
ShowInfo(drukDokumentu);
ShowInfo(drukPlakatu);


void ShowInfo(ZlecenieDruku zlecenie)
{
    Console.WriteLine($"Nr zlecenia: {zlecenie.Number}");
    Console.WriteLine($"Koszt w zł: {zlecenie.ObliczKoszt()}");
    Console.WriteLine($"Czas w min: {zlecenie.ObliczCzasRealizacji()}");
}