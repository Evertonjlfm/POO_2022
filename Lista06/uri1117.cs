/*Escreva um programa que leia duas notas de um aluno. Calcule e imprima a média dessas pontuações. Seu programa deve aceitar apenas pontuações válidas [0..10]. Cada pontuação deve ser validada separadamente.*/
using System;

class Program{
  public static void Main(string[] args){
    double nota1 = double.Parse(Console.ReadLine());
    while(nota1 < 0 || nota1 > 10){
      Console.WriteLine("nota invalida");
      nota1 = double.Parse(Console.ReadLine());
    }
    double nota2 = double.Parse(Console.ReadLine());
    while(nota2 < 0 || nota2 > 10){
      Console.WriteLine("nota invalida");
      nota2 = double.Parse(Console.ReadLine());
    }
    double media = (nota1 + nota2)/2;
    Console.WriteLine("media = "+ media);
  }
}