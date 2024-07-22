

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

     int Telefone;
    
    public void SetTelefone(int telefone)
    {
        this.Telefone = telefone;
    }
    public int GetTelefone()
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

      int cnpj;
    
    public void Setcnpj(int cnpj)
    {
        this.cnpj = cnpj;
    }
    public int Getcnpj()
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
    
    int cpf;
    
    public void Setcpf(int cpf)
    {
        this.cpf = cpf;
    }
    public int Getcpf()
    {
        return cpf;
    }


}