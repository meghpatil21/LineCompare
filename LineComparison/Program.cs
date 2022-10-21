namespace LineComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");
            Console.WriteLine();

            Console.WriteLine("Enter X Co-ordinates of first point: ");
            Double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Y Co-ordinates of first point: ");
            Double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter X Co-ordinates of second point: ");
            Double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter X Co-ordinates of second point: ");
            Double y2 = Convert.ToDouble(Console.ReadLine());

            double x = (x2 - x1) * (x2 - x1);
            double y = (y2 - y1) * (y2 - y1);

            double lengthOfLine = Math.Sqrt(x + y);
            Console.WriteLine("Lengh of line is " + lengthOfLine);
        }
    }
}