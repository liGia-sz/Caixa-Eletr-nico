using System;
using System.Collections.Generic;					
public class Program
{
	public static void Main()
	{
		decimal saldo = 10000.00m; // Saldo do usuário
		
		List<string> extrato = new List<string>(); //Lista para armazenar histórico de operações do usuário
		while(true)
		{   // Menu Principal
			Console.WriteLine("CAIXA ELETRÔNICO");
			Console.WriteLine("Escolha uma operação abaixo:");
			Console.WriteLine(" 1. Verificar saldo\n 2. Depósito\n 3. Saque\n 4. Extrato\n 5. Transferência\n 6. Sair");
			int.TryParse(Console.ReadLine(), out int opcao); 
			
			switch (opcao)
			{
				case 1:
					// Saldo
					Console.WriteLine($"Seu saldo é de: {saldo:C}");
				break;
				case 2:
					// Depósito
					Console.Write("Digite o valor de seu depósito:");
					decimal deposito = decimal.Parse(Console.ReadLine());
					saldo += deposito;
					extrato.Add($"Depósito; {deposito:C}");
					Console.WriteLine("Deposito feito com sucesso!");
				break;
				case 3:
					// Saque
					Console.Write("Digite o valor do saque: ");
					decimal valorSaque = decimal.Parse(Console.ReadLine());
					if (valorSaque <= saldo) 
                {
                    saldo -= valorSaque;
                    extrato.Add($"Saque: {valorSaque:C}");
                    Console.WriteLine("Saque realizado com sucesso!");
                }
                else
                    Console.WriteLine("Saldo insuficiente!"); // caso o saldo seja insuficiente
				break;
				case 4:
				// Extrato
                Console.WriteLine("SEU EXTRATO:");
                foreach (var transacao in extrato)
                {
                    Console.WriteLine(transacao);
					Console.WriteLine();
                }
				break;
				case 5:
					// Transferência
					Console.Write("Digite o valor da transferência: ");
					decimal valorTransferencia = decimal.Parse(Console.ReadLine());
					if (valorTransferencia <= saldo)
					{
						saldo -= valorTransferencia;
						extrato.Add($"Transferência: {valorTransferencia:C}");
						Console.WriteLine("Transferência realizada com sucesso!");
					}
					else
					{
						Console.WriteLine("Saldo insuficiente!");
					}
				break;
				case 6:
					// Sair
                	return;
			}
		} 
		
		
		
		
	}
}


