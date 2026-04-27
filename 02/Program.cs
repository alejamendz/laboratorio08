// See https://aka.ms/new-console-template for more information

Console.WriteLine("Ingrese cuantpos productos: ");
int productos=int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese días: ");
int dias=int.Parse(Console.ReadLine());

double[,] consumo =  new double[productos, dias];

for (int i = 0; i < productos; i++)
{
    for (int j = 0; j < dias; j++)
    {
        Console.Write($"Productos: {i + 1}, Día: {j + 1}: ");
        consumo[i, j] = double.Parse(Console.ReadLine());
    }
}

Console.WriteLine("Buscar: ");
int buscar= int.Parse(Console.ReadLine());
bool encontrado = false;

for(int i=0; i< productos; i++)
{
    for(int j=0; j< dias; j++)
    {
        if (consumo[i, j] == buscar)
        {
            Console.WriteLine("Encontrado en ["+i+"," +j +"]");
            encontrado = true;
        }
       
    }
}

if(!encontrado)
{
    Console.WriteLine("Error");
}