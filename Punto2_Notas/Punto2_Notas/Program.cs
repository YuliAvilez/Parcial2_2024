class Program
    {
        static void Main()
        {
        int totalGanaron = 0, totalPerdieron = 0;
        string continuar;

        do
        {
            Console.WriteLine("Ingrese la cantidad de estudiantes:");
            int cantidadEstudiantes = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidadEstudiantes; i++)
            {
                Console.WriteLine($"Ingrese la cantidad de notas para el estudiante {i + 1}:");
                int cantidadNotas = int.Parse(Console.ReadLine());
                double sumaNotas = 0;

                for (int j = 0; j < cantidadNotas; j++)
                {
                    Console.WriteLine($"Ingrese la nota {j + 1}:");
                    double nota = double.Parse(Console.ReadLine());
                    sumaNotas += nota;
                }

                double promedio = sumaNotas / cantidadNotas;

                // Clasificación simple usando if-else y sin funciones adicionales
                string categoria = "";
                if (promedio >= 4.5)
                {
                    categoria = "Excelente";
                }
                else if (promedio >= 4.0)
                {
                    categoria = "Sobresaliente";
                }
                else if (promedio >= 3.5)
                {
                    categoria = "Bueno";
                }
                else
                {
                    categoria = "Insuficiente";
                }

                Console.WriteLine($"El promedio del estudiante {i + 1} es: {promedio:F2}");
                Console.WriteLine($"Categoría: {categoria}");

                // Contar cuántos ganan y pierden
                if (promedio >= 3.5)
                {
                    totalGanaron++;
                }
                else
                {
                    totalPerdieron++;
                }
            }

            // Preguntar si se desea ingresar otro grupo de estudiantes
            Console.WriteLine("¿Desea ingresar otro grupo de estudiantes? (s/n)");
            continuar = Console.ReadLine().ToLower();

        } while (continuar == "s");

        // Mostrar resultados finales
        Console.WriteLine($"\nTotal de estudiantes que ganaron: {totalGanaron}");
        Console.WriteLine($"Total de estudiantes que perdieron: {totalPerdieron}");
    
        }
}
        
    
    


