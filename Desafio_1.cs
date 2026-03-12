
     static void Main(string[] args)
        {
            Console.Write("Por favor, ingresa un número entero positivo: ");
            string entrada = Console.ReadLine();

            
            if (int.TryParse(entrada, out int numeroLimite) && numeroLimite > 0)
            {
                Console.WriteLine($"Números pares desde 1 hasta {numeroLimite}:");

                
                for (int i = 1; i <= numeroLimite; i++)
                {
                    
                    if (i % 2 != 0)
                    {
                        continue;
                    }

                    
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Error: Debes ingresar un número entero mayor a cero.");
            }

            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }
