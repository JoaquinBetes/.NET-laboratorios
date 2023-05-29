namespace Geometria
{
    public class Circulo
    {
        private int m_radio;

        public int Radio { set; get;}

        public float CalcularPerimetro()
        {
            return (float)( 2 * Math.PI * Radio);
        }

        public float CalcularSuperficie()
        {
            return (float)(Math.PI * Math.Pow(Radio, 2));
        }
    }
}