/*Leia 4 valores inteiros A, B, C e D. Então se B for maior que C e D for maior que A e se a soma de C e D for maior que a soma de A e B e se C e D forem valores positivos e se A for par, escreva a mensagem “Valores aceitos” . Caso contrário, escreva a mensagem “Valores não aceitos” (Valores não aceitos).*/
using System;

class Program{
  public static void Main(String[] args){
    string[] valores = Console.ReadLine().Split();
    int a = int.Parse(valores[0]);
    int b = int.Parse(valores[1]);
    int c = int.Parse(valores[2]);
    int d = int.Parse(valores[3]);

    if(b > c && d > a && c+d > b+a && c > 0 && d > 0 && a%2 == 0){
      Console.WriteLine("Valores aceitos");
    }
    else{
      Console.WriteLine("Valores nao aceitos");
    }
    
  }
}