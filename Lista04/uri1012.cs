/*Faça um programa que leia três valores de ponto flutuante: A, B e C. Em seguida, calcule e mostre:
a) a área do triângulo retângulo que tem base A e altura C.
b) a área do círculo do raio C. (pi = 3,14159)
c) a área do trapézio que tem A e B por base e C por altura.
d) a área do quadrado que tem lado B.
e) a área do retângulo que tem lados A e B.*/
using System;
using System.Globalization;

class Program{
  public static void Main(String[] args){
    double pi = 3.14159;
    string[] entrada = Console.ReadLine().Split();
    double a = double.Parse((entrada[0]).ToString(CultureInfo.InvariantCulture));
    double b = double.Parse((entrada[1]).ToString(CultureInfo.InvariantCulture));
    double c = double.Parse((entrada[2]).ToString(CultureInfo.InvariantCulture));

    double areaTriangulo = a*c/2;
    double areaCirculo = pi * (c*c);
    double areaTrapezio = (a+b)*c/2;
    double areaQuadrado = b*b;
    double areaRetangulo = b*a;

    Console.WriteLine($"TRIÂNGULO: " + areaTriangulo.ToString("F3", CultureInfo.InvariantCulture));
    Console.WriteLine($"CIRCULO: " + areaCirculo.ToString("F3", CultureInfo.InvariantCulture));
    Console.WriteLine($"TRAPEZIO: " + areaTrapezio.ToString("F3", CultureInfo.InvariantCulture));
    Console.WriteLine($"QUADRADO: " + areaQuadrado.ToString("F3", CultureInfo.InvariantCulture));
    Console.WriteLine($"RETANGULO: " + areaRetangulo.ToString("F3", CultureInfo.InvariantCulture));
  }
}
