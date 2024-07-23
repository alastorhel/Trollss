namespace Modelos
{

public class CadastroMatériaPrima
{

    string nomedamatériaprima;
    Int64 id;

    public void Setnomedamatériaprima(string nomedamatériaprima)
    {
        this.nomedamatériaprima = nomedamatériaprima;
    }
    public string Getnomedamatériaprima()
    {
        return nomedamatériaprima;
    }

    int unidadedemedida;

     public void Setunidadedemedida(int unidadedemedida)
    {
        this.unidadedemedida = unidadedemedida;
    }
    public int Getunidadedemedida()
    {
        return unidadedemedida;
    }

   }
}