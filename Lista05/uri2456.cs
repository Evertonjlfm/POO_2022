/*Beatriz adora jogar cartas com os amigos. Para treinar a memória e o raciocínio lógico, ela inventou um pequeno hobby com cartas. Ela retira as cinco primeiras cartas do topo de um baralho bem embaralhado e as coloca em sequência da esquerda para a direita, a mesa com a face voltada para baixo.
Então ela olha, por um momento, cada uma das cartas da sequência (e logo as coloca de volta na mesa, viradas para baixo). Usando apenas sua memória, Beatrice deve agora dizer se a sequência de cartas está cada vez mais ordenada, decrescente ou não.
Depois de tanto brincar, ela está ficando cansada, e não confia em seu próprio julgamento para descobrir se ela teve sucesso ou errou. Então ela pediu que você fizesse um programa que, dada uma sequência de cinco cartas, determinasse se uma determinada sequência é ordenada de forma crescente, decrescente ou não.*/
using System;

class Program{
  public static void Main(string[] args){
    string[] baralho = Console.ReadLine().Split();
    int c1 = int.Parse(baralho[0]);
    int c2 = int.Parse(baralho[1]);
    int c3 = int.Parse(baralho[2]);
    int c4 = int.Parse(baralho[3]);
    int c5 = int.Parse(baralho[4]);

    if(c1 > c2 && c2 > c3 && c3 > c4 && c4 > c5){
      Console.WriteLine("D");
    }
    else if(c1 < c2 && c2 < c3 && c3 < c4 && c4 < c5){
      Console.WriteLine("C");
    }
    else{
      Console.WriteLine("N");
    }
  }
}