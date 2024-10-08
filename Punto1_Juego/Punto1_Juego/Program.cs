class Program
{
    static void Main()
    {
        // Asignación de variables
        int numeroJugadores = 0;
        Random random = new Random();
        int numeroAleatorio = 0;
        bool juegoActivo = true;

        Console.WriteLine("Bienvenido al juego de 'Adivina el número'!");

        while (numeroJugadores < 2 || numeroJugadores > 4)
        {
            Console.Write("Ingrese el número de jugadores (entre 2 y 4): ");
            numeroJugadores = int.Parse(Console.ReadLine());
        }

        switch (numeroJugadores)
        {
            case 2:
                numeroAleatorio = random.Next(0, 51);
                break;
            case 3:
                numeroAleatorio = random.Next(0, 101);
                break;
            case 4:
                numeroAleatorio = random.Next(0, 201);
                break;
        }

        while (juegoActivo)
        {
            for (int i = 1; i <= numeroJugadores; i++)
            {
                Console.Write($"Jugador {i}, ingrese su adivinanza: ");
                int intento = int.Parse(Console.ReadLine());

                if (intento < numeroAleatorio)
                {
                    Console.WriteLine("MAYOR");
                }
                else if (intento > numeroAleatorio)
                {
                    Console.WriteLine("MENOR");
                }
                else
                {
                    Console.WriteLine("¡HAS GANADO!");
                    juegoActivo = false;
                    break;
                }
            }

            if (juegoActivo)
            {
                Console.Write("¿Quieren jugar otra ronda? (s/n): ");
                if (Console.ReadLine().ToLower() != "s")
                {
                    juegoActivo = false;
                }
            }
        }

        Console.WriteLine("Gracias por jugar. ¡Hasta la próxima!");
    }
}
