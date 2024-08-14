using ClassPerimetro;

namespace ConsoleAppEstructuras3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la circunferencia: ");

            if (int.TryParse(Console.ReadLine(), out int numIngresado))
            {
                Perimetro c = new Perimetro(numIngresado);
                Console.WriteLine("Datos de la circunferencia");
                Console.WriteLine($"El perimetro es {c.getPerimetro()}");
                Console.WriteLine($"La superficie es {c.getSuperficie ()}");
                Console.WriteLine($"El diametro es {c.getDiametro()}");
                Console.WriteLine($"La longitud del arco es {c.getLongitudArco()}");





            }

        }
    }
}