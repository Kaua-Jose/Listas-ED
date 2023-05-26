using Listas;

Lista lista = new();
lista.inserirInicio(7);
lista.inserirInicio(12);
lista.inserirInicio(22);
lista.percursso();

No noAtual = null;
No noAnterior = null;
Console.WriteLine(lista.consulta(4, ref noAtual, ref noAnterior) ? $"Encontrou o no de valor "+noAtual.valor : "No não encontrado");
