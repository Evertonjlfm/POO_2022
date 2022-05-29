/*A invenção do carro tornou muito mais rápido e mais barato realizar viagens de longa distância. Realizar uma viagem rodoviária tem dois tipos de custos: cada quilômetro percorrido na rodovia tem um custo associado (não só devido ao consumo de combustível mas também devido ao desgaste das peças do carro, pneus, etc.), mas também é necessário passar por vários pedágios localizados ao longo da rodovia.
  Os pedágios são igualmente espaçados ao logo da rodovia; o começo da estrada não possui um pedágio, mas o seu final pode estar logo após um pedágio (por exemplo, se a distância entre dois pedágios consecutivos for de 37 km e a estrada tiver 111 km, o motorista deve pagar um pedágio aos 37 km, aos 74 km e aos 111 km, logo antes de terminar a sua viagem).
  Dadas as características da rodovia e os custos com gasolina e com pedágios, calcule o custo total da viagem.*/
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