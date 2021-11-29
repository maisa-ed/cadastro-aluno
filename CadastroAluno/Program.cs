using System;

namespace CadastroAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            var opcaoMenu = Menu();

            var lifo = new Lifo();

            while (opcaoMenu != 9)
            {
                switch (opcaoMenu)
                {
                    case 1:
                    {
                        Console.WriteLine("Digite sua matricula");
                        var matricula = Convert.ToInt32(Console.ReadLine());
                        lifo.Empilhar(matricula);
                        opcaoMenu = Menu();
                        break;
                    }
                    case 2:
                    {
                        lifo.Desempilhar();
                        opcaoMenu = Menu();
                        break;
                    }
                    case 3:
                    {
                        lifo.Limpar();
                        opcaoMenu = Menu();
                        break;
                    }
                    case 4:
                    {
                        lifo.Listar();
                        opcaoMenu = Menu();
                        break;
                    }
                    case 5:
                    {
                        lifo.Vazia();
                        opcaoMenu = Menu();
                        ;
                        break;
                    }
                }
            }
        }

        private static int Menu()
        {
            var menu = "[-------- Menu ---------]";
            menu += "\n[1] - Empilhar";
            menu += "\n[2] - Desempilhar";
            menu += "\n[3] - Limpar ";
            menu += "\n[4] - Listar ";
            menu += "\n[5] - Vazia";
            menu += "\n[ ------------------------- ]";
            menu += "\nInforme sua opção: ";

            Console.WriteLine(menu);

            var opcao = Convert.ToInt32(Console.ReadLine());

            return opcao;
        }
    }
}