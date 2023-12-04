internal class Program
{
    private static void Main(string[] args)
    {
        int multiplicador, multiplicando, a, b, c = 0;

        Console.Write("Ingrese el multiplicador: ");
        multiplicador = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el multiplicando: ");
        multiplicando = int.Parse(Console.ReadLine());

        a = multiplicador;
        b = multiplicando;
        while(a != 0)
        {
            if(a % 2 != 0)
                c = c + b;

            a = a / 2;
            b = b * 2;    
        }
        Console.WriteLine($"Resultado: {c}");
        Console.ReadKey();
    }
}