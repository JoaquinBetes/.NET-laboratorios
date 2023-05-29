using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejercicio6
{
    public class Jugada
    {
        private bool _adivino;
        private int _intentos;
        private int _numero;
        public bool Adivino { get; set; }
        public int Intentos { get; set; }
        public int Numero { get; set; }

        public Jugada(int maxNumero)
        {
            this.Adivino = false;
            this.Intentos = 0;
            Random rnd = new Random();
            Numero = rnd.Next(maxNumero);
        }

        public virtual bool Comparar(int num )
        {
            if (num == this.Numero)
            {
                this.Adivino = true;
            }
            else { 
                this.Adivino = false;
                this.Intentos++;
            }
            return this.Adivino;
        }
    }
}