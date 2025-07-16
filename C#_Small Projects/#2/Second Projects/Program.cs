var bitcoin = int.Parse(Console.ReadLine());
var ioan = double.Parse(Console.ReadLine());
var comission = double.Parse(Console.ReadLine());

b * 1168 i * 0.15 * 1.76 b + i / 1.95
 x - x * 0.05

var levab = bitcoin * 1168;
var levai = ioan * 0.15 * 1.76;
var euro = (levab + levai) / 1.95;
var result = euro - euro * comission / 100;

Console.WriteLine("Result:" + result + "Euro");

int btc = int.Parse(Console.ReadLine());
double yoan = double.Parse(Console.ReadLine());
double comission = double.Parse(Console.ReadLine());

Console.WriteLine($"Result: {(100 - comission) / 100 * ((btc * 1168 + yoan * 0.15 * 1.76) / 1.95)} euro");