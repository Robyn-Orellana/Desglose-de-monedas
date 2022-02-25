static void desglose()
{
    float can, can10, can20, can50, can100, can5;
    can = can10 = can20 = can50 = can100 = can5 = 0.00f;
    string linea;
    Console.WriteLine("Ingrese cantidad");
    can = float.Parse(Console.ReadLine());

    if ((can>=100))
    {
        can100 = (int) (can / 100);
       can = can - (can100 * 100);

    }
    if ((can >= 50))
    {
        can50 = (int)(can / 50);
        can = can - (can50 * 50);

    }
    if ((can>=20))
    {
        can20= (int)(can/ 20); 
        can=can - (can20 * 20);

    }
    if ((can>=10))
    {
        can10 = (int)(can / 10);
        can = can - (can10 * 10);
    }
    if ((can>=5))
    {
        can5 = (int)(can / 5);
        can = can - (can5 * 5);
    }
    if ((can >=1))
    {
        can = (int)(can / 1);
        
    }

    Console.WriteLine($"Billetes de 100={can100}");
    Console.WriteLine($"Billetes de 50={can50}");
    Console.WriteLine($"Billetes de 20={can20}");
    Console.WriteLine($"Billetes de 10={can10}");
    Console.WriteLine($"Billetes de 5={can5}");
    Console.WriteLine($"Billetes de 1={can}");

}

desglose();