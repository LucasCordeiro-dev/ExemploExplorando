using ExemploExplorando;
using ExemploExplorando.Models;

//Implementado em apenas uma linha atraves do construtor(nome do parametro + valor)
Pessoa p1 = new Pessoa(nome: "Lucas", sobrenome: "Ramos");
// p1.Nome = "Lucas";
// p1.Sobrenome = "Ramos";

//Implementado em apenas uma linha atraves do construtor(nome do parametro + valor)
Pessoa p2 = new Pessoa(nome: "David",sobrenome:"Ramos");
// p2.Nome = "Davi";
// p2.Sobrenome = "Ramos";

Curso cursoDeIngles= new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();