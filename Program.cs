using System;

namespace aula_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Uma escola te contratou para desenvolver um aplicativo que realize a média das notas dos alunas de uma sala. Lembrando que atualmente a sala tem apenas 5 alunos e a nota vai de 0 à 10.

            Console.WriteLine(">>Média dos alunos__/n");
            
            float soma = 0;
            float media = 0;
            string[] listaAlunos = new string [5] {"Thiago Ribeiro","Natalya Lopes","Joao Vitor","Maria Menezes","Xuxa Meneguel"};

            for (int i = 0; i < 5; i++) {
                Console.WriteLine("Digite a nota do " + listaAlunos[i] + ":");
                float nota =0;
                float.TryParse(Console.ReadLine(), out nota);
                soma += nota;
            }

            media = soma / 5;
            Console.WriteLine("A media da sala é: " + media);
        }
    }
}