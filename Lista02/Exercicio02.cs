using System;

class Program{
  public static void Main(string[] args){
    Console.Write("Digite seu nome completo: ");
    string[] nome = Console.ReadLine().Split();
    Console.Write($"Bem vindo ao C#, {nome[0]}.");
    
  }
}