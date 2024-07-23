namespace Modelos
{

public class Cadastrodocortador
{
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

     int Telefone;
    
    public void SetTelefone(int telefone)
    {
        this.Telefone = telefone;
    }
    public int GetTelefone()
    {
        return Telefone;
    }
   }
}