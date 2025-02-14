class Program
{
    static void Main(string[] args)
    {
        //Variables
        byte i, numAlumnos;
        double sumaCalif = 0, promedio, califMin = 10, califMax = 0;

        //Pedimos el número de alumnos
        Console.Write("Ingrese el número de alumnos: ");
        numAlumnos = Convert.ToByte(Console.ReadLine());

        //Creación de la matriz
        double[] calificaciones = new double[numAlumnos];

        //For para pedir calificaciones
        for (i = 0; i < numAlumnos; i++)
        {
            //Pedimos la califiación
            Console.Write("Ingresa la califiación: ");
            calificaciones[i] = Convert.ToDouble(Console.ReadLine());

            //Acumulamos las califiaciones
            sumaCalif += calificaciones[i];
        }

        //Calculamos el promedio
        promedio = sumaCalif / numAlumnos;

        //Calculamos la calificación mínima
        for (i = 0; i < numAlumnos; i++)
        {
            if (calificaciones[i] < califMin)
            {
                califMin = calificaciones[i];
            }
        }

        //Calculamos la califiación máxima
        for (i = 0; i < numAlumnos; i++)
        {
            if (calificaciones[i] > califMax)
            {
                califMax = calificaciones[i];
            }
        }

        //Mostramos los resultados
        Console.WriteLine("El promedio es: {0}", promedio);
        Console.WriteLine("La califiación mínima es: {0}", califMin);
        Console.WriteLine("La califiación máxima es: {0}", califMax);
    }
}