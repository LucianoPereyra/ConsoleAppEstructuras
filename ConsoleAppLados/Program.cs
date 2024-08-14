using ConsoleAppEstructuras2;

namespace ConsoleAppLados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el lado del cuadrado: ");
            if (int.TryParse(Console.ReadLine(), out int numIngresado))
            {
                Cuadrado c = new Cuadrado(numIngresado);
                Console.WriteLine($"El perimetro de {c.Lado} es {c.GetPerimetro()} " +
                    $"y su superficie es {c.GetSuperficie()}");
                
            }
        }
    }
}
