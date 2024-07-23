namespace Modelos
{



public class Envioparacostura{


    string costureira;

     public void Setcostureira(string costureira)
    {
        this.costureira = costureira;
    }
    public string Getcostureira()
    {
        return costureira;
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