//Faça um programa que leia 3 valores inteiros e apresente o maior seguido da mensagem "eh o maior".
using System;

class Program{
  public static void Main(string[] args){
    string[] valores = Console.ReadLine().Split();
    int valor1 = int.Parse(valores[0]);
    int valor2 = int.Parse(valores[1]);
    int valor3 = int.Parse(valores[2]);

    int maiorab= (valor1 + valor2 + Math.abs(valor1 - valor2))/2;
    int maior = (maiorab + valor3 + Math.abs(maiorab - valor3))/2;
    Console.WriteLine(maior)
      
  }
}