using System.Reflection.Metadata.Ecma335;

namespace ClassPerimetro
{
    public struct Perimetro
    {
        //Prop
        public int Radio { get; set; }

        //ctor
        public Perimetro(int radio)
        {
            Radio = radio;
        }

        public double getPerimetro() => 2 * Math.PI * Radio;
        public double getSuperficie () => Math.PI * Math.Pow(2, Radio);
        public float getDiametro ()=> 2* Radio;
        public double getLongitudArco ()=> Math.PI* getDiametro();
        
    }
}
