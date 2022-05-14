//Ler o nome completo de uma pessoa e mostrar a mensagem: “Bem-vindo ao C#, <xxx>”, onde <xxx> é o primeiro nome da pessoa.
using System;

class Program{
  public static void Main(string[] args){
    Console.Write("Digite seu nome completo: ");
    string[] nome = Console.ReadLine().Split();
    Console.Write($"Bem vindo ao C#, {nome[0]}.");
    
  }
}