//Neste problema você tem que ler um valor inteiro e calcular o menor número possível de notas em que o valor pode ser decomposto. As notas possíveis são 100, 50, 20, 10, 5, 2 e 1. Imprima o valor lido e a lista de notas.
using System;

class Program{
  public static void Main(string[] args){
    int c100 = 0;int c50  = 0;int c20 = 0;int c10 = 0;int c5 = 0;int c2 = 0;int c1 = 0;
    int n = int.Parse(Console.ReadLine());
    if(n >= 100){
      while(n/100 != 0){
          n-=100;
          c100++;
        }
    }
    if(n >= 50){
      while(n/50 != 0){
          n-=50;
          c50++;
        }
    }
    if(n >= 20){
      while(n/20 != 0){
          n-=20;
          c20++;
        }
    }
    if(n >= 10){
      while(n/10 != 0){
          n-=10;
          c10++;
        }
    }
    if(n >= 5){
      while(n/5 != 0){
          n-=5;
          c5++;
        }
    }
    if(n >= 2){
      while(n/2 != 0){
          n-=2;
          c2++;
        }
    }
    if(n >= 1){
      while(n/1 != 0){
          n-=1;
          c1++;
        } 
    }
    Console.WriteLine(c100 + " nota(s) de R$ 100,00");
    Console.WriteLine(c50 + " nota(s) de R$ 50,00");
    Console.WriteLine(c20 + " nota(s) de R$ 20,00");
    Console.WriteLine(c10 + " nota(s) de R$ 10,00");
    Console.WriteLine(c5 + " nota(s) de R$ 5,00");
    Console.WriteLine(c2 + " nota(s) de R$ 2,00");
    Console.WriteLine(c1 + " nota(s) de R$ 1,00"); 
  }
}
      