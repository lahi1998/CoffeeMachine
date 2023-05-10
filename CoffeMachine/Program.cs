using CoffeMachine;
// start

// timer for kande fuld

// sluk

Prepare p = new Prepare(0, 0, false);
Reset r = new Reset(0, 0, false);
Produce pd = new Produce(0, 0, false);

p.AddWater();

p.AddFilter();

p.AddCoffee();

Console.WriteLine(p.WATER+ " " + r.WATER + " " +pd.WATER);


pd.TurnOn();

Console.WriteLine(pd.WATER);

