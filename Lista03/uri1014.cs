using System;

class Program{
  public static void Main(string[] args){
    int distancia = int.Parse(Console.ReadLine());
    double combustivel = double.Parse(Console.ReadLine());
  
    double kmL = distancia/combustivel;
  
    Console.WriteLine(Math.Round(kmL,3) + " km/l");
  }
}