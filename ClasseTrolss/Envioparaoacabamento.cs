namespace Modelos
{



public class Envioparaoacabamento{

     string nome;
    Int64 id;

    public void SetNome(string nome)
    {
        this.nome = nome;
    }
    public string GetNome()
    {
        return nome;
    }

    int indetificaçãodoproduto;

     
      public void Setindetificaçãodoproduto(int indetificaçãodoproduto)
    {
        this.indetificaçãodoproduto = indetificaçãodoproduto;
    }
    public int Getindetificaçãodoproduto()
    {
        return indetificaçãodoproduto;
    }

    int quantidade;

      public void Setquantidade(int quantidade)
    {
        this.quantidade = quantidade;
    }
    public int Getquantidade()
    {
        return quantidade;
    }
  }
}