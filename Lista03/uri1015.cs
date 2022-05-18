//Leia os quatro valores correspondentes aos eixos x e y de dois pontos do plano, p1 (x1, y1) e p2 (x2, y2) e calcule a distância entre eles, mostrando quatro casas decimais após a vírgula, conforme a fórmula :
//Distância = Math.Sqrt((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1));
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