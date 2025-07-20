var Общият_бюджет = double.Parse(Console.ReadLine());
var Цената_на_книгите = double.Parse(Console.ReadLine());

var дрехи = Цената_на_книгите * 0.2;
var козметика = Цената_на_книгите * 0.05;
var разходи = Цената_на_книгите * 0.12;
var харчи = Цената_на_книгите + дрехи + козметика + разходи;
var Остават = Math.Round(Общият_бюджет - харчи, 2);

if (Остават >= 0)
{
    Console.WriteLine($"Yes! {Остават} leva left.");
}
else
{
    Console.WriteLine($"No! {Math.Abs(Остават)} leva needed.");
}