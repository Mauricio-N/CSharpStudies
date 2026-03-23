namespace Classes_Herancas
{
    public class Carro
    {
        private string? _modelo;
        private string? _marca;
        private float _velocidadeAtual;

        public Carro(string modelo, string marca)
        {
            Modelo = modelo;
            Marca = marca;
            VelocidateAtual = 0;
        }
        public string Modelo
        {
            get=>_modelo ?? "";
            set=>_modelo = !string.IsNullOrWhiteSpace(value)? value: throw new ArgumentException("Modelo invalido!", nameof(Modelo));
          /*
          ** NOTA DE APRENDIZADO **
          * Antes de atribuir o valor a _modelo, é feita uma validação.
          * string.IsNullOrWhiteSpace(value) verifica se o valor é:
          * - null
          * - vazio
          * - apenas espaços
          *
          * O operador (!) inverte o resultado da verificação.
          *
          * Se o valor for válido → ele é atribuído a _modelo.
          * Se for inválido → é lançada uma ArgumentException.
          *
          * nameof(Modelo) retorna o nome da propriedade que causou o erro.
          */
        }
        public string Marca
        {
            get => _marca ?? "";
            set => _marca = value;
        }
        public float VelocidateAtual
        {
            get => _velocidadeAtual;
            set => _velocidadeAtual = value;
        }

        public void Acelerar()
        {
            VelocidateAtual += 10;
            Console.WriteLine($"{Modelo} acelerou e está a {VelocidateAtual}km/h");
        }
        public void Frear()
        {
            if ((VelocidateAtual - 10) <= 0)
            {
                Console.WriteLine($"{Modelo} está parada a {VelocidateAtual} km/h");       
            }
            else
            {
                VelocidateAtual -= 10;
                Console.WriteLine($"{Modelo} reduziu e está a {VelocidateAtual} km/h");
            }
        }
    }
}
/*5-O Carro Acelerado
Construa uma classe Carro com os atributos modelo, marca e velocidadeAtual, aplicando o encapsulamento.
•	O construtor deve receber modelo e marca, e a velocidade inicial deve ser 0.
•	Crie métodos Acelerar (aumenta a velocidade em 10) e Frear (diminui a velocidade em 10).
•	A regra de negócio principal é garantir que a VelocidadeAtual nunca fique com um valor negativo ao frear.

 */
