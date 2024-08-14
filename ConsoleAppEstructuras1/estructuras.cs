using System.Reflection.Metadata.Ecma335;

namespace ConsoleAppEstructuras1

{
	public struct conversionRadian
	{
        public double Grados { get; set; }

        public conversionRadian(double grados)
        {
           Grados = grados;
        }

        public double GetRadianes()

        {
            return Grados * 0.0174532925;
        }
            
           
       
    }

}