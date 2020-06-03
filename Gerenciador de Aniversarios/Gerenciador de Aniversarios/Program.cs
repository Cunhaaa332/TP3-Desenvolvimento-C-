using System;
using System.Linq;

namespace Gerenciador_de_Aniversarios {
    class Program {
        static void Main(string[] args) {
            MenuPrincipal();
        }

        public static void MenuPrincipal() {
            Console.Clear();
            Console.WriteLine("Escolha uma das opcoes abaixo: ");
            Console.WriteLine("1 - Pesquisar Pessoa ");
            Console.WriteLine("2 - Adicionar Pessoas ");
            Console.WriteLine("3 - Sair ");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao) {
                case 1:
                    BuscaPessoa();
                    break;
                case 2:
                    CadastrarPessoa();
                    break;
                case 3:
                    Console.WriteLine("Tchau amigao!");
                    break;
                default:
                    Console.WriteLine("Opcao errada amigao!");
                    break;
            }
        }

        public static void CadastrarPessoa() {
            Console.Clear();

            Console.WriteLine("Entre com o nome: ");
            String nome = Console.ReadLine();
            Console.WriteLine("Entre com o sobre nome: ");
            String sobreNome = Console.ReadLine();

            DateTime aniversarioD = RecebeETransformaData();

            Pessoa p = new Pessoa(nome, sobreNome, aniversarioD);

            Console.WriteLine(p);
            Console.WriteLine("");
            Console.WriteLine("Esta tudo certo com a adicao? (s/n) ");
            string opcao = Console.ReadLine();
            if (opcao == "s") {
                Console.WriteLine("Ok, adicionando pessoa...");
                Dados.Adicionar(p);
            } else {
                CadastrarPessoa();
            }
            VoltarProMenu();
        }

        public static DateTime RecebeETransformaData() {
            Console.WriteLine("Entre com a data de nascimento em dd/mm/yyyy: ");
            string data = Console.ReadLine();

            DateTime dataC = new DateTime();
            if (data.Contains("/")) {
                string[] vet = data.Split('/');
                int ano = int.Parse(vet[2]);
                int mes = int.Parse(vet[1]);
                int dia = int.Parse(vet[0]);
                dataC = new DateTime(ano, mes, dia);
            } else {
                Console.WriteLine("Entre com uma data valida por favor.");
                VoltarProMenu();
            }
            return dataC;
        }

        public static void BuscaPessoa() {
            int i = 0;
            Console.Clear();
            Console.WriteLine("Entre com o nome da pessoa que deseja buscar:");
            string[] nomeESobrenome = Console.ReadLine().Split(' ');
            string nome = nomeESobrenome[0];

            Dados.BuscarPessoas(nome);

            if (Dados.pessoasEncontradas.Count == 0) {
                Console.WriteLine("Nenhum usuario Encontrado");
                VoltarProMenu();
            }

            Console.WriteLine("");
            Console.WriteLine("Pesssoas Encontradas: ");

            foreach (var pessoa in Dados.pessoasEncontradas) {
                Console.WriteLine(i + " - " + pessoa.GetNome() + " " + pessoa.GetSobreNome());
                i++;
            }

            Console.WriteLine("");
            Console.WriteLine("Digite o numero correspondente a pessoa que deseja ter mais detalhes: ");
            int escolha = int.Parse(Console.ReadLine());

            if (escolha > i || escolha < 0) {
                Console.WriteLine("Escolha errada amigao!");
            } else {
                Console.WriteLine(Dados.pessoasEncontradas.ElementAt(escolha));
            }

            VoltarProMenu();

        }

        public static void VoltarProMenu() {
            Console.WriteLine("Aperte x para voltar ao menu.");
            string volta = Console.ReadLine();
            if (volta == "x") {
                MenuPrincipal();
            } else {
                Console.WriteLine("Opcao errada amigo!");
                VoltarProMenu();
            }
        }
    }
}
