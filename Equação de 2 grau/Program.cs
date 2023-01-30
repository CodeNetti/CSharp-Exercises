// See https://aka.ms/new-console-template for more information
double a, b, c, delta, x1, x2;
Console.WriteLine("Vamos resolver equações ");
Console.WriteLine($"Digite o valor de a");
double.TryParse(Console.ReadLine(), out a); 
Console.WriteLine("Digite o valor de b");
double.TryParse(Console.ReadLine(), out b);
Console.WriteLine("Digite o valor de c");
double.TryParse(Console.ReadLine(), out c);

delta = Math.Pow(b, 2) - 4 * a * c;


x1 = (-b + Math.Sqrt(delta)) / 2 * a;

x2 = (-b - Math.Sqrt(delta)) / 2 * a;

 if ( delta > 0)
{
    Console.WriteLine($"X1 é igual a:{Math.Round(x1,1)} e X2 é igual a: {Math.Round(x2,1)}");
}
 else if(delta == 0){ 
    Console.WriteLine($" A raiz é  igualitaria {Math.Round(x1,1)} e {Math.Round(x2,1)}"); 

    
}
else
{
    Console.WriteLine($"Temos o delta negativo portando, não existe");
}