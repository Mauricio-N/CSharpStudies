namespace PraticandoConceitos;
  class Dicionario
  {
    public Dictionary<int,string> familia = new()
    {
      {1,"Mauricio"},
      {2,"Mariana"}
    };
    public void tryAddFamilia(int id,string nome)
    {
    familia.TryAdd(id,nome);
    }
    public void showFamilia()
  {
    Console.WriteLine(string.Join(", ",familia));
  }
  }
