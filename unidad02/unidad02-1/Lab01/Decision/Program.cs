String inputTexto;

Console.WriteLine("Ingrese un texto: ");
inputTexto = Console.ReadLine();

if (inputTexto == null || inputTexto.Length == 0)
{
    Console.WriteLine("No se ha ingresado un texto");
}
else {
    Console.WriteLine("Ingrese 1 para mayúsculas, 2 para minúsculas o 3 para ver cantidad caracteres");
    ConsoleKeyInfo opcion = Console.ReadKey();
    if (opcion.Key == ConsoleKey.D1)
    {
        Console.WriteLine();
        Console.WriteLine(inputTexto.ToUpper());
    }
    else if (opcion.Key == ConsoleKey.D2)
    {
        Console.WriteLine();
        Console.WriteLine(inputTexto.ToLower());
    }
    else if (opcion.Key == ConsoleKey.D3)
    {
        Console.WriteLine();
        Console.WriteLine("Cantidad de carácteres: " + inputTexto.Length);
    }
    else Console.WriteLine("No ha seleccionado una opción valida");
}

