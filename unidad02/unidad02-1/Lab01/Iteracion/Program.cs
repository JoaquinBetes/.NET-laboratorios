string[] iteraciones = new string[5];
int cantIteraciones = 5 ;

for (int i = 0; i < cantIteraciones; i++) {
    iteraciones[i] = Console.ReadLine();
}
for (int i = (cantIteraciones-1); i >= 0; i--) {
    Console.WriteLine(iteraciones[i]);
}