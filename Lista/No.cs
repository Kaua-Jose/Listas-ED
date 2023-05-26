namespace Listas;

public class No
{
    public int valor;
    public No noProx;

    public No(int valor)
    {
        this.valor = valor;
        this.noProx = null;
    }

    public void imprimir()
    {
        Console.WriteLine("Valor: "+ this.valor);
    }
}