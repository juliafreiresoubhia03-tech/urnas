// Validação de percentuais de uma eleição
// Criação e inicialização das variáveis
int votos, brancos, nulos = 0;
int candidatoA, candidatoB = 0;
double total = 0;

// Solicitação de dados do usuário
Console.WriteLine("*** Apuração de votos do município ***"); ;
Console.Write("Informe a quantidade de votos válidos: ");
votos = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Total de votos do candidato A: ");
candidatoA = Convert.ToInt32(Console.ReadLine());

Console.Write("Total de votos do candidato B: ");
candidatoB = Convert.ToInt32(Console.ReadLine());

Console.Write("Informe o total de votos em branco: ");
brancos = Convert.ToInt32(Console.ReadLine());

Console.Write("Informe o total de votos nulos: ");
nulos = Convert.ToInt32(Console.ReadLine());

// operaçao de casting, reforça 
double PercA = (double) candidatoA / votos * 100;
double PercB = (double) candidatoB / votos * 100;
double nulo = (double) nulos / votos * 100;
double branco = (double) brancos / votos * 100;

// Condição de existência de triângulo
// A soma de dois lados quaisquer deve ser sempre maior que o terceiro lado
System.Console.WriteLine($"Candidato A {PercA} %, Candidato B {PercB} %");

 // Redistribuição
    if (PercA > 50)
    {
        total = (double) PercA + nulo + branco;
    }
    else
    {
        total = (double) PercB + nulo + branco;
    }

Console.WriteLine($"O candidato vencedor teve {total} %");