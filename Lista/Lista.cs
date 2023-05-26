namespace Listas;

public struct Lista
{
    public No inicio;
    public No fim;

    public Lista()
    {
        this.inicio = null;
        this.fim = null;
    }

    public void inserirInicio(int valor)
    {
        No novoNo = new(valor);

        if(this.inicio == null && this.fim == null){
            this.inicio = novoNo;
            this.fim = novoNo;
        } else if(this.inicio != null){
            novoNo.noProx = this.inicio;
            this.inicio = novoNo; 
        }
    }
    public void percursso()
    {
        No noAux = this.inicio;

        while(noAux != null)
        {
            Console.Write(noAux.valor + " -> ");
            noAux = noAux.noProx;
        }
    }
    public bool consulta(int valor, ref No noAtual, ref No noAnterior)
    {
        noAtual = this.inicio;
        noAnterior = null;

        while(noAtual != null)
        {
            if(noAtual.valor == valor)
            {
                return true;
            }
            noAnterior = noAtual;
            noAtual = noAtual.noProx;
        }
        return false;
    }
}