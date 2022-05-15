//Calcular área, perímetro e diagonal de um retângulo, dados sua base e sua altura. Considerar que os valores podem ser números reais. Mostrar o resultado com duas casas decimais.
using System;

class Program{
  public static void Main(string[] args){
    Console.WriteLine("Digite a base e a altura do retângulo:");
    double b = double.Parse(Console.ReadLine());
    double a = double.Parse(Console.ReadLine());
    
    double area = b*a;
    double perimetro = b + b + a + a;
    double diagonal = Math.Sqrt(b*b + a*a);

    Console.WriteLine($"Àrea = {area:f2} - Perímetro {perimetro:f2} - Diagonal = {diagonal:f2}");

    

  }
}