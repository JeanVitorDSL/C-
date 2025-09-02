// See https://aka.ms/new-console-template for more information
using System;

namespace ColetaDeDados
{
    public class Program
    {
        // Dados do usuário
        static string ResidenceAddress;
        static string HomeLocation;
        static string AddressGeneric;
        static string CityGeneric;
        static string Fullname;
        static string Age;
        static string PersonalNumber;

        static void Main(string[] args)
        {
            bool Return = false;

            while (Return) //Return here after user say "não"
            {
                Console.WriteLine("=== Coleta daaados ===");

                Console.WriteLine("Qual seu nome completo?: ");
                Fullname = Console.ReadLine();

                Console.WriteLine("Qual sua idade?: ");
                Age = Console.ReadLine();

                Console.WriteLine("Qual o nome da sua rua?: ");
                ResidenceAddress = Console.ReadLine();

                Console.WriteLine("Qual o nome do Bairro?: ");
                HomeLocation = Console.ReadLine();

                Console.WriteLine("Número da sua casa?: ");
                AddressGeneric = Console.ReadLine();

                Console.WriteLine("Qual o nome da sua Cidade?: ");
                CityGeneric = Console.ReadLine();

                Console.WriteLine("Qual seu número pessoal?");
                PersonalNumber = Console.ReadLine();

                // Confirmação
                Console.WriteLine("\n--- Confirme seus dados ---");
                Console.WriteLine($"Nome: {Fullname}");
                Console.WriteLine($"Idade: {Age}");
                Console.WriteLine($"Endereço: Rua {ResidenceAddress}, Nº {AddressGeneric}, Bairro {HomeLocation}, Cidade {CityGeneric}");
                Console.WriteLine($"Número Pessoal: {PersonalNumber}");

                Console.WriteLine("\nEstá correto? (sim/não)");
                string ConfirmRepost1 = Console.ReadLine().Trim().ToLower();

                switch (ConfirmRepost1)
                {
                    case "sim":
                        Console.WriteLine("✅ Dados confirmados com sucesso!");
                        break;
                    case "não":
                    case "nao":
                        Console.WriteLine("⚠️ Vamos reiniciar a coleta de dados.");
                        break;
                    default:
                        Console.WriteLine("Resposta inválida.");
                        break;
                }
            
            }
        }
    }
}