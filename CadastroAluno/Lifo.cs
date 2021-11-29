using System;

namespace CadastroAluno
{
    public class Lifo
    {
        private int[] pilha;

        private int topo;

        public Lifo()
        {
            pilha = new int[20];
            topo = -1;
        }

        public bool Empilhar(int numero)
        {
            if (topo == pilha.Length - 1)
            {
                return false;
            }

            topo++;
            pilha[topo] = numero;
            return true;
        }

        public void Desempilhar()
        {
            if (topo < 0)
            {
                return;
            }

            topo--;
        }

        public void Limpar()
        {
            topo = -1;
        }

        public void Listar()
        {
            int aux;

            if (topo < 0)
            {
                Console.WriteLine("lista vazia");
            }

            for (aux = topo; aux >= 0; aux--)
                Console.WriteLine("    " + pilha[aux]);

            Console.WriteLine("");
        }

        public void Vazia()
        {
            if (topo < 0)
            {
                Console.WriteLine("lista vazia");
            }
            else
            {
                Console.WriteLine("Você tem a(s) seguinte(s) matrículas:");
                Listar();
            }
        }
    }
}