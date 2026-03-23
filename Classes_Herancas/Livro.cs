namespace Classes_Herancas
{
    public class Livro
    {
        private string _autor;
        private string _titulo;
        private bool _disponivel;

        public Livro(string autor,string titulo)
        {
            Autor = autor;
            Titulo = titulo;
            Disponivel = true;
        }
        public string Autor
        {
            get => _autor;
            set => _autor = !string.IsNullOrWhiteSpace(value) ?
             value:throw new ArgumentException("Entrada inválida",nameof(Autor));
        }
        public string Titulo
        {
            get => _titulo;
            set => _titulo = !string.IsNullOrWhiteSpace(value) ?
                value : throw new ArgumentException("Entrada inválida",nameof(Titulo));
        }
        public bool Disponivel
        {
            get => _disponivel;
            set => _disponivel = value;
        }
        //Crie métodos chamados Emprestar e Devolver.
        public void Emprestar(string titulo)
        {
            if (string.IsNullOrWhiteSpace(titulo))
            {
                Console.WriteLine("Entrada inválida!");
            }
            else
            {
                if (titulo.Equals(Titulo) && Disponivel)
                {
                    Console.WriteLine($"Você pegou o livro {Titulo} emprestado!");
                    Disponivel = !Disponivel;
                }
                else
                {
                    Console.WriteLine($"O Livro {Titulo} está temporariamente indisponível!");
                }
            }
        }
        public void Devolver(string titulo)
        {
            if (string.IsNullOrWhiteSpace(titulo))
            {
                Console.WriteLine("Entrada inválida!");
            }
            else
            {
                if (titulo.Equals(Titulo) && Disponivel)
                {
                    Console.WriteLine($"Livro: {Titulo}, já foi devolvido!");
                    
                }
                else if (titulo.Equals(Titulo) && !Disponivel)
                {
                    Console.WriteLine($"Obrigado por devolver o Livro: {Titulo}.");
                    Disponivel = !Disponivel;
                }
                else
                {
                    Console.WriteLine("Não foi possível devolver, Nome inválido!");
                }
            }
        }
        protected string Disponibilidade()
        {
            return Disponivel ? "Disponível":"Indisponível";
        }
        public override string ToString()
        {
            return $@"Titulo: {Titulo}
Autor: {Autor}
Disponivilidade: {Disponibilidade()}";
        }
    }
}
/* 6. Livro da Biblioteca
Crie uma classe Livro com atributos titulo, autor e disponivel (booleano), aplicando o encapsulamento.
•	O construtor deve receber título e autor, e definir o atributo disponivel como verdadeiro.
•	Crie métodos chamados Emprestar e Devolver. O método emprestar só deve alterar o estado do livro se ele estiver atualmente disponível.
*/