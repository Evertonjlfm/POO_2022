using System;

class Program{
  public static void Main(string[] args){
    ContaBancaria x = new ContaBancaria();
    x.titular = "adsadas";
    x.numeroConta = 34324;
    x.saldo = 0.0;
    x.Depositar(100);
    x.Sacar(40);
    Console.WriteLine(x.saldo);
  }
}

class ContaBancaria{
  public string titular;
  public int numeroConta;
  public double saldo;


  public void Depositar(double valorDeposito){
    saldo += valorDeposito;
  }

  public void Sacar(double valorSaque){
    saldo-=valorSaque;
    
  }
}