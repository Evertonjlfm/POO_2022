//Calcular a distância, em quilômetros, percorrida pela luz em um intervalo de tempo no formato “HH:MM:SS”.Considerar a velocidade de luz como 300 mil km/s.
using System;

class Program{
  public static void Main(string[] args){
    Console.WriteLine("Digite o intervalo de tempo no formato “HH:MM:SS”");
    string[] tempo = Console.ReadLine().Split(':');
    double horas = double.Parse(tempo[0]);
    double minutos = double.Parse(tempo[1]);
    double segundos = double.Parse(tempo[2]);

    double calc= (horas*60*60 + minutos*60 + segundos) * 300000;

    Console.WriteLine($"A luz percorreu {calc} km nesse intervalo");
    

    
    
  }
}