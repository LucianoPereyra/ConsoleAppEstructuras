

using ClassRectangulo;

namespace ConsoleAppEstructuras4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el lado mayor del rectangulo: ");

            if (double.TryParse(Console.ReadLine(), out double ladoMayor))
            {
                Console.Write("Ingrese el lado menor del rectangulo: ");

                if (double.TryParse(Console.ReadLine(), out double ladoMenor))
                {
                    Rectangulo c = new Rectangulo(ladoMayor, ladoMenor);
                    Console.WriteLine($"El perimetro es {c.getPerimetro()}");
                    Console.WriteLine($"La superficie es {c.getSuperficie()}");
                }
            }

               
        } 
    }
}
