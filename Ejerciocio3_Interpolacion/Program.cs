
string producto = "Teclado";
decimal precio = 85000m;
int cantidad = 3;

decimal subtotal = precio * cantidad;
decimal descuento = subtotal * 0.10m;
decimal total = subtotal - descuento;

Console.WriteLine("=== FACTURA DE VENTA ===");
Console.WriteLine($"Producto: {producto}");
Console.WriteLine($"Precio unitario: ${precio:N0}");
Console.WriteLine($"Cantidad: {cantidad}");
Console.WriteLine($"Subtotal: ${subtotal:N0}");
Console.WriteLine($"Descuento del 10%: ${descuento:N0}");
Console.WriteLine($"Total a pagar: ${total:N0}");
