class Program
{
    static void Main(String[] args)
    {
        int opcion;
        decimal r;
        decimal numPa1, numPa2;

        //declarar la tupla
        (decimal num1, decimal num2, decimal resultado) numeros;

        do
        {

            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicacion");
            Console.WriteLine("4. Dividir");

            //Pedimos una opcion
            Console.WriteLine("Escoge una opcion: ");
            opcion = Convert.ToInt32(Console.ReadLine());

        } while ((opcion < 1) || (opcion > 4));

        switch(opcion)
        {
            case 1:
                Sumar();
                break;
            case 2:
                numeros = Restar();
                Console.WriteLine("Resta {0} - {1} = {2}", numeros.num1, numeros.num2, numeros.resultado);
                break;
            case 3:
                
                numPa1 = IngreseNumero("Ingrese el primer numero: ");
                numPa2 = IngreseNumero("Ingrese el segundo numero: ");

                Console.Write("Ingrese el segundo numero: ");
                numPa2 = Convert.ToDecimal(Console.ReadLine());

                Multiplicar(numPa1, numPa2);
                break;

            case 4:
                numPa1 = IngreseNumero("Ingrese el primer numero: ");
                numPa2 = IngreseNumero("Ingrese el segundo numero: ");

                r = Dividir(numPa1, numPa2);
                Console.WriteLine("El resultado de la Dividir es: {0}", r);
                break;
        }
    }

    //[modificar][tipo][identificador][parametro]
    static void Sumar()
    {
        //Variables
        decimal num1, num2, resultado;

        //Pedimos el valor de ambos numeros
        Console.Write("Ingrese el primer numero:");
        num1 = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Ingrese el segundo numero:");
        num2 = Convert.ToDecimal(Console.ReadLine());

        //Operacion
        resultado = num1 + num2;

        //Mostramos el resultado
        Console.WriteLine("{0} + {1} = {2}", num1, num2, resultado);
    }

    static (decimal, decimal, decimal) Restar()
    {
        //variables del metodo 
        decimal num1, num2, resultado;

        //Pedimos el valor de ambos numeros
        Console.Write("Ingrese el primer numero:");
        num1 = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Ingrese el segundo numero:");
        num2 = Convert.ToDecimal(Console.ReadLine());

        //Operacion
        resultado = num1 - num2;

        //Devolver un tupla
        return (num1, num2, resultado);
        
    }

    static void Multiplicar(decimal num1Pa, decimal num2Pa)
    {
        //varaibles
        decimal resultado;

        //operacion
        resultado = num1Pa * num2Pa;

        //mostrar el resutlado
        Console.WriteLine("{0} x {1} = {2}", num1Pa, num2Pa, resultado);
    }

    static decimal Dividir(decimal num1Pa, decimal num2Pa)
    {
        //variables
        decimal resultado;

        if(num2Pa != 0)
        {
            resultado = num1Pa / num2Pa;
        }
        else
        {
            Console.WriteLine("No es posible dividir entre cero");
            resultado = 0;
        }

        return resultado;
    }

    static decimal IngreseNumero(string peticion)
    {
        //variables
        decimal numero;

        //pedimos el valor
        Console.WriteLine(peticion);
        numero = Convert.ToDecimal(Console.ReadLine()); 

        return numero;
    }
}