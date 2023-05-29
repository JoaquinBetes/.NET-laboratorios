int año;
Console.WriteLine("Ingrese un año: ");
while (!int.TryParse(Console.ReadLine(), out año))
{
    Console.Write("No ingreso un número. Ingrese un año: ");
}
if (
    ((año % 4 == 0) && (año % 100 != 0)) || ((año % 100 == 0) && (año % 400 == 0))
    ) Console.WriteLine("El año es bisiesto");
else Console.WriteLine("El año no es bisiesto");