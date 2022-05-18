using System;

class Program{
  public static void Main(string[] args){
    string[] linha1 = Console.ReadLine().Split();
    int l = int.Parse(linha1[0]);
    int d = int.Parse(linha1[1]);

    string[] linha2 = Console.ReadLine().Split();
    int k = int.Parse(linha2[0]);
    int p = int.Parse(linha2[1]);

    int valorTotal = l/d*p + l*k;
    
    Console.WriteLine(valorTotal);
  }
}