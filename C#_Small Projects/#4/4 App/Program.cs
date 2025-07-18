var n = int.Parse(Console.ReadLine());

var sumLeft = 0;
for (int i = 1; i <= n; i++)
{
    var number = int.Parse(Console.ReadLine());
    sumLeft += number;
}

var sumRight = 0;
for (int i = 1; i <= n; i++)
{
    var number = int.Parse(Console.ReadLine());
    sumRight += number;
}
var sum = sumLeft - sumRight;

if (sumLeft == sumRight)
{ Console.WriteLine("Yes, sum = " + sumLeft); }
else
{
    Console.WriteLine("No, diff = " +
Math.Abs(sumRight - sumLeft));
}