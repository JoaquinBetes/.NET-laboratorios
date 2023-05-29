using System;


namespace ejercicio6
{
    internal class Juego
    {
        private int _record = 9999;

        public Juego(){}

        public void ComenzarJuego() {
            bool continuar = true;
            while (continuar)
            {
                JugadaConAyuda jugada = new JugadaConAyuda(this.PreguntarMaximo());
                bool flag = jugada.Comparar(this.PreguntarNumero());
                while (!flag)
                {
                    Console.WriteLine("número Incorrecto! Vuelva a ingresar: ");
                    flag = jugada.Comparar(this.PreguntarNumero());
                }
                Console.WriteLine("Ha adivinado el número!");
                if (this.CompararRecord(jugada.Intentos))
                {
                    Console.WriteLine("Ha conseguido un nuevo record!");
                    _record = jugada.Intentos;
                }
                continuar = this.Continuar();
            }
        }

        public bool CompararRecord(int intentos){
            return (_record > intentos);
        }

        public bool Continuar(){
            Console.WriteLine("Ingrese 1 para seguir jugando o 0 para salir");
            int resp = Convert.ToInt32(Console.ReadLine());
            return resp == 1;
        }

        public int PreguntarMaximo(){
            Console.WriteLine("Ingrese número maxímo:");
            return Convert.ToInt32(Console.ReadLine());
        }

        public int PreguntarNumero(){
            Console.WriteLine("Trate de adivinar el número, Ingrese un número: ");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
