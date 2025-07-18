var широчината_на_кораба = double.Parse(Console.ReadLine());
var дължината_на_кораба = double.Parse(Console.ReadLine());
var височината_на_кораба = double.Parse(Console.ReadLine());
var средната_височина_на_астронавтите = double.Parse(Console.ReadLine());

var Обемът_на_ракетата = широчината_на_кораба * дължината_на_кораба * височината_на_кораба;
var Обемът_на_една_стая = (средната_височина_на_астронавтите + 0.40) * 2 * 2;
var hora = Math.Floor(Обемът_на_ракетата / Обемът_на_една_стая);

if (hora >= 3 && hora <= 10)
{
    Console.WriteLine($"The spacecraft holds {hora} astronauts.");
}
else if (hora <= 2)
{
    Console.WriteLine("The spacecraft is too small.");
}
else
{
    Console.WriteLine("The spacecraft is too big.");
}