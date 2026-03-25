using System.ComponentModel.DataAnnotations;

namespace Classes_Herancas
{
    public class Televisao
    {
        private int _canalAtual;
        private int _volume;


        public Televisao() {
            CanalAtual = 1;
            Volume = 10;
        }
        public int CanalAtual
        {
            get => _canalAtual;
            private set => _canalAtual = value;
        }
        public int Volume
        {
            get => _volume;
            private set => _volume = value;
        }
        public void MudarCanal(int canal)
        {
            if (canal >= 1 && canal <= 100)
            {
                CanalAtual = canal;
                Console.WriteLine($"Canal alterado para: {CanalAtual}");
            }
            else
            {
                Console.WriteLine($"Não foi possível alterar para o canal {canal}");
            }
        }
        public void AumentarVolume()
        {
            //AlterarVolume(volume);
            if (Volume <= 100)
            { 
                Volume++;
                Console.WriteLine($"Volume: {Volume}");
            }
            else 
            { 
            Console.WriteLine("Volume máximo atingido");
            }
        }
        public void ReduzirVolume()
        {
            //AlterarVolume(volume);
            if (Volume <= 100)
            {
                Volume--;
                Console.WriteLine($"Volume: {Volume}");
            }
            else
            {
                Console.WriteLine("TV está no modo Mudo");
            }
        }
      /*  private void AlterarVolume(int volume) 
        {
            if (volume >= 0 && volume <= 100)
            {
                Volume = volume;
                Console.WriteLine($"Volume alterado para: {Volume}");
            }
            else if (volume >= 100)
            {
                Console.WriteLine($"Você já atingiu volume máximo {Volume}");
            }
            else if (volume < 0)
            {
                Console.WriteLine($"TV já está no Mudo");
            }
            else
            {
                Console.WriteLine($"Não foi possível alterar para o volume: {volume}\nLimite está entre 0 e 100.");
            }
        }
      */
    }
}
/* 09-Televisão Inteligente
Crie uma classe Televisao com atributos canalAtual e volume, aplicando o encapsulamento.
•	Crie um construtor que inicie a TV no canal 1 e volume 10.
•	Crie métodos para MudarCanal (validando para que o canal esteja sempre entre 1 e 100).
•	Crie métodos públicos para AumentarVolume e DiminuirVolume (impedindo que o volume passe de 100 ou fique abaixo de 0).
*/