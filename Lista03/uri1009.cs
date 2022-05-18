//Faça um programa que leia o nome de um vendedor, seu salário fixo e o total da venda feita por ele mesmo no mês (em dinheiro). Considerando que este vendedor recebe 15% sobre todos os produtos vendidos, escreva o salário final (total) deste vendedor ao final do mês, com duas casas decimais.
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