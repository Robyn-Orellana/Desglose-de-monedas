static void desglose()
{
    float re, can, can1, can10, can20, can50, can100, can5, cm50, cm25, cm5, cm10;
    re = can = can1 = can10 = can20 = can50 = can100 = can5 = cm50= cm25= cm5= cm10= 0.00f;
   
    Console.WriteLine("Ingrese cantidad");
    can = float.Parse(Console.ReadLine());

    if (can>=100)
    {
        can100 = (int) (can / 100);
        can = can - (can100 * 100);

    }
    if (can >= 50)
    {
        can50 = (int)(can / 50);
        can = can - (can50 * 50);

    }
    if (can>=20)
    {
        can20= (int)(can/ 20); 
        can=can - (can20 * 20);

    }
    if (can>=10)
    {
        can10 = (int)(can / 10);
        can = can - (can10 * 10);
    }
    if (can>=5)
    {
        can5 = (int)(can / 5);
        can = can - (can5 * 5);
    }
    if (can >=1)
    {
        can1 = (int)(can / 1);
        can = can - (can1 * 1);
    }
    if (can>=0.50)
    {
        cm50 = (int)(can / 0.50);
        can = can - (cm50 * 0.50f);
    }
    if (can >= 0.25)
    {
        cm25 = (int)(can / 0.25);
        can = can - (cm25 * 0.25f);
    }
    if (can >= 0.10)
    {
        cm10 = (int)(can / 0.10);
        can = can - (cm10 * 0.10f);
    }
    if (can >= 0.05)
    {
        cm5 = (int)(can / 0.05);
        can = can - (cm5 * 0.05f);
    }
    if (can >= 00.01f)
    {
        can = (can / 00.01f);  
        re=(int)Math.Round(can);   
        
    }

    Console.WriteLine($"Billetes de 100={can100}");
    Console.WriteLine($"Billetes de 50={can50}");
    Console.WriteLine($"Billetes de 20={can20}");
    Console.WriteLine($"Billetes de 10={can10}");
    Console.WriteLine($"Billetes de 5={can5}");
    Console.WriteLine($"Billetes de 1={can1}");
    Console.WriteLine($"Monedas de 0.50={cm50}");
    Console.WriteLine($"Monedas de 0.25={cm25}");
    Console.WriteLine($"Monedas de 0.10={cm10}");
    Console.WriteLine($"Monedas de 0.05={cm5}");
    Console.WriteLine($"Monedas de 0.01={re}");
}

desglose();