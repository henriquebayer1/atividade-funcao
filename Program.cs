// 1 - Ler o ano atual e o ano de nascimento de uma pessoa. Escrever uma mensagem que diga se
// ela poderá ou não votar este ano (não é necessário considerar o mês em que a pessoa nasceu).

// static string Votacao(int atualdate, int birthDate)
// {
//    int calcVoto =  (atualdate - birthDate);

// if (calcVoto <= 18)
//     {return $"Nao pode votar";
//     }
//     else{ return $"Pode votar";
//     }
// }



// int atualdate = DateTime.Now.Year;

// Console.WriteLine($"Escreva seu ano de nascimento:");
// int birthDate = int.Parse(Console.ReadLine());

// string podeVotar = Votacao(atualdate, birthDate);

// Console.WriteLine($"Voce {podeVotar}");



// 2 - Um posto está vendendo combustíveis com a seguinte tabela de descontos:
// Álcool:
// . até 20 litros, desconto de 3% por litro Álcool
// . acima de 20 litros, desconto de 5% por litro
// Gasolina:
// . até 20 litros, desconto de 4% por litro Gasolina
// . acima de 20 litros, desconto de 6% por litro

// Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível (codificado
// da seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente
// sabendo-se que o preço do litro da gasolina é R$ 5,30 e o preço do litro do álcool é R$ 4,90.
// Dica: utilize switch case e funções/métodos para otimizar o algorítimo.


static float combustivelCalc()
{

    Console.WriteLine($"Digite qual das opcoes de combustivel voce quer: 1 - Gasolina ou 2 - Alcool.");
    int escolhaCombustivel = int.Parse(Console.ReadLine());

    Console.WriteLine($"Agora digite a quantidade em Litros a ser colocada no tanque:");
    int quantidadeCombustivel = int.Parse(Console.ReadLine());

    float descontoPorLitroGasolina = 0;
    float descontoPorLitroAlcool = 0;
    float valorFinalCombustivel = 0;
    float valorgasolina = 5.30f;
    float valoralcool = 4.90f;

    switch (escolhaCombustivel)
    {
        case 1:
            if (quantidadeCombustivel < 20)
            {
                descontoPorLitroGasolina = ((quantidadeCombustivel / 100) * 6);
                valorFinalCombustivel = descontoPorLitroGasolina * quantidadeCombustivel;
            }
            else
            {
                descontoPorLitroGasolina = ((quantidadeCombustivel / 100) * 4);
                valorFinalCombustivel = descontoPorLitroGasolina * quantidadeCombustivel;
            }
            break;
        case 2:
            if (quantidadeCombustivel < 20)
            {
                descontoPorLitroAlcool = ((quantidadeCombustivel / 100) * 5);
                valorFinalCombustivel = descontoPorLitroAlcool * quantidadeCombustivel;
            }
            else
            {
                descontoPorLitroAlcool = ((quantidadeCombustivel / 100) * 3);
                valorFinalCombustivel = valoralcool * quantidadeCombustivel;
            }
            break;
        default:
            Console.WriteLine($"Escolha corretamente uma das opcoes, volte ao inicio do sistema e tente novamente.");
            break;
    }

    return 0;
}





