public class Program
{
    private static void Main(string[] args)
    {
        /*
            Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba jest parzysta czy nieparzysta.
            Dane testowe : 15
            Rezultat w terminalu: 15 jest liczbą nieparzystą
        */

        int a = 15;

        if (a % 2 == 0)
        {
            Console.WriteLine($"{a} jest parzysta");
        }
        else
        {
            Console.WriteLine($"{a} jest nieparzysta");
        }
    }

}
