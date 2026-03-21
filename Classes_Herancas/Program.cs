using System.Security.Cryptography;

namespace Classes_Herancas;
public class Program
{
    public static void Main()
    {

        ContaBancaria c1 = new(titular: "Arthur");
        bool OnOFF = true;
        while (OnOFF) { 
            Console.WriteLine($@"
Digite 1 para sacar
Digite 2 para depositar
Digite 3 para transações bancárias
Digite 0 para sair");
            Console.Write("Resposta: ");
            switch (Console.ReadLine() ?? "")
            {
                case "1":
                    c1.Sacar();
                break;
            
                case "2":
                    c1.Depositar();
                break;
                case "3":
                    Console.WriteLine(c1.ToString());
                    break;
                case "0":
                    OnOFF = false;
                    break;
                default:
                    Console.WriteLine("Entrada invalida!");
                 break;
            }
        }
        Console.WriteLine("Sistema bancário desativado!");
    }
}