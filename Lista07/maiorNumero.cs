/*Retornar o maior entre dois números, utilizando o método Maior abaixo. O programa deve solicitar do usuário dois
valores e mostrar o maior entre eles utilizando o método Maior que deve ser também implementado.
public static double Maior(double x, double y)*/
using System;

class Program{
  public static void Main(string[] args){
    double x = double.Parse(Console.ReadLine());
    double y = double.Parse(Console.ReadLine());
    double maior = Maior(x,y);
    Console.WriteLine(maior);
  }
  public static double Maior(double x, double y){
  double maior = x;
  if(x < y){
    maior = y;
  }
  return maior;
  }
}

