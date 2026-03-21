namespace Classes_Herancas
{
    internal class Pessoa
    {
        // Campo estático simples — mutável dentro da classe
        private static uint _contadorGeral;
        // Propriedades públicas com setter privado — encapsulamento correto
        public uint UserID { get; private set; } //= 0;
        public string Nome { get; private set; }
        private ushort _idade;
        public const double TAXA_IVA = 0.23;
        static Pessoa()
        {
            Console.WriteLine("Classe Pessoa inicializada.");
        }

        public Pessoa(string nome, ushort idade)
        {
            _contadorGeral++;
            UserID = _contadorGeral;
            Nome = nome;
            Idade = idade;
            //_idade = idade;
        }
        public ushort Idade
        {
            get => _idade;
            set => _idade = value <= 0 || value > 150
    ? throw new ArgumentException("Idade inválida.")
    : value;
        }
   
        public void teste()
        {
            if (UserID > 10) { 
                Console.WriteLine("User Antigo");
            Console.WriteLine("User Novo");
            }
            else
            {

            }
        }
         
        public override string ToString()
            => $"Nome: {Nome}\nIdade: {Idade}\nUserID: {UserID}";
    }
}