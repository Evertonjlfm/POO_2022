/*Flavinho sabe que a chance de ganhar na loteria é bem pequena. Ele gosta muito de estudar probabilidade! Mas, justamente por entender de probabilidades, Flavinho segue o ditado, “quem não arrisca, não petisca!”, e faz um jogo toda semana.
Na loteria preferida dele, o jogador aposta seis números entre 1 e 99. No sorteio, também são escolhidos seis números ganhadores entre 1 e 99. Quem acerta 3, 4, 5 ou 6 números ganha como prêmio, respectivamente, um “terno”, uma “quadra”, uma “quina” ou uma “sena”.
Nesta tarefa, você deve escrever um programa que diga qual foi o prêmio que Flavinho ganhou, dados os seis números que ele apostou e os seis números que foram sorteados.*/
using System;

class Program{
  public static void Main(string[] args){
    int acertos = 0;
    string[] aposta = Console.ReadLine().Split();
    int a1 = int.Parse(aposta[0]);
    int a2 = int.Parse(aposta[1]);
    int a3 = int.Parse(aposta[2]);
    int a4 = int.Parse(aposta[3]);
    int a5 = int.Parse(aposta[4]);
    int a6 = int.Parse(aposta[5]);

    string[] sorteio = Console.ReadLine().Split();
    int s1 = int.Parse(sorteio[0]);
    int s2 = int.Parse(sorteio[1]);
    int s3 = int.Parse(sorteio[2]);
    int s4 = int.Parse(sorteio[3]);
    int s5 = int.Parse(sorteio[4]);
    int s6 = int.Parse(sorteio[5]);

    if(a1 == s1 || a1 == s2 || a1 == s3 || a1 == s4 || a1 == s5 || a1 == s6){
      acertos+=1;
    }
    if(a2 == s1 || a2 == s2 || a2 == s3 || a2 == s4 || a2 == s5 || a2 == s6){
      acertos+=1;
    }
    if(a3 == s1 || a3 == s2 || a3 == s3 || a3 == s4 || a3 == s5 || a3 == s6){
      acertos+=1;
    }
    if(a4 == s1 || a4 == s2 || a4 == s3 || a4 == s4 || a4 == s5 || a4 == s6){
      acertos+=1;
    }
    if(a5 == s1 || a5 == s2 || a5 == s3 || a5 == s4 || a5 == s5 || a5 == s6){
      acertos+=1;
    }
    if(a6 == s1 || a6 == s2 || a6 == s3 || a6 == s4 || a6 == s5 || a6 == s6){
      acertos+=1;
    }

    if(acertos == 3){
      Console.WriteLine("terno");
    }
    else if(acertos == 4){
      Console.WriteLine("quadra");
    }
    else if(acertos == 5){
      Console.WriteLine("quina");
    }
    else if(acertos == 6){
      Console.WriteLine("sena");
    }
    else{
      Console.WriteLine("azar");
    }
  }
}