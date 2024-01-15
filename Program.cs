internal class Program
{
    private static void Main(string[] args)
    {
        double a = 3.5, b= 6, c;
        c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        Console.Write("In rectangular triangle with a = 3.5 and b = 6, the length of the hypotenuse c is: " + c);
        Console.ReadKey();
    }
}