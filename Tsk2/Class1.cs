public class Hy
{
 
    public void Table(Fun F, double x, double b)
    {
        Console.WriteLine("----- X ----- Y -----");
        while (x <= b)
        {
            Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x,b));
            x += 1;
        }
        Console.WriteLine("---------------------");
    }
    public double FuncPar (double a, double x)
        {
        return a * x*x;
        }
    public static double MySin(double a, double x)
    {
        return a * Math.Sin(x);
    }

}