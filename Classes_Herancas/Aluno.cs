namespace Classes_Herancas
{
    public class Aluno
    {
        public string Nome {  get; private set; }
        private float _nota1;
        private float _nota2;
        public Aluno(string nome) {
         Nome = nome;
         Nota1 = 0;
         Nota2 = 0;
        }
        public float Nota1
        {  
            get => _nota1;
            set => _nota1 = value >= 0 && value <= 10 ? value : throw new ArgumentException("Nota inválida");
        }
        public float Nota2
        {
            get => _nota2;
            set => _nota2 = value >= 0 && value <= 10 ? value : throw new ArgumentException("Nota inválida");
        }
        public float CalcularMedia() => (Nota1+Nota2)/2;
    }
}

/* 3. O Aluno e suas Notas
Crie uma classe Aluno com os atributos nome, nota1 e nota2, aplicando o encapsulamento.
•	O construtor deve receber apenas o nome do aluno. As notas devem iniciar zeradas.
•	Crie métodos para atribuir valores às notas, garantindo que nenhuma nota inserida seja menor que 0 ou maior que 10.
•	Crie um método chamado CalcularMedia que retorne a média das duas notas.
*/
