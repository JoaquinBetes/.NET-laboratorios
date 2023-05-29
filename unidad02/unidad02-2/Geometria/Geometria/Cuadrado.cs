using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometria
{
    public class Cuadrado : Rectangulo
    {
        public float Lado { set; get; }

        public override float CalcularPerimetro()
        {
            return (float)(4 * Lado);
        }

        public override float CalcularSuperficie()
        {
            return (float)(Lado*Lado);
        }
    }
}