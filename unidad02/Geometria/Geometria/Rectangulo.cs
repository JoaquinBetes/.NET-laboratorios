using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometria
{
    public class Rectangulo : Poligono
    {
        public int Base { get; set; }
        public int Altura { get; set; }
        public virtual float CalcularPerimetro()
        {
            return (float)(2*Altura + 2*Base);
        }

        public virtual float CalcularSuperficie()
        {
            return (float)(Base*Altura);
        }
    }
}