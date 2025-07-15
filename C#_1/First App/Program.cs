var cena_banichka = double.Parse(Console.ReadLine());
var koli_banichka = int.Parse(Console.ReadLine());
var koli_mekici = int.Parse(Console.ReadLine());
var koli_kifla = int.Parse(Console.ReadLine());
var koli_gevreci = int.Parse(Console.ReadLine());
var budjet = double.Parse(Console.ReadLine());

var cena_mekica = cena_banichka * 1.2;
var cena_kifla = cena_mekica * 0.6;
var cena_gevrek = cena_kifla + 1.20;
var razhod = koli_banichka * cena_banichka + koli_mekici * cena_mekica + koli_kifla * cena_kifla + koli_gevreci * cena_gevrek;
var razlika = Math.Round(budjet - razhod, 2);

if (razlika > 0)
{
    Console.WriteLine($"Yes! {razlika} leva left.");
}
else
{
    Console.WriteLine($"No! {Math.Abs(razlika)} leva needed.");
}