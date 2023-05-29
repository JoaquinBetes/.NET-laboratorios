using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6
{
    public class JugadaConAyuda : Jugada {
        public JugadaConAyuda(int maxNum) : base(maxNum) { }

        public override bool Comparar(int num)
        {
            if (num == this.Numero)
            {
                this.Adivino = true;
            }
            else
            {
                if (Math.Abs(this.Numero - num) > 100)
                {
                    Console.WriteLine("El número ingresado esta muy lejos del correcto");
                }
                else if (Math.Abs(this.Numero - num) < 5) {
                    Console.WriteLine("El número ingresado esta muy cerca del correcto");
                }
                this.Adivino = false;
                this.Intentos++;
            }
            return this.Adivino;
        }
    }
 
}
