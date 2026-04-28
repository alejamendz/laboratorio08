Console.WriteLine("Ingrese numero de sucursales: ");
int sucursales = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese numero de productos: ");
int productos = int.Parse(Console.ReadLine());

int[,] stock = new int[sucursales, productos];

for (int i = 0; i < sucursales; i++)
{
    for (int j = 0; j < productos; j++)
    {
        Console.WriteLine($"Sucursal {f}, Producto {c}: ");
        stock[i, j] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine("Seleccione sucursal para ver inventario: ");
int opcion = int.Parse(Console.ReadLine());

Console.WriteLine($"Inventario sucursal {opcion}:");
for (int j = 0; j < productos; j++)
{
    Console.WriteLine($"Producto {j}: {stock[opcion, j]} unidades");
}