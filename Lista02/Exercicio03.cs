//Calcular a média parcial de uma disciplina semestral, dadas as notas dos 1o e 2o bimestres (pesos 2 e 3).Considerar as notas com valores inteiros entre zero e cem.
using System;

class Program{
  public static void Main(string[] args){
    Console.WriteLine("Digite a nota do primeiro bimestre da disciplina: ");
    double nota1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a nota do segunda bimestre da disciplina: ");
    double nota2 = double.Parse(Console.ReadLine());
    double media = (nota1 * 2 + nota2 * 3) / 5;
    Console.Write($"Média parcial = {media}");
    
    
  }
}