int width = 7;
int height = 5;

int area = width * height;
int perimeter = 2 * width + 2 * height;



width += 3; // Incrementa el ancho en 3
height -= 2; // Decrementa la altura en 2

area = width * height;
perimeter = 2 * width + 2 * height;


Console.WriteLine("=== CALCULOS DE RECTANGULO ===");
Console.WriteLine($"Ancho: {width}");
Console.WriteLine($"Altura: {height}");
Console.WriteLine($"Area del rectangulo: {area}");
Console.WriteLine($"Perimetro del rectangulo: {perimeter}");
