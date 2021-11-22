{
    Console.Write("Informe um número: ");
    double número = double.Parse(Console.ReadLine());
    
    if(número != 0)
    {
        Console.Write("Informe um número novamente: ");
        double númeroplus = double.Parse(Console.ReadLine());
        double result = número + númeroplus;
        Console.WriteLine("O resultado é " + result);

        while(númeroplus != 0)
        {
            Console.Write("Informe um número novamente: ");
            númeroplus = double.Parse(Console.ReadLine());
            result = result + númeroplus;
            
            if(númeroplus != 0)
            {
            Console.WriteLine("O resultado é " + result);
            }
        }
    }
}