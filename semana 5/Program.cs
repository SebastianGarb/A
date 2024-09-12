// See https://aka.ms/new-console-template for more information

using System.ComponentModel;
Console.WriteLine("ALO");
string re = "s";
int suma = 0, cant = 0;
while (re == "s")
{
    Console.WriteLine("Desea participar? (s/n)");
    re = Console.ReadLine().ToLower().Trim();
    if ( re == "s")
    {
        Console.WriteLine("Ingrese edad");
        int edad = Convert.ToInt32(Console.ReadLine());
        suma = suma + edad;
        cant = cant + 1;
    }
}    
double prom = suma / cant;
Console.WriteLine($"El promedio de {cant} edades es {prom}");



