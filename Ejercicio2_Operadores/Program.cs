
int numero1 = 20;
int numero2 = 6;

Console.WriteLine("=== OPERADORES ARITMETICOS ===");
Console.WriteLine($"Suma: {numero1 + numero2}");
Console.WriteLine($"Resta: {numero1 - numero2}");
Console.WriteLine($"Multiplicacion: {numero1 * numero2}");
Console.WriteLine($"Division entera: {numero1 / numero2}");
Console.WriteLine($"Modulo: {numero1 % numero2}");

Console.WriteLine("\n=== OPERADORES DE ASIGNACION ===");

int resultado = 10;

Console.WriteLine($"Valor inicial: {resultado}");

resultado += 5;
Console.WriteLine($"Despues de += 5: {resultado}");

resultado -= 3;
Console.WriteLine($"Despues de -= 3: {resultado}");

resultado *= 2;
Console.WriteLine($"Despues de *= 2: {resultado}");

resultado /= 4;
Console.WriteLine($"Despues de /= 4: {resultado}");
