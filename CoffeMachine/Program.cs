using CoffeMachine;
// start

// timer for kande fuld

// sluk

Reset r = new Reset(0, 0, 0, 0, false, false);
Prepare p = new Prepare(0, 0, 0, 0, false, false);
Produce pd = new Produce(0, 0, 0, 0, false);
Display d = new Display();

while (true)
{

    d.Menu();

    var input = Console.ReadKey();

    switch (input.Key)
    {
        case ConsoleKey.D1:
            p.AddWater();
            break;

        case ConsoleKey.D2:
            r.RemoveWater();
            break;

        case ConsoleKey.D3:
            p.AddFilter();
            break;

        case ConsoleKey.D4:
            r.RemoveFilter();
            break;

        case ConsoleKey.D5:
            p.AddCoffee();
            break;

        case ConsoleKey.D6:
            p.AddTea();
            break;

        case ConsoleKey.D7:
            p.AddEspresso();
            break;

        case ConsoleKey.D8:
            pd.TurnOn();
            break;
    }
}







