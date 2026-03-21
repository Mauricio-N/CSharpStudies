namespace Classes_Herancas
{
    public class ContaBancaria
    {
        public string Titular { get; private set; }
        private decimal _saldo;// { get; set; } = 0;
        private Dictionary<DateTime,decimal> HistoricoDeSaques;
        private Dictionary<DateTime, decimal> HistoricoDeDEpositos;
        static ContaBancaria()
        {
            Console.WriteLine("Sistema bancário foi ativado!");
        }
        public ContaBancaria(string titular)
        {
            this.Titular = titular;
            this._saldo = 0;
            this.HistoricoDeSaques = new();
            this.HistoricoDeDEpositos = new();
        }
        public decimal Saldo
        {
            get => _saldo;
            set => _saldo = value >= 0 ? value : throw new ArgumentException("Valor invalido");
        }
        public bool Sacar()
        {
            Console.Write("Digite Valor para saque: ");
            string? entrada = Console.ReadLine() ?? "";
            decimal historyOfSaldo = Saldo;
            while (true)
            {
                if (!decimal.TryParse(entrada, out decimal saque) || entrada == null)
                {
                    if (entrada.ToLower().Equals("n"))
                    {
                        if (Saldo != historyOfSaldo)
                        {
                            Console.WriteLine("Sistema bancário desativado!");
                            return true;
                        }
                        else
                        {
                            Console.WriteLine("Sistema bancário desativado!");
                            return false;
                        }
                    }
                    Console.WriteLine($"***********************\n*** Valor inválido! ***\n***********************");
                    Console.Write($"Digite somente somente valores númericos e maior que zero.\nResposta: ");
                    entrada = Console.ReadLine() ?? "";
                }
                else
                {
                    if (saque > 0 && saque <= Saldo)
                    {
                        HistoricoDeSaques.Add(DateTime.UtcNow,saque);
                        Saldo -= saque;
                        Console.WriteLine($"***********************************\n*** Saque efetuado com sucesso! ***\n***********************************");
                        Console.WriteLine($"Saldo atual: {Saldo:C2}");
                        Console.Write("Deseja sacar um novo valor? \n[s] para sim\n[n] para não\nResposta: ");
                        while (true)
                        {
                            string choose = Console.ReadLine()?.ToLower() ?? "";
                            if (choose.Equals("n"))
                            {
                                return Saldo != historyOfSaldo;
                            }
                            else if (choose.Equals("s"))
                            {
                                Console.Write("Digite somente somente valores númericos e maior que zero: ");
                                entrada = Console.ReadLine() ?? "";
                                break;
                            }
                            else
                            {
                                Console.Write("Digite somente [s] para sim e [n] para não:\nResposta: ");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"***************************\n*** Saque não efetuado! ***\n***************************");
                        Console.Write($"Saldo atual: {Saldo:C2}\nDigite o valor para saque ou [n] para finalizar a transação: ");
                        entrada = Console.ReadLine() ?? "";
                    }
                }
            }
        }
        public bool Depositar()
        {
            while (true)
            {
                Console.Write("Digite o valor a ser depositado: ");
                string? entrada = Console.ReadLine()?.ToLower() ?? "";
                if (!decimal.TryParse(entrada, out decimal valor) || entrada == null)
                {
                    Console.WriteLine("***************************\n* Deposito não realizado! *\n***************************\nValor inválido!");
                }
                else
                {
                    if (valor > 0)
                    {
                        Console.WriteLine("***********************************\n* Deposito realizado com sucesso! *\n***********************************");
                        HistoricoDeDEpositos.Add(DateTime.UtcNow,valor);
                        Saldo += valor;
                        Console.WriteLine($"Saldo: {Saldo:C2}\nDeseja realizar um novo deposito?");
                        Console.Write("Digite somente [s] para sim e [n] para não:\nResposta: ");
                        if (CheckForLeave(Console.ReadLine() ?? "")) return false;
                    }
                }
            }
        }
        public override string ToString()
        {
            return $@"Titular: {Titular}
Saldo: {Saldo:C2}
{string.Join("\n", HistoricoDeSaques.Select(ele => $"Valores sacados: {ele}"))}
{string.Join("\n", HistoricoDeDEpositos.Select(ele => $"Valores depositados: {ele}"))}";
        }
        static bool CheckForLeave(string entrada)
        {
            while (true)
            {
                if (entrada.ToLower().Equals("n"))
                {
                    Console.WriteLine("Sistema bancário desativado!");
                    return true;
                }
                else if (entrada.ToLower().Equals("s"))
                {
                    return false;
                }
                else
                {
                    Console.Write("Digite somente [s] para sim e [n] para não:\nResposta: ");
                    entrada = Console.ReadLine()?.ToLower() ?? "";
                }
            }
        }
    }//Fim Classe
}//Fim namespace