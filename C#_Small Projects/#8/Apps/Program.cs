int item = int.Parse(Console.ReadLine());

int number_of_microscopes = 0;
int number_of_scalpels = 0;
int number_of_syringes = 0;

var names = new List<string>();
names.Add("microscope");
names.Add("scalpel");
names.Add("syringe");

for (int i = 0; i < item; i++)
{
    string vid = Console.ReadLine();

    if (vid == "microscope")
    {
        number_of_microscopes++;
    }
    else if (vid == "scalpel")
    {
        number_of_scalpels++;
    }
    else if (vid == "syringe")
    {
        number_of_syringes++;
    }
}

int price_microscopes = 6000;
int price_scalpels = 1500;
int price_syringes = 100;

int total_cost = (number_of_microscopes * price_microscopes) + (number_of_scalpels * price_scalpels) + (number_of_syringes * price_syringes);

Console.WriteLine($"The total price is: {total_cost}$");