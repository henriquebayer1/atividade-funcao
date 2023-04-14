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


// static float combustivelCalc()
// {

//     Console.WriteLine($"Digite qual das opcoes de combustivel voce quer: 1 - Gasolina ou 2 - Alcool.");
//     int escolhaCombustivel = int.Parse(Console.ReadLine());

//     Console.WriteLine($"Agora digite a quantidade em Litros a ser colocada no tanque:");
//     int quantidadeCombustivel = int.Parse(Console.ReadLine());

//     float descontoPorLitroGasolinamenor20 = 0.3f;
//     float descontoPorLitroGasolinamaior20 = 0.6f;
//     float descontoPorLitroAlcoolmenor20 = 0.3f;
//     float descontoPorLitroAlcoolmaior20 = 0.5f;
//     float valorFinalCombustivel = 0;
//     float valorgasolina = 5.30f;
//     float valoralcool = 4.90f;

//     switch (escolhaCombustivel)
//     {
//         case 1:
//             if (quantidadeCombustivel <= 20)
//             {
//                 valorFinalCombustivel = (valorgasolina * descontoPorLitroGasolinamenor20) * quantidadeCombustivel;
//                 Console.WriteLine($"o valor final da gasolina e {valorFinalCombustivel}");
                
//             }
//             else
//             {
//                 valorFinalCombustivel = (valorgasolina * descontoPorLitroGasolinamaior20) * quantidadeCombustivel;
//                 Console.WriteLine($"o valor final da gasolina e {valorFinalCombustivel}");
//             }
//             break;
//         case 2:
//             if (quantidadeCombustivel <= 20)
//             {
//                 valorFinalCombustivel = (valoralcool * descontoPorLitroAlcoolmenor20) * quantidadeCombustivel;
//                 Console.WriteLine($"o valor final do alcool e {valorFinalCombustivel}");
//             }
//             else
//             {
//                 valorFinalCombustivel = (valoralcool * descontoPorLitroAlcoolmaior20) * quantidadeCombustivel;
//             }Console.WriteLine($"o valor final do alcool e {valorFinalCombustivel}");
//             break;
//         default:
//             Console.WriteLine($"Escolha corretamente uma das opcoes, volte ao inicio do sistema e tente novamente.");
//             break;
//     }

//     return valorFinalCombustivel;
// }

// combustivelCalc();


// 3 - Faça um algoritmo para ler: a descrição do produto (nome), a quantidade adquirida e o
// preço unitário. Calcular e escrever o total (total = quantidade adquirida * preço unitário), o
// desconto e o total a pagar (total a pagar = total - desconto), sabendo-se que:
// - Se quantidade &lt;= 5 o desconto será de 2%
// - Se quantidade &gt; 5 e quantidade &lt;=10 o desconto será de 3%
// - Se quantidade &gt; 10 o desconto será de 5%
// Dica: utilize if / else if / else


// static void produtoAlgoritimo(string nomeDoProduto, int quantidadeadq, float preçoDoProduto)
// {


// float valorTotal = quantidadeadq * preçoDoProduto;

// if(quantidadeadq <= 5)
// {
//     float totalPagamento = valorTotal - ((preçoDoProduto * 0.2f) * quantidadeadq);
// Console.WriteLine($"O valor final de sua compra do produto {nomeDoProduto} e de {totalPagamento}");
// }
// else if (quantidadeadq > 5 && quantidadeadq <= 10)
// {
//     float totalPagamento = valorTotal -(preçoDoProduto * 0.3f * quantidadeadq);
// Console.WriteLine($"O valor final de sua compra do produto {nomeDoProduto} e de {totalPagamento}");
// }
// else {float totalPagamento = valorTotal - (preçoDoProduto * 0.5f * quantidadeadq);
// Console.WriteLine($"O valor final de sua compra do produto {nomeDoProduto} e de {totalPagamento}");}
// }

// Console.WriteLine($"Digite o nome do produto que voce esta comprando:");
// string nomeDoProduto = Console.ReadLine();


// Console.WriteLine($"Agora digite a quantidade que voce esta comprando (unidade):");
// int quantidadeadq = int.Parse(Console.ReadLine());

// Console.WriteLine($"Agora digite o preco do produto (unidade):");
// float preçoDoProduto = float.Parse(Console.ReadLine());

// produtoAlgoritimo(nomeDoProduto, quantidadeadq, preçoDoProduto);



// 4 - Faça um programa que leia 10 valores digitados pelo usuário e no final, escreva o maior e o
// menor valor lido.

// static void algoritimoLerNumeros()
// {
// int [] valor = new int [10];

// Console.WriteLine($"Digite um valor de numeros inteiros:");
//     Console.WriteLine($"");

// for (int i = 0; i < 10; i++)
// {

//     Console.WriteLine($"Valor {i + 1}");
//     Console.WriteLine($"");
    
//     valor [i] = int.Parse(Console.ReadLine());
//     Console.WriteLine($"");
//     }

//     Console.Write($"O seu maior valor e de: ");
//     Console.WriteLine(valor.Max());  

// Console.WriteLine($"");

//  Console.Write($"O seu menor valor e de: ");
//  Console.WriteLine(valor.Min());  
//       }


// algoritimoLerNumeros();


// 5 - Escreva um algoritmo que imprima a tabuada (de 1 a 10) para os números de 1 a 10.
// Exemplo: tabuada do 1, tabuada do 2, etc... Dica: utilize um laço dentro do outro.

// int produto1 = 1;
// int produto2 = 0;
// int R = 0;

// Console.WriteLine($"tabuada do 1: ");
// Console.WriteLine($"");

// do
// {
//     for (int i = 0; i < 11; i++)
// Console.WriteLine($"{produto1} x {produto2 + i} = {produto1 * (produto2 + i)} ");

// produto1 ++;
    
// } while (produto1 <= 10);
    

//     6 - Escreva um algoritmo que permita a leitura dos nomes de 10 pessoas e armazene os nomes
// lidos em um vetor. Após isto, o algoritmo deve permitir a leitura de mais 1 nome qualquer de
// pessoa (para efetuar uma busca) e depois escrever a mensagem ACHEI, se o nome estiver
// entre os 10 nomes lidos anteriormente (guardados no vetor), ou NÃO ACHEI caso contrário.


// string [] nomes = new string [11];

// Console.WriteLine($"Digite os nomes para o programa:");
//     Console.WriteLine($"");

// for (int i = 0; i < 10; i++)
// {

//     Console.WriteLine($"Pessoa {i + 1}");
//     Console.WriteLine($"");
    
//     nomes [i] = Console.ReadLine();
//     Console.WriteLine($"");

//     }

// Console.WriteLine($"");
// Console.WriteLine($"Digite seu nome:");
// Console.WriteLine($"");

// nomes [10] = Console.ReadLine();

// for (int i = 0; i < 10; i++)
// {
//     if (nomes [10] == nomes [i])
// {Console.WriteLine($"O nome ja existe na lista na posicao {i + 1}.");
// }
// else {Console.WriteLine($"O nome nao esta na lista na posicao {i + 1}.");
// }
// }

 



// 7 - Faça um algoritmo para ler 15 números e armazenar em um vetor. Após a leitura total dos
// 15 números, o algoritmo deve escrever esses 15 números lidos na ordem inversa da qual foi
// declarado.

int [] numeros = new int [15];


Console.WriteLine($"Escreva 15 numeros:");
Console.WriteLine($"");

for (int i = 0; i <= 14; i++)
{

Console.WriteLine($"numero {i + 1}");
Console.WriteLine($"");


    numeros [i] = int.Parse(Console.ReadLine());
    Console.WriteLine($"");
    
    
}

Console.WriteLine($"");
Console.WriteLine($" os numeros em ordem inversa da lsita original e :");
Console.WriteLine($"");


foreach (var numerosdigitadosinverso in numeros.Reverse())
{
    
    Console.WriteLine($"{numerosdigitadosinverso}");
    
}