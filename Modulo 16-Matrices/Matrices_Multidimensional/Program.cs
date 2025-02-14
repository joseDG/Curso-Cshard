class Program
{
    static void Main(string[] args)
    {
        //Variables
        byte i, j, numAlumnos, salones;
        double sumaCalif = 0, promedio, califMin = 10, califMax = 0;

        //Pedimos el número de salones
        Console.Write("Ingrese el número de salones: ");
        salones = Convert.ToByte(Console.ReadLine());

        //Pedimos el número de alumnos
        Console.Write("Ingrese el número de alumnos por salón: ");
        numAlumnos = Convert.ToByte(Console.ReadLine());

        //Creación de la matriz
        double[,] calificaciones = new double[salones, numAlumnos];

        //For para pedir calificaciones
        for (i = 0; i < salones; i++)
        {
            Console.WriteLine("Salón {0}", i);
            for (j = 0; j < numAlumnos; j++)
            {
                //Pedimos la califiación
                Console.Write("Ingresa la calificación del alumno {0}: ", j);
                calificaciones[i, j] = Convert.ToDouble(Console.ReadLine());

                //Acumulamos las califiaciones
                sumaCalif += calificaciones[i, j];
            }
        }

        //Calculamos el promedio
        promedio = sumaCalif / (salones * numAlumnos);

        //Calculamos la calificación mínima
        for (i = 0; i < salones; i++)
        {
            for (j = 0; j < numAlumnos; j++)
            {
                if (calificaciones[i, j] < califMin)
                {
                    califMin = calificaciones[i, j];
                }
            }
        }

        //Calculamos la califiación máxima
        for (i = 0; i < salones; i++)
        {
            for (j = 0; j < numAlumnos; j++)
            {

                if (calificaciones[i, j] > califMax)
                {
                    califMax = calificaciones[i, j];
                }
            }
        }

        //Mostramos los resultados
        Console.WriteLine("El promedio es: {0}", promedio);
        Console.WriteLine("La califiación mínima es: {0}", califMin);
        Console.WriteLine("La califiación máxima es: {0}", califMax);
    }
}