using System.Threading.Channels;

class Program
{
    static void Main(string[] args)
    {
        //Variables 
        int opcion, indice;
        string alumno;

        //Instancia List
        List<string> Alumnos = new List<string>();

        do
        {
            Console.Clear();

            Console.WriteLine("1. Agregar Estudiantes");
            Console.WriteLine("2. Eliminar Estudiantes");
            Console.WriteLine("3. Mostrar Estudiantes");
            Console.WriteLine("4. Buscar por nombre");

            //Escoger opcion
            Console.WriteLine("Escoje una opcion: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            Console.Clear ();

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingresa el nombre del alumno: ");
                    alumno = Console.ReadLine();

                    Alumnos.Add(alumno);
                    break;

                case 2:
                    Console.Write("ingrese el Id para eliminar alumno {}", 0);
                    indice = Convert.ToInt32(Console.ReadLine());

                    indice--;

                    if (indice >= Alumnos.Count() || indice < 0)
                    {
                        Console.WriteLine("Alumno no existe");
                    }
                    else
                    {
                        string alumnoElim = Alumnos[indice];
                        Alumnos.RemoveAt(indice);
                        Console.WriteLine("{0} se ha eliminado correctamente", alumnoElim);
                    }
                    Console.Write("\nPrecione cualqueir teclarta para regresar");
                    Console.ReadKey();
                    break;

                case 3:
                    int i = 1;

                    Console.WriteLine("Lista de Alumnos");
                    foreach (string estudiante in Alumnos)
                    {
                        Console.WriteLine("{0}. {1}", i++, estudiante);
                    }
                    Console.WriteLine("\nPresione cualquier tecla para regresar al menu ");
                    Console.ReadKey();
                    break;

                case 4:
                    string encontrarAlum;
                    int j; //número de lista

                    Console.Write("Ingrese el nombre del estudiante a buscar: ");
                    alumno = Console.ReadLine();

                    //Verificar si el elemento(alumno) está o no en la List
                    if (Alumnos.IndexOf(alumno) >= 0)
                    {
                        encontrarAlum = Alumnos[Alumnos.IndexOf(alumno)]; //Alumnos[3]
                        j = Alumnos.IndexOf(alumno) + 1;

                        Console.WriteLine("El estudiante {0} se encuentra en el número de lista {1}", encontrarAlum, j);
                    }
                    else
                    {
                        Console.WriteLine("El estudiante {0} no se encuentra en el sistema", alumno);
                    }
                    Console.Write("\nPresione cualquier tecla para regresar al menú ");
                    Console.ReadKey();
                    break;

            }

        } while (opcion >= 1 && opcion <= 4);

    }
}