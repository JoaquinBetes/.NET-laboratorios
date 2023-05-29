using System;
namespace Clases
{
    public class A
    {
        //Propiedades
        public string NombreInstancia{ get; set; }

        //Constructores
        public A() {
            NombreInstancia = "Instancia sin nombre";
        }
        public A(string nombreInstancia){
            NombreInstancia = nombreInstancia;
        }
        //Métodos
        public void MostrarNombre() { 
            Console.WriteLine("El nombre es: " + NombreInstancia);
        }
        public static void M1(){
            Console.WriteLine("Método M1 invocado");
        }
        public static void M2(){
            Console.WriteLine("Método M2 invocado");
        }
        public static void M3(){
            Console.WriteLine("Método M3 invocado");
        }
    }
}