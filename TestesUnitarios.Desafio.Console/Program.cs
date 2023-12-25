using TestesUnitarios.Desafio.Console.Services;
// Utilizando a classe ValidacoesString
ValidacoesString validacoesString = new ValidacoesString();

string texto = "Desafio de Testes Unitários";
string textoProcurado = "Testes";

int quantidadeCaracteres = validacoesString.RetornarQuantidadeCaracteres(texto);
bool contemCaractere = validacoesString.ContemCaractere(texto, textoProcurado);
bool textoTerminaCom = validacoesString.TextoTerminaCom(texto, textoProcurado);

Console.WriteLine($"Texto: {texto}");
Console.WriteLine($"Quantidade de caracteres: {quantidadeCaracteres}");
Console.WriteLine($"Contém o texto '{textoProcurado}': {contemCaractere}");
Console.WriteLine($"Texto termina com '{textoProcurado}': {textoTerminaCom}");

Console.WriteLine(); 

// Utilizando a classe ValidacoesLista
ValidacoesLista validacoesLista = new ValidacoesLista();

List<int> numerosLista = new List<int> { 5, -2, 10, 3, 8 };

List<int> listaSemNegativos = validacoesLista.RemoverNumerosNegativos(numerosLista);
bool listaContemNumero = validacoesLista.ListaContemDeterminadoNumero(numerosLista, 3);
List<int> listaMultiplicada = validacoesLista.MultiplicarNumerosLista(numerosLista, 2);
int maiorNumero = validacoesLista.RetornarMaiorNumeroLista(numerosLista);
int menorNumero = validacoesLista.RetornarMenorNumeroLista(numerosLista);

Console.WriteLine($"Lista original: {string.Join(", ", numerosLista)}");
Console.WriteLine($"Lista sem números negativos: {string.Join(", ", listaSemNegativos)}");
Console.WriteLine($"Lista contém o número 3: {listaContemNumero}");
Console.WriteLine($"Lista multiplicada por 2: {string.Join(", ", listaMultiplicada)}");
Console.WriteLine($"Maior número na lista: {maiorNumero}");
Console.WriteLine($"Menor número na lista: {menorNumero}");

Console.ReadLine();

