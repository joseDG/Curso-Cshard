class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingresa los grados: ");
        double grados = Convert.ToDouble(Console.ReadLine());

        GradosToRadianes(grados);
    }

    static void GradosToRadianes(double grados)
    {

        double radianes = Math.Round((grados * (Math.PI / 180)), 6);

        Console.WriteLine("Resultado Conversion de Grados a Radianes = {0}", radianes);
    }
}