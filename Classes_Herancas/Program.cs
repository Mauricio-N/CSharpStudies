using System.Security.Cryptography;

namespace Classes_Herancas;
public class Program
{
    public static void Main()
    {
        string entrada;
/* 01-ContaBancaria
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
*/
/*02-Retângulo Matemático
        string entrada;
        Retangulo_Matematico nCalc = new(altura: 10, largura: 3);
        Console.WriteLine(nCalc.ShowCalculos());
        Console.Write("Alterando Altura: ");
        entrada = Console.ReadLine()??"";
        nCalc.Altura = 11;
        Console.Write("Alterando Largura: ");
        entrada = Console.ReadLine() ?? "";
        nCalc.Largura = 12;
        Console.WriteLine(nCalc.ShowCalculos());
*/
/*03-Aluno e suas notas
        Aluno aluno1 = new("Arthur");
        try
        {
            Console.Write("Digite a Primeira nota: ");
            aluno1.Nota1 = Convert.ToUInt32(Console.ReadLine());
            Console.Write("Digite a Segunda nota: ");
            aluno1.Nota2 = Convert.ToUInt32(Console.ReadLine());
        }
        catch(Exception msg) { Console.WriteLine(msg.Message); }

        Console.WriteLine($@"Primeira Nota: {aluno1.Nota1:F1}.
        Segunda Nota: {aluno1.Nota2:F1}
        Média das provas: {aluno1.CalcularMedia():F1}");
*/
/*04-Controle de Estoque
    Produto pp = new(nome:"Casquinha",preco:10);
    Console.Write($"Adicione quantidade de {pp.Nome} em estoque: ");
    pp.AdicionarEstoque(Console.ReadLine()??"");
    Console.Write($"Adicione quantidade de {pp.Nome} vendida: ");
    pp.vender(Console.ReadLine() ?? "");
    Console.WriteLine("**************************************\n" + pp.ToString()+ "\n**************************************");
*/ 
    
    
    
    
    }


}