// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;

Console.WriteLine("Hello, World!");
Console.WriteLine("Resolvendo a equação 3x - x = 6x + 1 - 3");
double a = 3, b = 1, c= 6, d= 1, e = 3, x;
// combiando os termermos semlehantes
Console.WriteLine($"{a = a - b} = {c}x + {d} - {e}");
//Subtração
Console.WriteLine($"{a}x = {c}x {d = d - e }");
//Subtrair 6x dos dois lados
Console.WriteLine($"{a = a - c}x = {c}x  {d} -{c}x ");
Console.WriteLine($"{a}x = {d}");
//Dividir os dois lados pelo mesmo fator
Console.WriteLine($"{a = a / a} = {d} sobre { -4}");
//simplificando a

Console.WriteLine($"x = { d = d / d} sobre { x = 2}");
//resultado

Console.WriteLine($"x = {d} sobre {x}");
