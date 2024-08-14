using ConsoleAppEstructuras1;

namespace ConsoleAppEstructuras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el valor en grados");
            if (double.TryParse(Console.ReadLine(), out double numIngresado))
            {
                conversionRadian c = new conversionRadian(numIngresado);
                Console.WriteLine($"{c.Grados} grados es igual a {c.GetRadianes ()} radianes ");
            }
              
            
          
        }
    }
}
