internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("\n************ Pole pomieszczenia ************");
        Console.WriteLine("Podaj pierwszą ścianę w metrach:");
        var v1Temp = Console.ReadLine();
        double v1 = 0.0;
        if (!double.TryParse(v1Temp, out v1))
        {
            Console.WriteLine("Nieprawidłowe dane. Podaj liczbę.");
            Main(args);
            return;
        }

        Console.WriteLine("Podaj drugą ścianę w metrach:");
        var v2Temp = Console.ReadLine();
        double v2 = 0.0;
        if (!double.TryParse(v2Temp, out v2))
        {
            Console.WriteLine("Nieprawidłowe dane. Podaj liczbę.");
            Main(args);
            return;
        }

        double result = v1 * v2;
        Console.WriteLine("Twój pokój ma: " + Math.Round(result, 2) + " m²");
        Console.WriteLine("\nKliknij enter aby zakończyć");
        Console.ReadLine();
    }
}
