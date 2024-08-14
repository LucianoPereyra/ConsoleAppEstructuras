namespace ConsoleAppEstructuras2
{
    public struct Cuadrado
    {
        public int Lado { get; set; }

        public Cuadrado(int lado)
        {
            Lado = lado;
        }

        public int GetPerimetro() => Lado * 4;

        public double GetSuperficie() => Math.Pow(Lado, 2);
        


        
    }
}

