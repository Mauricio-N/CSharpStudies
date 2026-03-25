namespace Classes_Herancas
{
    public class Personagem
    {
        public string Nome { get; private set; }
        public int Forca { get; private set; }
        private int _pontosDeVida;

        public Personagem(string nome,int forca)
        {
            this.Nome = nome;
            this.Forca = forca;
            this.PontosDeVida = 100;
        }
        public int PontosDeVida
        {
            get => _pontosDeVida;
            set
            {
                if (value > 100) _pontosDeVida = 100;
                else if (value < 0) _pontosDeVida = 0;
                else _pontosDeVida = value;
            }
        }

        public void ReceberDano(int dano)
        {
            if (dano <= 0) { Console.WriteLine("O dano deve ser positivo."); return; }
            //PontosDeVida -= Math.Abs(dano);
            Console.WriteLine($"Jogador recebeu {dano} pontos de dano!");
            PontosDeVida -= dano;
            if (PontosDeVida == 0)
            {
                Console.WriteLine("Jogador morreu!");
            }
            else
            {
                Console.WriteLine($"Jogador com {PontosDeVida} pontos de vida.");
            }
        }
        public void Curar(int cura)
        {
            if (cura <= 0) { Console.WriteLine("A cura deve ser positiva."); return; };
            //PontosDeVida += Math.Abs(cura);
            Console.WriteLine($"Jogador recebeu {cura} pontos de cura!");
            PontosDeVida += cura;
            if (PontosDeVida == 100)
            {
                Console.WriteLine("Pronto pra batalha!");
            }
            else
            {
                Console.WriteLine($"Jogador com {PontosDeVida} pontos de vida.");
            }
        }
    }
}
/* 10. Personagem 
Crie uma classe Personagem com os atributos nome, pontosDeVida e forca, aplicando o encapsulamento.
•	O construtor deve receber o nome e a força do personagem. Os pontosDeVida devem começar em 100.
•	Crie métodos: ReceberDano e Curar (adiciona à vida).
•	A regra de segurança dos dados exige que a vida do personagem não ultrapasse o limite máximo de 100 e não caia para menos de 0.
*/