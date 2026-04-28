Console.WriteLine("Ingrese apartamentos: ");
int apartamentos= int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese días: ");
int dias = int.Parse(Console.ReadLine());

double[,] consumo= new double[apartamentos,dias];
double suma = 0;

for(int i=0; i<apartamentos;i++)
{
    for(int j=0; j <dias; j++)
    {
        Console.Write($"Apartamento: {i + 1}, Consumo: {j + 1}: ");
        consumo[i, j] = double.Parse(Console.ReadLine());
        suma +=consumo[i,j];
    }
}
Console.WriteLine(suma);

