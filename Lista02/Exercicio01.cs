//Ler o primeiro nome de uma pessoa e mostrar a mensagem: “Bem-vindo ao C#, <xxx>”, onde <xxx> é o nome informado pela pessoa.
using System;

class Program {
  public static void Main(string[] args) {
    Console.WriteLine("Digite seu primeiro nome: ");
    string nome = Console.ReadLine();
    Console.WriteLine($"Bem vindo(a) ao C#, {nome}.");
  }
}
