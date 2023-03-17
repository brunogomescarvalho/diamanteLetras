/**/
Console.WriteLine("Escolha a letra central do diamante:");
var letraEscolhida = Convert.ToChar(Console.ReadLine()!);

var alfabeto = "ABCDEFGHJKLMNOPQRSTUVXWYZ";

#region recebe posicao da letra escolhida no array alfabeto

var posicaoLetra = 0;

for (int i = 0; i < alfabeto.Length; i++)
{
    if (alfabeto[i] == letraEscolhida)
    {
        posicaoLetra = i;
    }
}

#endregion

//recebe espaços em branco
var espacosEmBranco = posicaoLetra;
var caracteresPorLinha = 0;

// calcula tamanho da linha
var tamanhoLinha = posicaoLetra * 2 + 1;

#region escreve o primeiro triangulo

for (int i = 0; i < posicaoLetra; i++)
{
    for (int l = 0; l < espacosEmBranco; l++)
    {
        Console.Write(" ");
    }

    for (int j = 0; j <= caracteresPorLinha; j++)
    {
        if (j == 0 || j == caracteresPorLinha - 1)
        {
            Console.Write(alfabeto[i]);
        }
        Console.Write(" ");
    }
    espacosEmBranco--;
    caracteresPorLinha += 2;
    Console.WriteLine();
}

#endregion

#region escreve a linha central

for (int j = 0; j <= tamanhoLinha - 2; j++)
{
    if (j == 0 || j == tamanhoLinha - 2)
    {
        Console.Write(letraEscolhida);
    }
    Console.Write(" ");
}
Console.WriteLine();

#endregion

#region escreve o segundo triangulo

espacosEmBranco = 0;
var letras = posicaoLetra;

for (int i = 0; i < letras; i++)
{

    for (int l = 0; l <= espacosEmBranco; l++)
    {
        Console.Write(" ");
    }

    for (int j = 0; j <= caracteresPorLinha; j++)
    {
        if (j == 0 || j == caracteresPorLinha - 3)
        {
            Console.Write(alfabeto[posicaoLetra - 1]);
        }
        Console.Write(" ");
    }
    espacosEmBranco++;
    posicaoLetra--;
    caracteresPorLinha -= 2;
    Console.WriteLine();
}
#endregion
