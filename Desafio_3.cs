
double sumaTotal = 0;
int cantidadNotas = 0;

Console.WriteLine("Calculadora de Promedios");
Console.WriteLine("Ingresa las calificaciones del alumno (deben estar entre 1 y 10).");
Console.WriteLine("Escribe 'fin' cuando hayas terminado para ver el resultado.");


while (true)
{
    Console.Write("Ingresa un puntaje o la palabra 'fin': ");
    string entrada = Console.ReadLine();

   
    if (entrada.ToLower() == "fin")
    {
        break; 
    }

    
    if (double.TryParse(entrada, out double puntaje))
    {
        
        if (puntaje >= 1 && puntaje <= 10)
        {
            sumaTotal += puntaje; 
            cantidadNotas++;      
        }
        else
        {
            
            Console.WriteLine("Error: El puntaje debe estar entre 1 y 10. Inténtalo de nuevo.");
        }
    }
    else
    {
        
        Console.WriteLine("Error: Entrada no válida. Por favor, ingresa un número o 'fin'.");
    }
}


if (cantidadNotas > 0)
{
    double promedio = sumaTotal / cantidadNotas;
    Console.WriteLine($"Total de calificaciones ingresadas: {cantidadNotas}");
    Console.WriteLine($"El puntaje promedio del alumno es: {promedio:F2}");
}
else
{
    Console.WriteLine("No se ingresó ninguna calificación válida, por lo que no hay promedio que calcular.");
}

Console.WriteLine("Presiona cualquier tecla para salir...");
Console.ReadKey();