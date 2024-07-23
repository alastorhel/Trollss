namespace Modelos
{


public class ListadeClientes{

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

    string cnpj;


      public void Setcnpj(string cnpj)
    {
        this.cnpj = cnpj;
    }
    public string Getcnpj()
    {
        return cnpj;
    }


    int DatadeCadastro;

    public void SetDatadeCadastro(int DatadeCadastro)
    {
        this.DatadeCadastro = DatadeCadastro;
    }
    public int GetDatadeCadastro()
    {
        return DatadeCadastro;
    }

}
}