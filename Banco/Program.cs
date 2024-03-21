using System.Globalization;


namespace Banco {

    class Program {

        static void Main(string[] args) {


            Console.WriteLine("------------- T O D A Y $ B A N K -------------");

            Console.WriteLine("Ecolha a operação que deseja realizar: ");
            Console.WriteLine(" ");
            Console.WriteLine("1- Abrir conta bancária.  2- Sair.");
            Console.WriteLine(" ");

            int escolha = int.Parse(Console.ReadLine());

            if (escolha == 1) {

                Console.WriteLine("Digite o nome do titular: ");

                string titular = Console.ReadLine();

                Console.WriteLine("Digite seu CPF será utilizado como identificação da conta: ");

                string CPF = Console.ReadLine();

                Console.WriteLine("Haverá um depósito inicial (s/n)?");


                string escolhaMenu2 = Console.ReadLine();
                double deposito = 0;

                Conta c1 = new Conta(titular, CPF, deposito);

                if (escolhaMenu2 == "s") {

                    Console.WriteLine("Insira o valor do depósito inicial: ");

                    deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Conta.Deposito(deposito, c1);
                    Console.Clear();

                    Console.WriteLine(c1);
                    Console.ReadKey();

                }


                // Console.WriteLine("Deseja fazer Um depósito ou saque?");
                // Console.WriteLine(" 1- Depósito. 2- Saque.");

                // int escolha2 = int.Parse(Console.ReadLine());

                //if (escolha2 == 1) {

                Console.WriteLine("Digite o valor a ser depositado: ");
                double depo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Conta.Deposito(depo, c1);

                Console.Clear();

                Console.WriteLine(c1);

                Console.ReadKey();


                // }
                //else if (escolha2 == 2) {

                Console.WriteLine("Digite o valor a ser sacado: ");
                double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Conta.Saque(saque, c1);
                Console.Clear();
                Console.WriteLine(c1);
                Console.WriteLine(" ");

                Console.WriteLine("Volte Sempre!");
                Console.ReadKey();
            }
            if (escolha == 2) {

                Console.WriteLine("Volte Sempre!");

                Console.ReadKey();

            }
            else if (escolha != 1 && escolha != 2) {
                Console.WriteLine("Opção Invalida! Pressione qualquer tecla!");
                Console.ReadKey();
                
                Console.Clear();

                Main(args);
            }

        }

    }

}






