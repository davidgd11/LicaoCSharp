using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicaoCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            VerificaLogin();

        }

        static void VerificaLogin()
        {
            try
            {
                string usuarioCorreto = "rm98603@fiap.com";
                string senhaCorreta = "98603";

                Console.WriteLine("--- ENTRAR ---");

                Console.WriteLine("Usuário:");
                String usuario = Console.ReadLine();

                Console.WriteLine("Senha:");
                String senha = Console.ReadLine();

                if (usuarioCorreto == usuario && senhaCorreta == senha)
                {
                    Console.WriteLine("\n*** SEJA VEM VINDO(A) ***");

                    CalcularAposentadoria();
                }
                else
                {
                    Console.WriteLine("\nEmail e/ou senha inválido!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }


        static void CalcularAposentadoria()
        {
            try
            {
                int idadeHomem = 65;
                int idadeMulher = 62;
                int contribuicaoHomem = 20;
                int contribuicaoMulher = 15;


                Console.WriteLine("\n--- Calcular tempo para aposentadoria ---");

                Console.WriteLine("Você é homem(H) ou mulher(M)?:");
                string sexo = Console.ReadLine().ToUpper();

                Console.WriteLine("Digite sua idade:");
                int idade = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite há quantos anos você trabalha:");
                int contribuicao = int.Parse(Console.ReadLine());

                if (sexo == "H")
                {
                    if (idade >= idadeHomem && contribuicao >= contribuicaoHomem)
                    {
                        Console.WriteLine("\nVocê já pode se aposentar!");
                    }
                    if (idade < idadeHomem)
                    {
                        int calculoIdadeH = idadeHomem - idade;
                        Console.WriteLine($"\nVocê precisa ter mais {calculoIdadeH} anos");
                    }
                    if (contribuicao < contribuicaoHomem)
                    {
                        int calculoContribuicaoH = contribuicaoHomem - contribuicao;
                        Console.WriteLine($"\nVocê ainda precisa trabalhar por {calculoContribuicaoH} anos");
                    }
                }
                else if (sexo == "M")
                {
                    if (idade >= idadeMulher && contribuicao >= contribuicaoMulher)
                    {
                        Console.WriteLine("\nVocê já pode se aposentar!");
                    }
                    if (idade < idadeMulher)
                    {
                        int calculoIdadeM = idadeMulher - idade;
                        Console.WriteLine($"\nVocê precisa ter mais {calculoIdadeM} anos");
                    }
                    if (contribuicao < contribuicaoMulher)
                    {
                        int calculoContribuicaoM = contribuicaoMulher - contribuicao;
                        Console.WriteLine($"\nVocê ainda precisa trabalhar por {calculoContribuicaoM} anos");
                    }
                }
                else
                {
                    Console.WriteLine("Texto inválido. Tente novamente!");
                }

                Console.WriteLine("\nObrigado! Pressione qualquer tecla para sair do console. ");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
