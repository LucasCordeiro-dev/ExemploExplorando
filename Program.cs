using ExemploExplorando;
using ExemploExplorando.Models;
//Formataçäo de moeda com o system globalization
using System.Globalization;

#region Primeiro teste 
//Implementado em apenas uma linha atraves do construtor(nome do parametro + valor)
//Pessoa p1 = new Pessoa(nome: "Lucas", sobrenome: "Ramos");
// p1.Nome = "Lucas";
// p1.Sobrenome = "Ramos";

//Implementado em apenas uma linha atraves do construtor(nome do parametro + valor)
//Pessoa p2 = new Pessoa(nome: "David",sobrenome:"Ramos");
// p2.Nome = "Davi";
// p2.Sobrenome = "Ramos";

// Curso cursoDeIngles= new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();
#endregion

#region Formatando valores monetarios & Formataçao personalizada
//Padronizando para TODO O SISTEMA
//CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("PT-BR");

//Interpolaçäo + : (FORMATAÇÁO) + C (CURRENCY -> MOEDA) BASEADO NAS CFGS DO SEU SISTEMA
//decimal valorMonetario = 1282.40M;
//System.Console.WriteLine($"{valorMonetario:C}");

//Formatar de acordo com o cultura
//System.Console.WriteLine(valorMonetario.ToString("C",CultureInfo.CreateSpecificCulture("en-US")));

//Formataçäo personalizada (DUAS CASAS DECIMAIS)
//System.Console.WriteLine(valorMonetario.ToString("C2"));

//representando porcentagem
// double porcentagem = .2134;
// System.Console.WriteLine(porcentagem.ToString("P"));

//Formato personalizado
// int numero = 123456;
// System.Console.WriteLine(numero.ToString("##-##-##"));
#endregion

#region Formatando o DateTime
//Formatando data e hora de forma manual -> PARSE (CONVERTE STRING EM DATE TIME)
//DateTime data = DateTime.Parse("17/04/2022 18:00");
//System.Console.WriteLine(data);

string dataString = "2022-04-10 18:00";

//Converte a data invalida em date time de forma valida
//Validando o retorno do TryParse(que é booleano)
bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", 
CultureInfo.InvariantCulture,DateTimeStyles.None, out DateTime data);
if(sucesso)
{
    System.Console.WriteLine($"Conversäo com sucesso! Data: {data}");
}
else
{
    System.Console.WriteLine($"{dataString} näo é uma data válida");
}

//DateTime data = DateTime.Now;
//System.Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));
//Apenas DATA -> System.Console.WriteLine(data.ToShortDateString());
//Apenas Hora -> System.Console.WriteLine(data.ToShortTimeString());





#endregion