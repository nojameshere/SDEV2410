



    int numQuarter = 1,
        numDime = 2,
        numNickel = 3,
        numPenny = 4;
    Coin quarter = Coin.Quarter;
    Coin dime = Coin.Dime;
    Coin nickel = Coin.Nickel;
    Coin penny = Coin.Penny;

    Console.WriteLine($"Pile of change has {numQuarter} {quarter}, {numDime} {dime}, {numNickel} {nickel}, {numPenny} {penny}");
    int total = 0;
    total = numQuarter * (int)quarter;
    total += numDime * (int)dime;
    total += numNickel * (int)nickel;
    total += numPenny * (int)penny;
    decimal result = (decimal)total / 100;

    Console.WriteLine($"{result:c}");



enum Coin { Quarter = 25, Dime = 10, Nickel = 5, Penny = 1}


