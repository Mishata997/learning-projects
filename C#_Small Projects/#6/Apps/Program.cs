var приятелите = int.Parse(Console.ReadLine());
var Water = 0;
var Fire = 0;
var Earth = 0;
var Air = 0;

string zodiq;
for (int i = 0; i < приятелите; i++)
{
    zodiq = Console.ReadLine();
    switch (zodiq)
    {
        case "Pisces":
        case "Cancer":
        case "Scorpio":
            Water++; break;
        case "Aries":
        case "Leo":
        case "Sagittarius":
            Fire++; break;
        case "Taurus":
        case "Virgo":
        case "Capricorn":
            Earth++; break;
        case "Gemini":
        case "Libra":
        case "Aquarius":
            Air++; break;
        default: break;
    }
}
double totalFriends = приятелите;
double waterPercentage = (Water / totalFriends) * 100.0;
double firePercentage = (Fire / totalFriends) * 100.0;
double earthPercentage = (Earth / totalFriends) * 100.0;
double airPercentage = (Air / totalFriends) * 100.0;

Console.WriteLine($"Water: {waterPercentage:f2}%");
Console.WriteLine($"Fire: {firePercentage:f2}%");
Console.WriteLine($"Earth: {earthPercentage:f2}%");
Console.WriteLine($"Air: {airPercentage:f2}%");