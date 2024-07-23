namespace Modelos
{

public class ControledeEstoque{

    int CodígodoProduto;

   
    public void SetCodígodoProduto(int CodígodoProduto)
    {
        this.CodígodoProduto = CodígodoProduto;
    }
    public int GetCodígodoProduto()
    {
        return CodígodoProduto;
    }

    string categoria;

     public void Setcategoria(string categoria)
    {
        this.categoria = categoria;
    }
    public string Getcategoria()
    {
        return categoria;
    }

    int QuantidadeTotal;

     public void SetQuantidadeTotal(int QuantidadeTotal)
    {
        this.QuantidadeTotal = QuantidadeTotal;
    }
    public int GetQuantidadeTotal()
    {
        return QuantidadeTotal;
    }

    int Tempodaentradanoestoque;

     public void SetTempodaentradanoestoque(int Tempodaentradanoestoque)
    {
        this.Tempodaentradanoestoque = Tempodaentradanoestoque;
    }
    public int GetTempodaentradanoestoque()
    {
        return Tempodaentradanoestoque;
    }

     int Quantidadeatualnoestoque;

      public void SetQuantidadeatualnoestoque(int Quantidadeatualnoestoque)
    {
        this.Quantidadeatualnoestoque = Quantidadeatualnoestoque;
    }
    public int GetQuantidadeatualnoestoque()
    {
        return Quantidadeatualnoestoque;
    }

}
}