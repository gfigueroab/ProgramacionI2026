
Console.Write("Por favor, ingresa un número entero positivo: ");
string entrada = Console.ReadLine();


if (int.TryParse(entrada, out int numero) && numero > 0)
{
    
    if (numero == 1)
    {
        Console.WriteLine("El número 1 no es primo.");
    }
    else
    {
       
        bool esPrimo = true;

        
        for (int i = 2; i < numero; i++)
        {
            
            if (numero % i == 0)
            {
                esPrimo = false; 
                break; 
            }
        }

        
        if (esPrimo)
        {
            Console.WriteLine($"¡El número {numero} es primo!");
        }
        else
        {
            Console.WriteLine($"El número {numero} no es primo.");
        }
    }
}
else
{
    Console.WriteLine("Error: Debes ingresar un número entero mayor a cero.");
}

Console.WriteLine("Presiona cualquier tecla para salir...");
Console.ReadKey();