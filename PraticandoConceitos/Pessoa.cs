namespace PraticandoConceitos
{
    public class Pessoa
    {
        private int _id { get; }
        private string _nome;
        private int _idade;
        public string email {  get; set; }

        public Pessoa(string nome,int idade)
        {
            _id++;
            _nome = nome;
            _idade = idade;
        }

        public string Nome
        {
            get { return _nome; }
            set { value = _nome; }
        }
        public int Idade { get => _idade; set => value = _idade; }

        public override string ToString()
        {
            return $@"ID: {_id}
Nome: {_nome}
Idade: {_idade}";
        }
    }
   
}
