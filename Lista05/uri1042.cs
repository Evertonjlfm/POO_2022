/*Leia três números inteiros e ordene-os em ordem crescente. Após, imprima esses valores em ordem crescente, uma linha em branco e depois os valores na sequência conforme foram lidos.*/
using System;

class Program{
  public static void Main(string[] args){
    string[] valores = Console.ReadLine().Split();
    int a = int.Parse(valores[0]);
    int b = int.Parse(valores[1]);
    int c = int.Parse(valores[2]);

    int maior = a;
    int central = b;
    int menor = c;

    if(a > b && a > c && c > b){
      maior = a;
      central = c;
      menor = b;
    }
    else if(b > a && b > c && a > c){
      maior =b;
      central = a;
      menor = c;
    }
    else if(b > a && b > c && c > a){
      maior = b;
      central = c;
      menor = a;
    }
    else if(c > a && c > b && a > b){
      maior = c;
      central = a;
      menor = b;
    }
    else if(c > a && c > b && b > a){
      maior = c;
      central = b;
      menor = a;
    }
    Console.WriteLine(menor);
    Console.WriteLine(central);
    Console.WriteLine(maior);
    Console.WriteLine();
    Console.WriteLine(a);
    Console.WriteLine(b);
    Console.WriteLine(c);
  }
}