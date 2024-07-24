using System;

namespace RegistroELogin
{
  	class Program
	{
    		static void Main(string[] args)
    		{
			Console.WriteLine("REGISTRO");
			Console.WriteLine("Digite Seu Nome De Usuario:");
			string username = Console.ReadLine();
			Console.WriteLine("Nome De Usuario Definido Para: " + username);
			Console.WriteLine("Digite Sua Senha");
			string password = Console.ReadLine();
           		Console.Clear();
			Console.WriteLine("LOGIN");
			Console.WriteLine("Digite Sua Senha Para Entrar Como:" + username);
			string input = Console.ReadLine();
			if (input == password)
			{
				Console.WriteLine("Login Efetuado Com Sucesso.");
			}
			else
			{
				Console.WriteLine("Senha Incorreta. Acesso Negado.");
			}
		}
	}
}