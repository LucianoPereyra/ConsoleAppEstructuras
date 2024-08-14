namespace ClassRectangulo
{
    public struct Rectangulo
    {
        public double ladoMayor { get; set; }
        public double ladoMenor { get; set; }

        public Rectangulo(double ladomayor, double ladomenor)
        {
            ladoMayor = ladomayor;

            ladoMenor = ladomenor;

        }

        public double getPerimetro ()

        { return 2 * ladoMayor + 2 * ladoMenor; }

        public double getSuperficie ()

        {return ladoMayor * ladoMenor; }
        
    }
}
