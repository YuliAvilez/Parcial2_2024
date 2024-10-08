class Program
{
    static void Main()
    {
        // Asignación de variables
        int NumJugadores, RangoMax = 50, NumObjetivo;
        bool JuegoGanado = false;

        Console.Write(" Ingresa el número de jugadores (2-4): ");
        NumJugadores = int.Parse(Console.ReadLine());

        if (NumJugadores == 3)
        {
            RangoMax = 100;
        }
        else if (NumJugadores == 4)
        {
            RangoMax = 200;
        }
            Random random = new Random();
        NumObjetivo = random.Next(0,RangoMax + 1);
    }
}