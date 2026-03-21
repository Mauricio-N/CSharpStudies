using System.Drawing;

namespace Classes_Herancas
{
    public class Produto
    {
        private string? _nome;
        private decimal _preco;
        private uint _quantidadeEmEstoque;
        public Produto(string nome, decimal preco)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.QuantidadeEmEstoque = 0;
        }
        public string Nome { get => _nome??""; set => _nome = value; }
        public decimal Preco { get => _preco; set => _preco = value; }
        public uint QuantidadeEmEstoque { get => _quantidadeEmEstoque; set => _quantidadeEmEstoque = value; }

        public void AdicionarEstoque(string valor)
        {
            if (!uint.TryParse(valor, out var entrada))
            {
                Console.WriteLine("Valor invalido!");
            }
            else
            {
                QuantidadeEmEstoque += entrada;
            }
        }
        public void vender(string valor) 
        {
            if (!uint.TryParse(valor, out var saida))
            {
                Console.WriteLine("Valor invalido!");
            }
            else if (QuantidadeEmEstoque < saida)
            {
                Console.WriteLine($"Sem quantidade de {Nome} em estoque para venda!");
            }
            else
            {
                Console.WriteLine($"Venda realizada com sucesso\nQuantidade em estoque: {QuantidadeEmEstoque}");
                QuantidadeEmEstoque -= saida;
            }

        }
        public override string ToString()
        {
            return $"Nome: {Nome}\nPreco: {Preco}\nQuantidade em estoque: {QuantidadeEmEstoque}";
        }
    }
}
/*4-Controle de Estoque
Crie uma classe Produto com atributos para nome, preco e quantidadeEmEstoque, aplicando o encapsulamento.
•	O construtor deve receber o nome e o preco, iniciando a quantidade em estoque em zero.
•	Crie os métodos: AdicionarEstoque e Vender.
•	A venda só pode ser concluída se houver produtos suficientes no estoque, caso contrário, a operação deve ser cancelada.
*/
