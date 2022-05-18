//Calcule o consumo médio de um carro, fornecendo a distância total percorrida (em Km) e o total de combustível gasto (em litros).
using System;

class Program{
  public static void Main(string[] args){
    int distancia = int.Parse(Console.ReadLine());
    double combustivel = double.Parse(Console.ReadLine());
  
    double kmL = distancia/combustivel;
  
    Console.WriteLine(Math.Round(kmL,3) + " km/l");
  }
}