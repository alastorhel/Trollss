namespace Modelos
{

public class Cliente
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

     string Telefone;
    
    public void SetTelefone(string telefone)
    {
        this.Telefone = telefone;
    }
    public string GetTelefone()
    {
        return Telefone;
    }

      string email;
    
    public void Setemail(string email)
    {
        this.email = email;
    }
    public string Getemail()
    {
        return email;
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


    string endereço;
    
    public void Setendereço(string endereço)
    {
        this.endereço = endereço;
    }
    public string Getendereço()
    {
        return endereço;
    }
    
    string cpf;
    
    public void Setcpf(string cpf)
    {
        this.cpf = cpf;
    }
    public string Getcpf()
    {
        return cpf;
    }

  }
}