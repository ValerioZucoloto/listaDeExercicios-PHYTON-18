using System;

class MainClass {
  public static void Main (string[] args) {
    
    

    // Phyton listaDeExercicios - ExerciciosComListas - Número 18

        int tam = 23;
        int[] jogadores = new int[tam];
        int voto = -1;
        int totalVotos = 0;
        float perc_jogador = 0.2f;
        int total_votos=0;

        Console.WriteLine ("Informe um jogador: ");
        voto = int.Parse (Console.ReadLine());

        while (voto != 0) {
                if (voto >=1 && voto <= 23) {
                        jogadores[voto-1]++;
                }
                else {
                        Console.WriteLine ("Jogador inválido!");
                }

                Console.WriteLine ("Informe um jogador: ");
                voto = int.Parse (Console.ReadLine());
        }

        for (int i=0; i < tam; i++) {
                totalVotos = totalVotos + jogadores[i];
        }

        Console.WriteLine ("Total de votos = " + totalVotos);

        for (int i=0; i<tam; i++) {
                if (jogadores[i] > 0) {
                        perc_jogador = ((float)jogadores[i]/total_votos);
                                Console.WriteLine("Jogador {0} - Votos {1} - %: {2:f}", i+1, jogadores[i], perc_jogador);
                }
        }
        
  }
}