using System;

class Program{
  public static void Main(string[] args){
    Circulo x = new Circulo();
    x.raio = double.Parse(Console.ReadLine());
    Console.WriteLine(x.CalcularArea());
    Console.WriteLine(x.CalcularCircunferencia());
    
  }
}
class Circulo{
  public double raio;

  public double CalcularArea(){
    double area = 3.14159* (raio*raio);
    return area;
  }
  public double CalcularCircunferencia(){
    double circunferencia = 2 * 3.14159 * raio;
    return circunferencia;
  }
  
}
