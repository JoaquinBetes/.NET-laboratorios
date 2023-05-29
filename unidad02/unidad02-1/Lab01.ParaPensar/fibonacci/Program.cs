int valor1 = 0;
int valor2 = 1;
int bandera;

do
{
    Console.WriteLine(valor2);
    bandera = valor2;
    valor2 = valor1 + valor2;
    valor1 = bandera;
    Console.WriteLine("Ingrese 0 para terminar. Cualquier otro valor para continuar.");
    while (!int.TryParse(Console.ReadLine(), out bandera))
    {
        Console.Write("No ingreso un número. Ingrese un numero");
    }
}
while (bandera != 0);

