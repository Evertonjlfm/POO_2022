using System;

class Program{
  public static void Main(string[] args){
    string[] linha1 = Console.ReadLine().Split(' ');
    double x1 = double.Parse(linha1[0]);
    double y1 = double.Parse(linha1[1]);

    string[] linha2 = Console.ReadLine().Split(' ');
    double x2 = double.Parse(linha2[0]);
    double y2 = double.Parse(linha2[1]);

    double distancia = Math.Sqrt((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1));

    Console.WriteLine(Math.Round(distancia, 4));
  }
}