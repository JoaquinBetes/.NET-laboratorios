using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometria
{
    public class Triangulo : Poligono
    {
        public float LadoA { get; set; }
        public float LadoB { get; set; }
        public float Base { get; set; }
        public float Altura { get; set; }
        public override float calcularPerimetro()
        {
            return Base + LadoA + LadoB;
        }

        public override float calcularSuperficie()
        {
            return Base*Altura;
        }
    }
}