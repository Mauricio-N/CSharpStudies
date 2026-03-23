namespace Classes_Herancas
{
    public class Funcionario
    {
        private string? _nome;
        private string? _cargo;
        private decimal _salario;

        public Funcionario(string nome,string cargo,decimal salario)
        {
            Nome = nome;
            Cargo = cargo;
            Salario = salario;
        }
        public string Nome 
        {
            get => _nome ?? "";
            set => _nome = string.IsNullOrWhiteSpace(value)? throw new ArgumentException($"Não é possivel adicionar: {value}",nameof(Nome)) : value ;
        }
        public string Cargo 
        {   get => _cargo ?? "";
            set => _cargo = string.IsNullOrWhiteSpace(value) ? throw new ArgumentException($"Não é possivel adicionar: {value}", nameof(Cargo)) : value;
        }
        public decimal Salario {
            get => _salario;
           private set => _salario = value <= 0 ? throw new ArgumentException($"Não existe mais escravidão! Valor: {value} Inválido ", nameof(Salario)) : value;

        }
    }
}
/*
 7. Aumento de Salário
Implemente uma classe Funcionario com os atributos nome, cargo e salario, aplicando o encapsulamento.
•	Crie um construtor para inicializar todos esses atributos.
•	Crie um método AplicarAumento. Este método deve calcular o aumento baseado na porcentagem informada por parâmetro e atualizar o salário internamente.
•	A proteção dos dados aqui é vital: nenhum código externo deve ser capaz de alterar o salário diretamente, a não ser usando o método de aplicar aumento.
*/
