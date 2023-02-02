/* 1.Escrever um algoritmo que permite ler a hora de início de um jogo e
a hora do final do jogo (considerando apenas horas inteiras) e
calcula a duração do jogo em horas, sabendo-se que o tempo
máximo de duração doogo é de 24 horas e que o jogo pode iniciar
num dia e terminar no dia seguinte.*/

using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int hi, mi, hf, mf;
            double somaMini, somaMinf, duracaoMin;
            int option = 0;

            do
            {
                Console.WriteLine("\nIntroduza uma hora de início do jogo: ");
                Console.Write("(Hora): ");
                hi = Convert.ToInt32(Console.ReadLine());
                Console.Write("(Minuto): ");
                mi = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nIntroduza uma hora de fim do jogo: ");
                Console.Write("(Hora): ");
                hf = Convert.ToInt32(Console.ReadLine());
                Console.Write("(Minuto): ");
                mf = Convert.ToInt32(Console.ReadLine());

                somaMini = (hi * 60) + mi;
                somaMinf = (hf * 60) + mf;
                duracaoMin = somaMinf - somaMini;

                if (duracaoMin > 1440)
                {
                    Console.WriteLine("\nO jogador teve uma sessão com uma duração maior que 24 horas de jogo. Cada sessão só pode ter no máximo 24 horas.");
                }
                else
                {
                    Console.WriteLine("\nO jogador teve uma sessão de " + duracaoMin + " minutos de jogo.");
                }

                Console.WriteLine("\n\nPretende introduzir novas horas de jogo?");
                Console.WriteLine("[0] - Sim");
                Console.WriteLine("[1] - Não (terminar o programa)");

                Console.Write("\nInput: ");
                option = Convert.ToInt32(Console.ReadLine());

                do
                {
                    if (option != 0 && option != 1)
                    {
                        Console.WriteLine("\n! ! ! - VALOR INTRODUZIDO INVÁLIDO - ! ! !");
                        Console.WriteLine("\nPretende introduzir novas horas de jogo?");
                        Console.WriteLine("[0] - Sim");
                        Console.WriteLine("[1] - Não (terminar o programa)");

                        Console.Write("\nInput: ");
                        option = Convert.ToInt32(Console.ReadLine());
                    }
                } while (option != 0 && option != 1);

                if (option == 1)
                {
                    Console.WriteLine("\n\nPrograma terminado.\n\n");
                }
            } while (option != 1);
        }
    }
}
-----------
//litros 
using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            double liquido, resto = 0;
            double lata = 0.25, garrafaML = 0.4, garrafaL = 1;
            int countLata = 0, countGarrafaML = 0, countGarrafaL = 0;

            Console.Write("Introduza a quantidade de litros que pretende comprar: ");
            liquido = Convert.ToDouble(Console.ReadLine());

            while (liquido >= garrafaL)
            {
                liquido -= garrafaL;
                countGarrafaL++;
            }

            while (liquido >= garrafaML)
            {
                liquido -= garrafaML;
                countGarrafaML++;
            }

            while (liquido >= lata)
            {
                liquido -= lata;
                countLata++;
            }

            Console.WriteLine("\nO programa resgistou que comprou: " + countGarrafaL + " garrafas de 1 litro.");
            Console.WriteLine("O programa resgistou que comprou: " + countGarrafaML + " garrafas de 400 mililitros.");
            Console.WriteLine("O programa resgistou que comprou: " + countLata + " latas de 250 mililitros.");
            resto = liquido;
            if (resto > 0)
            {
                Console.Write("\nRestou " + resto + " de líquido para comprar.");
            }
            else
            {
                Console.Write("\nNão restou nada.");
            }
        }
    }
}
----------
//3.
using System;

namespace ProgramaVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Insira um valor maior que zero para a variável 'a':");
            while (!int.TryParse(Console.ReadLine(), out a) || a <= 0)
            {
                Console.WriteLine("Valor inválido. Insira novamente um valor maior que zero para a variável 'a':");
            }

            Console.WriteLine("Insira um valor maior que zero para a variável 'b':");
            while (!int.TryParse(Console.ReadLine(), out b) || b <= 0)
            {
                Console.WriteLine("Valor inválido. Insira novamente um valor maior que zero para a variável 'b':");
            }

            Console.WriteLine("Insira um valor maior que zero para a variável 'c':");
            while (!int.TryParse(Console.ReadLine(), out c) || c <= 0)
            {
                Console.WriteLine("Valor inválido. Insira novamente um valor maior que zero para a variável 'c':");
            }

            int menor = Math.Min(a, Math.Min(b, c));
            int maior = Math.Max(a, Math.Max(b, c));

            Console.WriteLine($"Menor valor lido multiplicado pelo maior: {menor * maior}");
            Console.WriteLine($"Maior valor lido dividido pelo menor: {(double)maior / menor}");
        }
    }
}
---------------
//4
using System;

namespace CalcularSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo, horasTrabalhadas;
            const double valorHora = 10.00, valorHoraExcedente = 20.00;

            Console.WriteLine("Insira o código do colaborador:");
            while (!int.TryParse(Console.ReadLine(), out codigo))
            {
                Console.WriteLine("Código inválido. Insira novamente o código do colaborador:");
            }

            Console.WriteLine("Insira o número de horas trabalhadas pelo colaborador:");
            while (!int.TryParse(Console.ReadLine(), out horasTrabalhadas))
            {
                Console.WriteLine("Número de horas inválido. Insira novamente o número de horas trabalhadas pelo colaborador:");
            }

            double salario = horasTrabalhadas * valorHora;
            double salarioExcedente = 0;

            if (horasTrabalhadas > 40)
            {
                salarioExcedente = (horasTrabalhadas - 40) * valorHoraExcedente;
                salario += salarioExcedente;
            }

            Console.WriteLine("Salário total: " + salario + " euros");
            Console.WriteLine("Salário excedente: " + salarioExcedente + " euros");
        }
    }
}
-----------------
//candidatatas
using System;

namespace EncontrarModelo
{
    class Program
    {
        static void Main(string[] args)
        {
            const int maxCandidatas = 20;
            string[] nomes = new string[maxCandidatas];
            int[] idades = new int[maxCandidatas];
            int numCandidatas = 0;

            while (true)
            {
                Console.WriteLine("Insira o nome da candidata:");
                string nome = Console.ReadLine();

                if (nome == "cancelar")
                {
                    if (numCandidatas > 0)
                    {
                        Console.WriteLine("Existem " + numCandidatas + " registos");
                    }
                    break;
                }

                Console.WriteLine("Insira a idade da candidata:");
                int idade;
                while (!int.TryParse(Console.ReadLine(), out idade) || idade < 18 || idade > 20)
                {
                    Console.WriteLine("Idade inválida. Insira novamente a idade da candidata:");
                }

                nomes[numCandidatas] = nome;
                idades[numCandidatas] = idade;
                numCandidatas++;
            }

            if (numCandidatas == 0)
            {
                Console.WriteLine("Não existem candidatas");
                return;
            }

            Console.WriteLine("Candidatas aptas a concorrer a uma vaga:");
            for (int i = 0; i < numCandidatas; i++)
            {
                Console.WriteLine(nomes[i]);
            }
        }
    }
}
--------------
//voltas piloto
using System;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Quantas voltas o piloto fez?");
            n = Convert.ToInt32(Console.ReadLine());

            int melhorTempo = 1000000;
            int tempo;
            int soma = 0;
            int pos = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Quanto tempo fez na volta " + (i + 1) + " (em segundos)?");
                tempo = Convert.ToInt32(Console.ReadLine());

                if (tempo < melhorTempo)
                {
                    melhorTempo = tempo;
                    pos = (i + 1);
                }

                soma += tempo;
            }

            int media = soma / n;

            Console.WriteLine("\n\nMelhor tempo: " + melhorTempo);
            Console.WriteLine("Número da volta do melhor tempo: " + pos);
            Console.WriteLine("Tempo médio das voltas: " + media);
        }
    }
}
------------
//salários funcionários
using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome;
            int[] horas;
            int[] excede;

            nome = new string[5];
            horas = new int[5];
            excede = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Introduza o seu nome: ");
                nome[i] = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Introduza as horas trabalhadas: ");
                horas[i] = Convert.ToInt32(Console.ReadLine());

                double resto;
                resto = horas[i] * 10;
                if (horas[i] > 40)
                {
                    excede[i] = horas[i] - 40;
                }
            }
            Console.WriteLine("\n=========================================================================");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("\nFuncionário [" + (i + 1) + "]: ");
                Console.WriteLine("Nome: " + nome[i]);
                Console.WriteLine("Salário Total: " + (horas[i] * 10) + (excede[i] * 10));
                Console.WriteLine("Salário Excedente: " + (excede[i] * 10));
            }
            Console.WriteLine("\n=========================================================================");
        }
    }
}
-----------
//poluição
using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            double indice;

            Console.WriteLine("\n\nVALOR DO ÍNDICE DE POLUIÇÃO | [Aceitável de 0,05 até 0,25]");
            Console.WriteLine("VALOR DO ÍNDICE DE POLUIÇÃO | [Perigoso se alcançar os 0,3]");
            Console.WriteLine("VALOR DO ÍNDICE DE POLUIÇÃO | [Muito Perigoso se alcançar os 0,4]");
            Console.WriteLine("VALOR DO ÍNDICE DE POLUIÇÃO | [Nível Crítico se alcançar os 0,5] | Paralisar todas as atividades");
            Console.Write("Introduza o valor do índice de poluição: ");
            indice = Convert.ToDouble(Console.ReadLine());

            if (indice >= 0.05 && indice <= 0.25)
            {
                Console.WriteLine("VALOR DO ÍNDICE DE POLUIÇÃO | [Aceitável]");
            }
            else if (indice >= 0.5)
            {
                Console.WriteLine("VALOR DO ÍNDICE DE POLUIÇÃO | [Nível Crítico] | Paralisar todas as atividades");
            }
            else if (indice >= 0.4)
            {
                Console.WriteLine("VALOR DO ÍNDICE DE POLUIÇÃO | [Muito Perigoso] | Suspender o 1º e 2º grupo e as suas atividades");
            }
            else if (indice >= 0.3)
            {
                Console.WriteLine("VALOR DO ÍNDICE DE POLUIÇÃO | [Perigoso] | Suspender o 1º grupo e as suas atividades");
            }
        }
    }
}
-------------------
//corredor
using System;

namespace Atletismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o número de voltas da corrida:");
            int numVoltas = int.Parse(Console.ReadLine());

            double[] tempos = new double[numVoltas];
            for (int i = 0; i < numVoltas; i++)
            {
                Console.WriteLine("Informe o tempo da volta " + (i + 1) + ":");
                tempos[i] = double.Parse(Console.ReadLine());
            }

            double melhorTempo = tempos[0];
            int voltaMelhorTempo = 1;
            double somaTempos = 0;

            for (int i = 0; i < numVoltas; i++)
            {
                somaTempos += tempos[i];

                if (tempos[i] < melhorTempo)
                {
                    melhorTempo = tempos[i];
                    voltaMelhorTempo = i + 1;
                }
            }

            double tempoMedio = somaTempos / numVoltas;

            Console.WriteLine("Melhor tempo: " + melhorTempo + "s");
            Console.WriteLine("Volta com melhor tempo: " + voltaMelhorTempo);
            Console.WriteLine("Tempo médio das " + numVoltas + " voltas: " + tempoMedio + "s");
        }
    }
}

-------------
using System;
class Program
{
    static void Main(string[] args)
    {
        int codigo;

        Console.WriteLine("Insira o número 1, 2 ou 3: ");
        codigo = Convert.ToInt32(Console.ReadLine());


        switch (codigo)
        {
            case 1:
                Console.WriteLine("Um");
                break;
            case 2:
                Console.WriteLine("Dois");
                break;
            case 3:
                Console.WriteLine("Três");
                break;

            default:
                Console.WriteLine("Número inválido");
                break;
        }
    }
}
-------------
using System;
class Program
{
    static void Main(string[] args)
    {
        string[] nome;
        int[] idade;
        string[] candidatas;
        int pos = 0;

        nome = new string[20];
        idade = new int[20];
        candidatas = new string[20];

        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine("Introduza o seu nome: ");
            nome[i] = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Introduza a sua idade: ");
            idade[i] = Convert.ToInt32(Console.ReadLine());

            if (idade[i] >= 18 && idade[i] <= 20)
            {
                candidatas[pos] = nome[i];
                pos++;
            }
        }

        Console.WriteLine("!!!!!!!!!!CANDIDATAS!!!!!!!!!!");

        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine("Nome " + i + 1 + ": " + candidatas[i]);
        }
    }
}
-----
using System;
namespace WordCounter;

class Program
{

    static void Main(string[] args)
    {

        string endProgram = "RECOMECAR";


        while (endProgram == "RECOMECAR")
        {

            Console.WriteLine("Escreva uma string à escolha.");
            string frase = Console.ReadLine();


            int wordTotal = CountWords(frase);


            Console.WriteLine($"O total de palavras é: {wordTotal}");


            Console.WriteLine("Escreva FIM para terminar o programa ou RECOMECAR para reiniciar");
            endProgram = Console.ReadLine();
        }
    }


    public static int CountWords(string _frase)
    {

        string[] components = _frase.Split(" ");


        int wordCount = components.Length;

        return wordCount;
    }
}
using System;
namespace StringReversal;

class Program
{
    string stringFinal;
    static void Main(string[] args)
    {
        //string utilizada para o loop do programa.
        string endProgram = "RECOMECAR";

        //Ciclo que corre o nosso programa até o utilizador escrever FIM no fim do run.
        while (endProgram == "RECOMECAR")
        {

            //Pedir e receber uma frase do utilizador.
            //'string frase = Console.ReadLine();' recebe input do utilizador e guarda na variavel frase.
            Console.WriteLine("Escreva uma string à escolha.");
            string frase = Console.ReadLine();

            //Chamar a função que obtem as iniciais de cada palavra da frase, com a frase do utilizador dentro dos parenteses.
            //Colocamos 'finalString = ' no inicio, de modo a recebermos a frase final da função, guardando a em fraseFinal.
            string finalString = ReverseString(frase);

            //Apresentamos a string corrigida ao utilizador.
            Console.WriteLine($"A sua string invertida é: {finalString}");

            //Pede uma input ao utilizador. Se escrever FIM o programa termina, se escrever RECOMECAR, reinicia.
            Console.WriteLine("Escreva FIM para terminar o programa ou RECOMECAR para reiniciar");
            endProgram = Console.ReadLine();
        }

    }

    //Função do tipo string: recebe uma string quando é chamada, à qual podemos aceder através da variável entre parenteses.
    public static string ReverseString(string _frase)
    {

        //Criar uma string para guardar a nossa string revertida.
        string reversedString = "";

        //Fazemos um ciclo que em vez de ir de 0 ate ao valor maximo, faz o oposto, indo do ultimo carater ao primeiro.
        for (int i = _frase.Length - 1; i >= 0; i--)
        {
            //A cada iteracao do loop, adicionamos o carater atual.
            reversedString += _frase[i];
        }

        //Devolvemos a string revertida.
        return reversedString;
    }
}
-------------
using System;
namespace WordInitials;

class Program
{

    static void Main(string[] args)
    {
        //string utilizada para o loop do programa.
        string endProgram = "RECOMECAR";

        //Variável para guardar a string final a mostrar ao utilizador.    
        string finalString = "";

        //Ciclo que corre o nosso programa até o utilizador escrever FIM no fim do run.
        while (endProgram == "RECOMECAR")
        {
            //Pedir e receber uma frase do utilizador.
            //'string frase = Console.ReadLine();' recebe input do utilizador e guarda na variavel frase.
            Console.WriteLine("Escreva uma string à escolha.");
            string frase = Console.ReadLine();

            //Chamar a função que obtem as iniciais de cada palavra da frase, com a frase do utilizador dentro dos parenteses.
            //Colocamos 'finalStringl = ' no inicio, de modo a recebermos a frase final da função, guardando a em fraseFinal.
            finalString = GetInitials(frase);

            //Apresentamos a string corrigida ao utilizador.
            Console.WriteLine($"As iniciais de cada palavra da sua string são: {finalString}");

            //Pede uma input ao utilizador. Se escrever FIM o programa termina, se escrever RECOMECAR, reinicia.
            Console.WriteLine("Escreva FIM para terminar o programa ou RECOMECAR para reiniciar");
            endProgram = Console.ReadLine();
        }
    }

    //Função do tipo string: recebe uma string quando é chamada, à qual podemos aceder através da variável entre parenteses.
    public static string GetInitials(string _frase)
    {
        //Criar uma string para guardar a nossas iniciais.
        string initials = "";

        //Criar um array de palavras -- Divide a nossa frase em palavras reconhecendo os espaços.
        string[] components = _frase.Split(" ");

        //Fazemos um ciclo que passa por todas as palavras guardadas no array components.
        for (int i = 0; i < components.Length; i++)
        {
            //Adicionamos o primeiro carater de cada palavra a string initials
            initials += components[i][0];
        }

        //Devolvemos a string initials
        return initials;
    }
}
----------
using System;
namespace RemoveSpaces;

class Program
{
    static public void Main(string[] args)
    {
        //Variável para guardar a string final a mostrar ao utilizador.        
        string fraseFinal = "";

        //String usada para controlar o loop do programa.
        string loopString = "RECOMECAR";

        //Ciclo que corre o nosso programa até o utilizador escrever FIM no fim do run.
        while (loopString == "RECOMECAR")
        {
            //Pedir e receber uma frase do utilizador.
            //'string frase = Console.ReadLine();' recebe input do utilizador e guarda na variavel frase.
            Console.WriteLine("Introduza a string a rearranjar.");
            string frase = Console.ReadLine();

            //Chamar a função que removo os espaços extra, com a frase do utilizador dentro dos parenteses.
            //Colocamos 'fraseFinal = ' no inicio, de modo a recebermos a frase final da função, guardando a em fraseFinal.
            fraseFinal = CorrectSpaces(frase);

            //Apresentamos a string corrigida ao utilizador.
            Console.WriteLine($"A sua string corrigida é: {fraseFinal}");

            //Pede uma input ao utilizador. Se escrever FIM o programa termina, se escrever RECOMECAR, reinicia.
            Console.WriteLine("Escreva 'FIM' para terminar o programa ou 'RECOMECAR' para reinicia-lo.");
            loopString = Console.ReadLine();
        }

    }

    //Função do tipo string: recebe uma string quando é chamada, à qual podemos aceder através da variável entre parenteses.
    public static string CorrectSpaces(string _frase){

            //Criar um array de palavras -- Divide a nossa frase em palavras reconhecendo os espaços.
            string[] palavras = _frase.Split(" ");

            //Criar uma string para guardar a nossa frase corrigida.
            string fraseCorrigida = "";

            //Fazer loop por todas as nossas palavras divididas.
            foreach (var palavra in palavras)
            {
                //Se a palavra atual do ciclo for diferente de um espaço, adicionamos essa palavra e um espaco a nossa frase corrigida.
                //No fim do ciclo, teremos todas as palavras originais, com apenas um espaco entre elas.
                if(palavra!=""){
                    fraseCorrigida += palavra;
                    fraseCorrigida += " ";
                }
            }

            //Removemos o espaco extra que fica no final da nossa string devido ao ciclo.
            fraseCorrigida = fraseCorrigida.Remove(fraseCorrigida.Length-1,1);

            //Devolvemos a fraseCorrigida no final da função.
            return fraseCorrigida;
        }

}
-----------
using System;
namespace StringReversal;

class Program
{
    static void Main(string[] args)
    {

        //string utilizada para o loop do programa.
        string endProgram = "RECOMECAR";

        //Ciclo que corre o nosso programa até o utilizador escrever FIM no fim do run.
        while (endProgram == "RECOMECAR")
        {

            //Pedir e receber uma frase do utilizador.
            //'string frase = Console.ReadLine();' recebe input do utilizador e guarda na variavel frase.
            Console.WriteLine("Escreva uma string à escolha.");
            string frase = Console.ReadLine();

            //Chamar a função que obtem as iniciais de cada palavra da frase, com a frase do utilizador dentro dos parenteses.
            //Colocamos 'finalString = ' no inicio, de modo a recebermos a frase final da função, guardando a em fraseFinal.
            string stringFinal = ReverseWords(frase);

            //Apresentamos a string corrigida ao utilizador.
            Console.WriteLine($"A sua string invertida é: {stringFinal}");

            //Pede uma input ao utilizador. Se escrever FIM o programa termina, se escrever RECOMECAR, reinicia.
            Console.WriteLine("Escreva FIM para terminar o programa ou RECOMECAR para reiniciar");
            endProgram = Console.ReadLine();
        }


    }    

    public static string ReverseString(string _frase)
    {
        //Criar uma string para guardar a nossa string revertida.
        string reversedString = "";

        //Fazemos um ciclo que em vez de ir de 0 ate ao valor maximo, faz o oposto, indo do ultimo carater ao primeiro.
        for (int i = _frase.Length - 1; i >= 0; i--)
        {
            //A cada iteracao do loop, adicionamos o carater atual.
            reversedString += _frase[i];
        }

        //Devolvemos a string revertida.
        return reversedString;
    }

    //Função do tipo string: recebe uma string quando é chamada, à qual podemos aceder através da variável entre parenteses.
    public static string ReverseWords(string _frase)
    {

        //Criar um array de palavras -- Divide a nossa frase em palavras reconhecendo os espaços.
        string[] components = _frase.Split(" ");

        //Criar uma string para guardar a nossa frase corrigida.
        string reversedSentence = "";

        //Fazer um ciclo que percorre todos os as nossas palavras separadas, contidas no array components.
        for (int i = 0; i < components.Length; i++)
        {
            //A cada iteracao do loop, adicionamos a nossa frase revertida (reversedSentence), cada uma das palavras revertidas atraves da nossa funcao ReverseString,
            //que criamos anteriormente, e um espaco a frente delas, de modo a acabarmos com uma frase propriamente estruturada.
            reversedSentence += (ReverseString(components[i]) + " ");
        }

        //Removemos o espaco extra que fica no final da nossa string devido ao ciclo.
        reversedSentence = reversedSentence.Remove(reversedSentence.Length - 1, 1);

        //Devolvemos a nossa string revertida.
        return reversedSentence;
    }
}
-------------
/* Multiplicar dois números usando somas repetidas. */
int n1;
int n2;
int produto=0;
string txtproduto="";
string soma="";

Console.WriteLine("Introduza um número:");
n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Introduza um número:");
n2 = Convert.ToInt32(Console.ReadLine());

for(int i=0; i<n1; i++)
{
    produto=produto+n2;
    if(i==0){soma="";}else{soma="+";}
    txtproduto=txtproduto+soma+n2;
}

Console.WriteLine("O resultado da multiplicação é: "+ produto);
Console.WriteLine(""+ txtproduto);
Console.ReadKey();
----------
/* Solicitar um quantidade pré-determinada de números e 
calcular a soma e média entre esses números. */

Double num;
Double n;
Double media;
Double soma=0;

Console.WriteLine("Introduza a quantidade de números:");
num = Convert.ToDouble(Console.ReadLine());

for(int i=0; i<num; i++)
{
    Console.WriteLine("Introduza um número:");
    n = Convert.ToDouble(Console.ReadLine());
    soma += n;
}

media = soma / num;

Console.WriteLine("A soma dos "+ num +" números é: "+ soma +".");
Console.WriteLine("A média dos "+ num +" números é: "+ media +".");
Console.ReadKey();
---------
/* Calcular a soma dos números ímpares entre 
um intervalo definido pelo utilizador. */

Console.WriteLine("Qual o valor mínimo:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Qual o valor máximo:");
int max = Convert.ToInt32(Console.ReadLine());

int i = min + 1;
int numImpares=0, soma=0;

while (i<max)
{
    // verificar se é par
    if(i%2!=0){
        soma=soma+1;
        numImpares++;
    }
    i++;
}

Console.WriteLine("A soma dos números ímpares no intervalo de "+ min +" a "+ max +" é de: "+ soma +". Neste intervalo existem "+ numImpares +" números ímpares.");
Console.ReadKey();
-----------
using System;
namespace ContarPalavras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva uma frase: ");
            var input = Console.ReadLine();
            ContarPalavras(input);
            Console.ReadKey();
        }
        public static void ContarPalavras(string palavras)
        {
            string espaco = " ";
            int contarEspacos = 1;
            for (int i = 0; i < palavras.Length; i++)
            {
                if (palavras[i] == espaco[0])
                {
                    contarEspacos++;
                }
            }

            Console.WriteLine("A frase contém "+ contarEspacos +" palavras.");
        }
    }
}
--------------
using System;
namespace LerFrase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva uma frase: ");
            var input = Console.ReadLine();
            LerFrase(input);
            Console.ReadKey();
        }
        public static void LerFrase(string frase)
        {
            for(int i = frase.Length-1; i >= 0; i--)
            {
                Console.Write(frase[i]);
            }
            
            Console.WriteLine("");
        }
    }
}
--------------
using System;
namespace TestUrl
{
    class Program
    {
        static void Main(string[] args)
        {
            string exampleURL = "www.docs.microsoft.com/dotnet/csharp/whats-new/csharp-version-history";
            Console.WriteLine("Pressione uma tecla para decompor o url: "+exampleURL);
            //Console.WriteLine($"Pressione uma tecla para decompor o url: {exampleURL}");
            Console.ReadKey();
            //chamar a função e atribuir o valor que é recebido à variável words
            var words = BreakDownURL(exampleURL);
            //exibe  o tipo de dados
            Console.WriteLine(words);
            //percorrer o array para mostrar o seu contéudo
            for(int i=0; i<words.Length; i++)
            {
                var indent = new string(' ', i*2);
                Console.WriteLine($"{indent} -> {words[i]}");
                //Console.WriteLine(indent+" -> "+words[i]);
            }
            Console.ReadKey();
        }
        public static string[] BreakDownURL(string urlString)
        {
            //remover o www.
            string noWWW = urlString.Remove(0,4);
            //substituir - por espaço
            string noDashes = noWWW.Replace("-"," ");
            //separar a string pelas /
            string [] components = noDashes.Split("/");
             
            return components;
        }
    }
}
---------
using System;
namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduza o valor da refeição: ");
            int valor = Convert.ToInt32(Console.ReadLine());
            double g = Gorjeta(valor);
            Console.WriteLine("Valor de gorjeta: " + g);
        }

        public static double Gorjeta(int valor)
        {
            double gorjeta = 0;

            if (valor <= 10)
            {
                gorjeta = valor * 0.1;
            }
            else if (valor > 10 && valor < 25)
            {
                gorjeta = valor * 0.15;
            }
            else if (valor >= 25)
            {
                gorjeta = valor * 0.2;
            }

            return gorjeta;
        }
    }
}

-------------
using System;
namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduza uma frase: ");
            string frase = Convert.ToString(Console.ReadLine());
            int v = ContarVogais(frase);
            Console.WriteLine("A frase introduzida contém " + v +" vogais.");
        }
        public static int ContarVogais(string frase)
        {
            int vogais = 0;

            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i].ToString() == "a" ||
                frase[i].ToString() == "e" ||
                frase[i].ToString() == "i" ||
                frase[i].ToString() == "o" ||
                frase[i].ToString() == "u" ||
                frase[i].ToString() == "A" ||
                frase[i].ToString() == "E" ||
                frase[i].ToString() == "I" ||
                frase[i].ToString() == "O" ||
                frase[i].ToString() == "U" ||
                frase[i].ToString() == "ã" ||
                frase[i].ToString() == "á" ||
                frase[i].ToString() == "à" ||
                frase[i].ToString() == "é" ||
                frase[i].ToString() == "í" ||
                frase[i].ToString() == "ó" ||
                frase[i].ToString() == "õ" ||
                frase[i].ToString() == "ú")

                {
                    vogais++;
                }
            }

            return vogais;
        }
    }
}
-----------
using System;
namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduza uma frase: ");
            string frase = Convert.ToString(Console.ReadLine());
            Console.WriteLine("A frase introduzida contém:");
            string letra = "a";
            int c = ContarVogais(frase, letra);
            Console.WriteLine("Contém " + c + " vogais (A)");
            letra = "e";
            c = ContarVogais(frase, letra);
            Console.WriteLine("Contém " + c + " vogais (E)");
            letra = "i";
            c = ContarVogais(frase, letra);
            Console.WriteLine("Contém " + c + " vogais (I)");
            letra = "o";
            c = ContarVogais(frase, letra);
            Console.WriteLine("Contém " + c + " vogais (O)");
            letra = "u";
            c = ContarVogais(frase, letra);
            Console.WriteLine("Contém " + c + " vogais (U)");
        }
        public static int ContarVogais(string frase, string letra)
        {           
            int contaLetra = 0;

            for (int i = 0; i < frase.Length; i++)
            {
                if(frase[i].ToString() == letra)
                {
                    contaLetra++;
                }
            }
            return contaLetra;
        }
    }
}
------------
using System;
namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            string example;

            do
            {
                double num, res = 0;
                string conta = "";
                char op = '+';

                do
                {
                    if (conta != "")
                    {
                        do
                        {
                            Console.WriteLine("- - - MENU - - -");
                            Console.WriteLine("Introduza '+' para somar.");
                            Console.WriteLine("Introduza '-' para subtrair.");
                            Console.WriteLine("Introduza '/' para dividir.");
                            Console.WriteLine("Introduza '*' para multiplicar.");
                            Console.WriteLine("Introduza '=' para acabar o cálculo.");
                            op = Convert.ToChar(Console.ReadLine());

                        } while (op != '+' && op != '-' && op != '*' && op != '/' && op != '=');
                        conta += op;
                    }

                    if (op != '=')
                    {
                        Console.WriteLine("Conta: " + conta);
                        Console.WriteLine("Introduza o número: ");
                        num = Convert.ToDouble(Console.ReadLine());

                        switch (op)
                        {
                            case '+':
                                res += num;
                                break;
                            case '-':
                                res -= num;
                                break;
                            case '*':
                                res *= num;
                                break;
                            case '/':
                                res /= num;
                                break;
                        }

                        conta += num;
                        Console.WriteLine("Conta: " + conta);
                    }
                } while (op != '=');

                conta += res;
                Console.WriteLine(conta);

                do
                {
                    Console.WriteLine("Nova conta? (sim ou nao)");
                    example = Console.ReadLine().ToLower();
                } while (example != "sim" && example != "nao");

            } while (example != "nao");
            
            Console.WriteLine("Até à próxima…");
        }
    }
}
--------------
using System;
namespace Jogo
{
    class Program
    {
        static void Main(string[] args)
        {
            string example;
            Random rnd = new Random();

            do
            {
                int rInt = rnd.Next(0, 100);
                int count = 0, res;

                do
                {
                    Console.WriteLine("Introduza um número (" + (5 - count) + " tentativa(s))");
                    res = Convert.ToInt32(Console.ReadLine());

                    if (res < rInt)
                    {
                        Console.WriteLine("É maior!");
                    }
                    else if (res > rInt)
                    {
                        Console.WriteLine("É menor!");
                    }

                    count++;
                } while (count < 5 && res != rInt);

                if (res == rInt)
                {
                    Console.WriteLine("Acertou!");
                }
                else
                {
                    Console.WriteLine("Não acertou...");
                }

                do
                {
                    Console.WriteLine("Novo jogo? (sim ou nao)");
                    example = Console.ReadLine().ToLower();
                } while (example != "sim" && example != "nao");
            } while (example != "nao");

            Console.WriteLine("Até à próxima…");
        }
    }
}
-------
using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lista = new int[3];
            int[] listaInvertida = new int[3];
            
            //ler os valores
            for (int i = 0; i < lista.Length; i++)
            {
                Console.WriteLine("Introduza um valor inteiro:");
                lista[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("-----------------------------");
            Console.WriteLine("Escrever lista e posição");
            Console.WriteLine("-----------------------------");

            //escrever a posicao
            for (int i = 0; i < lista.Length; i++)
            {
                Console.WriteLine("Posição: " + i + " valor " + lista[i]);
            }

            Console.WriteLine("-----------------------------");
            Console.WriteLine("Escrever lista invertida");
            Console.WriteLine("-----------------------------");

            //escrever a posicao maior para o menor
            for (int i = lista.Length - 1; i < 0; i--)
            {
                Console.WriteLine("Posição: " + i + " valor " + lista[i]);
            }

            Console.WriteLine("-----------------------------");
            Console.WriteLine("Lista Invertida");
            Console.WriteLine("-----------------------------");
            
            //inverter a posicao
            for (int i = 0; i < lista.Length; i++)
            {
                listaInvertida[lista.Length - i - 1] = lista[i];

            }

            //escrever a posicao
            for (int i = 0; i < lista.Length; i++)
            {
                Console.WriteLine("Posição: " + i + " valor " + lista[i]);
                Console.WriteLine("Posição Invertida: " + i + " valor " + listaInvertida[i]);
            }

            Console.WriteLine("-----------------------------");
            Console.WriteLine("Somar");
            Console.WriteLine("-----------------------------");

            for (int i = 0; i < lista.Length; i++)
            {
                lista[i] += 10;

            }

            for (int i = 0; i < lista.Length; i++)
            {
                Console.WriteLine("Posição: " + i + " valor " + lista[i]);
            }
        }
    }
}
-----------
using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] notas = new int[8];

            int soma = 0;
            int nota = 0;

            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine("Introduza um valor inteiro de 0 a 20");
                nota = int.Parse(Console.ReadLine());
                //verifica se a nota é válida
                if ((nota < 0) || (nota > 20))
                {
                    Console.WriteLine("O valor não está entre 0 a 20");
                    i--;
                }
                else
                {
                    notas[i] = nota;
                }
            }

            //a média das notas e o número de notas acima da média
            for (int i = 0; i < notas.Length; i++)
            {
                soma = soma + notas[i];
            }
            double media = soma / notas.Length;
            int conta = 0;

            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] > media) conta = conta + 1;
            }
            Console.WriteLine("------------------");
            Console.WriteLine("Contagem de numeros acima da média (" + media + ")" + conta);
            Console.WriteLine("------------------");

            //a maior nota e a quantidade de alunos que tiveram a maior nota
            int maior = notas[0];
            for (int i = 1; i < notas.Length; i++)
            {
                if (notas[i] > maior) maior = notas[i];
            }

            //contar numero de alunos com notas iguais à maior 
            conta = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] == maior) conta = conta + 1;
            }
            Console.WriteLine("------------------");
            Console.WriteLine("Contagem de alunos que tiveram a maior nota ("+maior+") " + conta);
            Console.WriteLine("------------------");

            //a menor nota e os índices (posição do array) dos alunos que tiveram a menor nota
            int menor = notas[0];
            for (int i = 1; i < notas.Length; i++)
            {
                if (notas[i] < menor) menor = notas[i];
            }
            Console.WriteLine("------------------");
            Console.WriteLine("A menor nota foi " + menor);
            Console.WriteLine("------------------");
            Console.WriteLine("Os indices dos alunos que tiveram a menor nota são: ");
            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] == menor) Console.WriteLine("Aluno: " + i);
            }
            Console.WriteLine("------------------");
            
            //o número de alunos com nota negativa (<10)
            conta = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] < 10) conta = conta + 1;
            }
            Console.WriteLine("Contagem de alunos que tiveram nota <10:" + conta);
        }
    }
}
-----------
/* 
Determinar o aluno mais alto e o mais baixo exibindo o seu nome, nº de aluno e repetiva altura 
O número de registos deve ser pedido ao utilizador
*/

string nome="", nomeA="", nomeB="";
int codealuno=0, codealunoA=0, codealunoB=0;
double altura=0, alturaA=0, alturaB=0;
int numregistos;

//ler o nº de registos
Console.WriteLine("Qual o número de registos? ");
numregistos = Convert.ToInt32(Console.ReadLine());
for (int i=1; i <=numregistos; i++)
{
    Console.WriteLine("Qual o nome? ");
    nome = Convert.ToString(Console.ReadLine());
    Console.WriteLine("Qual o código do aluno? ");
    codealuno = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Qual a altura? ");
    altura = Convert.ToDouble(Console.ReadLine());
    if (i==1)
    {
        nomeA = nome;
        nomeB = nome;
        alturaA = altura;
        alturaB = altura;
        codealunoA = codealuno;
        codealunoB = codealuno;
    }
    if (altura>alturaA)
    {
        nomeA = nome;
        alturaA = altura;
        codealunoA = codealuno;
    }
    else
    {
        if (altura<alturaB)
        nomeB = nome;
        alturaB = altura;
        codealunoB = codealuno;
    }
}
Console.WriteLine("O aluno mais alto é: "+ nomeA +", nº"+ codealunoA +", "+ alturaA +".");
Console.WriteLine("O aluno mais baixo é: "+ nomeB +", nº"+ codealunoB +", "+ alturaB +".");
Console.ReadKey();
------
/* Reajustar os salários de 10 funcionários: se o salário for superior a 300 ajusta 50%, se for inferior ou igual ajusta 60% */

//definir variáveis
Double salario;
Double novoSalario;
int i = 1;

//percorrer a lista de funcionários
while(i <= 10)
{
    Console.WriteLine("Qual o salário? ");
    salario = Convert.ToDouble(Console.ReadLine());
    if(salario <= 300)
    {
        novoSalario = salario * 1.6;
    }
    else
    {
        novoSalario = salario * 1.5;
    }
    Console.WriteLine("O salário de "+ salario +" passa a ser de "+ novoSalario +".");
    i++;
}

Console.ReadKey();