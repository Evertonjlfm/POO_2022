using System;
using System.Globalization;

class MainClass{
  public static void Main (string[] args){
    Console.ReadLine();
    double salario = double.Parse(Console.ReadLine());
    double totalVendas = double.Parse(Console.ReadLine());

    double salarioFinal = totalVendas * 0.15 + salario;
    Console.WriteLine($"TOTAL = R$ " + salarioFinal.ToString("F2", CultureInfo.InvariantCulture));

   
  }
}