using System;

class Program{
  public static void Main(string[] args){
    
  }
}
class Disciplina{
  
  string nomeDisciplina;
  public double nota1;
  public double nota2;
  public double nota3;
  public double nota4;
  public double provaFinal;

  public double CalcularMediaParcial(){
    double media = (nota1*2 + nota2*2 + nota3*3 + nota4*3)/10;
    return media;
  }
  public double CalcularMediaFinal(double provafinal){
    double mediaFinal = provafinal + 
  }

  
}