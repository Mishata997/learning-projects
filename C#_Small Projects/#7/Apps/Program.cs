var width = double.Parse(Console.ReadLine());
var length = double.Parse(Console.ReadLine());
var камери = int.Parse(Console.ReadLine());
string фирмата = Console.ReadLine();

var размерите = width * length;
var цена = 0;
if (фирмата == "Dogramichka4You")
{
    switch (камери)
    {
        case 3:
            цена = 12;
            break;
        case 4:
            цена = 15;
            break;
        default:
            цена = 20;
            break;
    }
}
else
{
    if (фирмата == "TihoToplo")
    {
        switch (камери)
        {
            case 3:
                цена = 15;
                break;
            case 4:
                цена = 14;
                break;
            default:
                цена = 28;
                break;
        }
    }
    else
    {
        switch (камери)
        {
            case 3:
                цена = 14;
                break;
            case 4:
                цена = 20;
                break;
            default:
                цена = 22;
                break;
        }
    }
}

Console.WriteLine($"Goshкo has to spend {размерите * цена:f2} leva.");