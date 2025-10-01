// See https://aka.ms/new-console-template for more information
using System;
namespace ColetaDeDados
{
    // 1. Classe para Organizar os Dados (Melhor que variáveis estáticas)
    public class DadosPessoais
    {
        public string NomeCompleto { get; set; }
        public int Idade { get; set; } // Tipagem como 'int' para números
        
        // Dados de Endereço mais claros
        public string NomeRua { get; set; }
        public string Bairro { get; set; }
        public string NumeroCasa { get; set; } 
        public string Cidade { get; set; }
        
        // Número pessoal como string para manter formatação (ex: (xx) xxxxx-xxxx)
        public string Telefone { get; set; } 

        // Método auxiliar para formatar a saída (POO)
        public string ObterEnderecoFormatado()
        {
            return $"Rua {NomeRua}, Nº {NumeroCasa}, Bairro {Bairro}, Cidade {Cidade}";
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            // 2. Variável de controle para o loop
            bool dadosConfirmados = false;
            DadosPessoais dados = new DadosPessoais();

            // 3. Uso do 'while' para garantir que a coleta rode pelo menos uma vez 
            // e continue ENQUANTO a confirmação não for bem-sucedida.
            while (!dadosConfirmados) 
            {
                Console.Clear(); // Limpa a tela para uma nova tentativa (opcional, mas bom)
                Console.WriteLine("=== Coleta de Dados Pessoais ===");

                // Coleta de Dados
                dados = ColetarDados();

                // Confirmação
                dadosConfirmados = ConfirmarDados(dados);

                if (!dadosConfirmados)
                {
                    Console.WriteLine("\n\nPressione Enter para reiniciar a coleta.");
                    Console.ReadKey();
                }
            }

            Console.WriteLine("\n--- FIM DO PROGRAMA ---");
        }

        /// <summary>
        /// Método responsável por solicitar e ler todos os dados do usuário.
        /// </summary>
        static DadosPessoais ColetarDados()
        {
            DadosPessoais dados = new DadosPessoais();

            Console.WriteLine("Qual seu nome completo?: ");
            dados.NomeCompleto = Console.ReadLine();

            // Lógica de validação básica para 'Idade' (converter de string para int)
            Console.WriteLine("Qual sua idade?: ");
            if (int.TryParse(Console.ReadLine(), out int idadeDigitada))
            {
                dados.Idade = idadeDigitada;
            }
            else
            {
                // Se a conversão falhar, define como 0 e avisa
                Console.WriteLine("⚠️ Idade inválida. Por favor, corrija na confirmação.");
                dados.Idade = 0; 
            }

            Console.WriteLine("Qual o nome da sua rua?: ");
            dados.NomeRua = Console.ReadLine();

            Console.WriteLine("Qual o nome do Bairro?: ");
            dados.Bairro = Console.ReadLine();

            Console.WriteLine("Número da sua casa?: ");
            dados.NumeroCasa = Console.ReadLine();

            Console.WriteLine("Qual o nome da sua Cidade?: ");
            dados.Cidade = Console.ReadLine();

            Console.WriteLine("Qual seu número pessoal (telefone)?:");
            dados.Telefone = Console.ReadLine();

            return dados;
        }

        /// <summary>
        /// Método responsável por exibir e pedir a confirmação dos dados.
        /// </summary>
        static bool ConfirmarDados(DadosPessoais dados)
        {
            Console.WriteLine("\n--- Confirme seus dados ---");
            Console.WriteLine($"Nome: {dados.NomeCompleto}");
            Console.WriteLine($"Idade: {dados.Idade}");
            // Chamando o método da classe DadosPessoais para formatar o endereço
            Console.WriteLine($"Endereço: {dados.ObterEnderecoFormatado()}"); 
            Console.WriteLine($"Número Pessoal: {dados.Telefone}");

            Console.WriteLine("\nOs dados acima estão corretos? (sim/não)");
            string resposta = Console.ReadLine().Trim().ToLower();

            switch (resposta)
            {
                case "sim":
                    Console.WriteLine("✅ Dados confirmados com sucesso!");
                    return true; // Retorna TRUE, encerrando o loop principal
                
                case "não":
                case "nao":
                    Console.WriteLine("⚠️ Vamos reiniciar a coleta de dados.");
                    return false; // Retorna FALSE, mantendo o loop principal ativo
                
                default:
                    Console.WriteLine("Resposta inválida. Reiniciando a coleta.");
                    return false;
            }
        }
    }
}