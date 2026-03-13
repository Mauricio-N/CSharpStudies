namespace PraticandoConceitos;

class Program
{
    public static void Main()
    {
        DataHora dias = new();
        dias.RetornaDias();
        Console.Write("Digite seu nome: ");
        string? name = Console.ReadLine();
        Console.Write("Digite seu sobrenome: ");
        string? lastName = Console.ReadLine();
        string fullName = $"{name} {lastName}";
        Console.WriteLine($"Olá, {fullName}! Seja muito bem-vindo!");
        Console.Write("Primeiro valor => ");
        double primeiroValor = ValidaEntradaDeValores();
        Console.Write("Segundo valor => ");
        double segundoValor = ValidaEntradaDeValores();
        Calculos(valor1: primeiroValor, valor2: segundoValor,fullName: fullName);
        Console.WriteLine("*ADICIONAR PLACA*");
        ValidaPlaca();
        
    }
    static double ValidaEntradaDeValores()
    {
        while (true)
        {
            Console.Write("Digite o valor desejado: ");
            string? temp = Console.ReadLine();
            if (double.TryParse(temp, out double saida))
            {
                Console.WriteLine($"Valor {saida:C} inserido com sucesso!");
                return saida;
            }
            else
            {
                Console.Write($"{temp} não é um valor Invalido!\nDigite um valor válido: ");
            }
        }
    }
    /*Outro jeito menos otimizado
    static double ValidaEntradaDeValores()
    {
        double saida = 0;
        bool validaSwitch = true;
        while (validaSwitch)
        {
            Console.Write("Digite o valor desejado: ");
            string? temp = Console.ReadLine();
            if (double.TryParse(temp, out saida))
            {

                Console.WriteLine($"Valor {saida:C} inserido com sucesso!");
                validaSwitch = !validaSwitch;
            }
            else
            {
                Console.Write($"{temp}, não é um valor Invalido!\nDigite um valor válido: ");
            }
        }
        return saida;
    }
 */
    static void Calculos(double valor1, double valor2, string fullName)
    {
        Console.WriteLine($"Seu nome tem: {fullName.Replace(" ", "").Length} letras.");
        Console.WriteLine($"-A soma entre esses dois números: {valor1 + valor2}");
        Console.WriteLine($"-A subtração entre os dois números: {valor1 - valor2} ");
        Console.WriteLine($"-A multiplicação entre os dois números: {valor1 * valor2} ");
        if (valor2 == 0)
        {
            Console.WriteLine("Não é possível dividir por zero");
        }
        else
        {
            Console.WriteLine($"-A divisão entre os dois números:{valor1 / valor2:f2} ");
        }
        Console.WriteLine($"-A média entre os dois números: {(valor1 + valor2) / 2}");
    }
    static bool ValidaPlaca()
    {

        Console.WriteLine(@"- A placa deve ter 7 caracteres alfanuméricos.
- Os três primeiros caracteres são letras(maiúsculas ou minúsculas).
- Os quatro últimos caracteres são números");

        while (true)
        {
            Console.Write("Digite o número da sua placa: ");
            string temp = Console.ReadLine()?.ToUpper() ?? "";
            if (temp.Length == 7)
            { 
                
                bool bLetras = true;
                bool bNumeros = true;
                for (int i = 0; i < 3; i++)
                {
                    if (!char.IsLetter(temp[i])) 
                    { 
                        bLetras = false;
                        break;
                    }
                }
                for (int i = 3; i < 7; i++)
                {
                    if (!char.IsDigit(temp[i]))
                    {
                        bNumeros = false;
                        break;
                    }
                }
                if (bLetras && bNumeros)
                {
                    string letras = temp.Substring(0, 3);
                    string numeros = temp.Substring(3);
                    Console.WriteLine($"A placa {letras}-{numeros} foi aprovada");
                    return true;
                }
                else
                {
                    Console.WriteLine($"A placa {temp} não foi aprovada");
                   // return false;
                }

            }
            else
            {
                Console.WriteLine("Não deve ultrapassar o limite estabelecido de 7 caracteres");
                //return false;
            } 
        }   
    }
}