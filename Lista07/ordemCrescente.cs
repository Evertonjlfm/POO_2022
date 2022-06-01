/*Ordenar três valores inteiros em ordem crescente, utilizando o método Ordenar abaixo. O programa deve solicitar
do usuário três valores e mostrar esses valores em ordem após a execução do método Ordenar.
public static void Ordenar(ref int x, ref int y, ref int z)*/
using System;

class Program{
  public static void Main(string[] args){
    int[] a = int.Parse(Console.ReadLine());

    Console.WriteLine(a);
  }
    public static void Ordenar(int x,int y,int z){
      int aux = x;
      while(x > y && x > z && y > z){
        x = y;
        y = z;
        z = x;  
      }
    }
  }