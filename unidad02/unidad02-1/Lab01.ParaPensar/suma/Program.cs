/*
 * Construir una aplicación que sume dos números y proporcione el resultado con el formato siguiente:
 * El resultado de la suma de < número uno > y < número dos > es < resultado >.
 */
int firstNumber;
int secondNumber;

Console.WriteLine("Ingrese número: ");
while (!int.TryParse(Console.ReadLine(), out firstNumber))
{
    Console.Write("No ingreso un número. Ingrese un número: ");
}
Console.WriteLine("Ingrese otro número: ");
while (!int.TryParse(Console.ReadLine(), out secondNumber))
{
    Console.Write("No ingreso un número. Ingrese un número: ");
}
Console.WriteLine("El resultado de la suma de " + firstNumber + " y " 
    + secondNumber + " es: " +
    ( firstNumber + secondNumber ));
