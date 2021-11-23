using System;

namespace CadastroAluno
{
    public class Aluno
    {
        string[] pesquisa;
        string[] nomes = new string[10];
        int[] idades = new int[10];
        int posicao, valor, quantidade = 0;
        int opcao = 0;
        
        public void CadastrarAluno()
        {
    
            while (opcao != 5)
            {
                Console.Clear();
                opcao = Menu();
                switch (opcao)
                {
                    case 1:
                    {
                        Console.WriteLine("Quantos usuários serão cadastrados? Máximo de 10 usuários");

                        quantidade = Convert.ToInt32(Console.ReadLine());

                        for (int posicao = 1; posicao <= quantidade; posicao++)
                        {
                            Console.WriteLine("Qual o nome do usuário?");
                            var nome = Console.ReadLine();
                            nomes[posicao - 1] = nome;

                            Console.WriteLine("Qual a idade do usuário?");
                            var idade = Convert.ToInt32(Console.ReadLine());
                            idades[posicao - 1] = idade;

                        }

                        Console.WriteLine("Usuário(s) cadastrado(s) com sucesso!");
                        break;
                    }

                    case 2:
                    {
                        Console.WriteLine("Lista de usuários cadastrados:\n");

                        for (int posicao = 1; posicao <= quantidade; posicao++)
                        {
                            if (idades[posicao-1]!= 0)
                            {
                                Console.WriteLine($"Os usuários encontrados foram: {nomes[posicao - 1]} - {idades[posicao - 1]} anos");
                                
                            }
                        }
                        break;
                    }

                    case 3:
                    {
                        Console.WriteLine("Qual usuário você deseja buscar?");
                        Console.WriteLine("Informe o nome do usuário");
                        
                        var nome = Console.ReadLine();

                        for (int posicao = 1; posicao <= quantidade; posicao++)
                        {
                            if (nomes[posicao - 1] == nome)
                            {
                                Console.WriteLine($"Nome do aluno(a) encontrado: {nomes[posicao - 1]} - {idades[posicao - 1]} anos");
                            }
                            
                        }

                        break;
                    }

                    case 4:
                    {
                        Console.WriteLine("Informe o usuário a ser excluído");
                        
                        var nome = Console.ReadLine();
                        
                        for (int posicao = 1; posicao <= quantidade; posicao++)
                        {
                            if (nomes[posicao - 1] == nome)
                            {
                                nomes[posicao-1] = nomes[posicao + 1];
                                idades[posicao-1] = idades[posicao + 1];
                            }

                        }
                        
                        Console.WriteLine("Usuário deletado com sucesso!");
                    }
                        break;

                    case 5:
                    {
                        Console.WriteLine("Cadastro de alunos encerrado. Muito obrigado!");
                    }
                        break;
                }
            }
        }

        private int Menu()
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