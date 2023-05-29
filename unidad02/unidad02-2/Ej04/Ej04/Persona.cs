public class Persona {
    public String Nombre { set; get; }
    public String Apellido { set; get; }
    public int Edad { set; get; }
    public int DNI { set; get; }
    public Persona( String nombre, String apellido, int edad, int dni ) { 
        this.Nombre = nombre;
        this.Apellido = apellido;
        this.Edad = edad;
        this.DNI = dni;
        System.Console.WriteLine("Objeto creado exitosamente");
    }
    ~Persona() {
        System.Console.WriteLine("Objeto destruido exitosamente");
    }

    public String GetFullName() { 
        return Nombre + " " + Apellido;
    }

    public int GetEdad() {  return Edad; }
}