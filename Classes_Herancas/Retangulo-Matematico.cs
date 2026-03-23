namespace Classes_Herancas
{
    public class Retangulo_Matematico
    {
        private float _altura;
        private float _largura;

        public Retangulo_Matematico(float altura, float largura)
        {
            this.Altura = altura;
            this.Largura = largura;
        }
        public float Altura 
        {
            get => _altura;
            set =>_altura = value > 0 ? value: throw new ArgumentException("Número inválido") ;
        }
        public float Largura
        {
            get => _largura;
            set => _largura = value > 0 ? value : throw new ArgumentException("Número inválido");
        }

        public float CalcularArea()
        {
            return Altura * Largura;
        }
        public float CalcularPerimetro()
        {
            return  (2*Altura)+(2*Largura);
        }
        public string ShowCalculos()
        {
            return @$"Algura: {Altura}.
Largura: {Largura}.
Area do retangulo: {CalcularArea()}.
Perimetro do retangulo: {CalcularPerimetro()}.";
        }
       /* Método inacabado. Não consegui aplicar o conceito! 
        public void AlteraAtributo(Func<float> entrada, Action<float> destino)
        {
            bool validaTemp = float.TryParse(, out var alt);
            while (!validaTemp)
            {
                Console.Write("Entrada invalida!\nDigite novamente: ");
                validaTemp = float.TryParse(Console.ReadLine() ?? "", out alt);
            }
            destino(alt);
        }
       */
    }
}
/* 2. O Retângulo Matemático
Crie uma classe Retangulo com os atributos largura e altura, aplicando o encapsulamento. A = BXH/ P =2B +2H
•	Crie um construtor que receba os dois valores como parâmetros.
•	Crie métodos chamados CalcularArea e CalcularPerimetro que retornem os respectivos resultados matemáticos.
•	Crie os métodos de acesso necessários para permitir a leitura e a alteração da largura e altura depois que o objeto for criado de forma segura.
*/