 namespace Modelos
 {
 
 
 public class Envioparaocorte{

    string cortadora;

     public void Setcortadora(string cortadora)
    {
        this.cortadora = cortadora;
    }
    public string Getcortadora()
    {
        return cortadora;
    }

    string matériaprima;

    public void Setmatériaprima(string matériaprima)
    {
        this.matériaprima = matériaprima;
    }
    public string Getmatériaprima()
    {
        return matériaprima;
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