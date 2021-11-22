using System;

namespace CadastroAluno
{
    public class Aluno
    {
        string[] pesquisa;
        string[] nomes = new string[10];
        int[] idade = new int[10];
        int posicao, valor, quantidade = 0;
        
        public void CadastrarAluno()
        {
            var opcao = Menu();

            switch (opcao)
            {
                case 1:
                {
                    Console.WriteLine("teste1");
                    //Menu();

                    break;
                }

                case 2:
                {
                    break;
                }

                case 3:
                {
                    break;
                }

                case 4:
                {
                    break;
                }

                case 5:
                {
                    break;
                }
            }
        }

        public int Menu()
        {
            Console.WriteLine("**************************************\n");
            Console.WriteLine("CADASTRO DE USUÁRIOS\n");
            Console.WriteLine("**************************************\n");
            Console.WriteLine("Menu de opções:\n");
            Console.WriteLine("1- Cadastrar usuário\n");
            Console.WriteLine("2- Listar os usuários cadastrados\n");
            Console.WriteLine("3- Buscar um usuário\n");
            Console.WriteLine("4- Deletar um usuário\n");
            Console.WriteLine("5- Sair do sistema\n");
            Console.WriteLine("**************************************\n");

            Console.WriteLine("Digite uma opcao:");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}