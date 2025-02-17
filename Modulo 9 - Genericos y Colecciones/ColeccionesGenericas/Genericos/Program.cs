class Program
{
    static void Main(string[] args)
    {

        //Variables
        string elem;
        int opcion;

        //List
        List<string> Personas = new List<string>();

        //Agregamos objetos en la List
        Personas.Add("Jose");
        Personas.Add("Miguel");
        Personas.Add("Angel");
        Personas.Add("Rocio");

        //do
        //{
        //    Console.WriteLine("1. Agregar Elementos");
        //    Console.WriteLine("2. Salir");
        //    opcion = Convert.ToInt32(Console.ReadLine());

        //    if(opcion == 1)
        //    {
        //        Console.Write("Ingrese el elemento a agregar en la lista: ");
        //        elem = Console.ReadLine();

        //        Personas.Add(elem);
        //    }

        //} while (opcion == 1);

        //Insertar
        Personas.Insert(2, "Majo");

        //recorrer 
        Console.WriteLine("Informacion en la List: \n");
        foreach (string elemento in Personas)
        {
            Console.WriteLine(elemento);
        }

        //quitando elemento
        Personas.RemoveAt(4);

        Console.WriteLine("Informacion en la List: \n");
        foreach (string elemento in Personas)
        {
            Console.WriteLine(elemento);
        }

        //buscar un objeto


    }
}

