using ExemploExplorando.Models;

namespace ExemploExplorando
{
    public class Curso
    {
        //Propriedades
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        //Criando Métodos Add,remover,quantidade (Açäo)        
        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }
        
        public bool RemoverAluno(Pessoa aluno)
        {
            Alunos.Remove(aluno);
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            System.Console.WriteLine($"Alunos do curso de: {Nome}");

            for(int count = 0; count < Alunos.Count; count++)
            {
                //Concatenaçäo de strings com + 
                //string texto = "Nº " + count + " - " + Alunos[count].NomeCompleto;
                
                //Interpolaçäo de string (utiliza-se $ antes das "")
                string texto = $"Nº {count + 1} - {Alunos[count].NomeCompleto}";
                System.Console.WriteLine(texto);
            }
        }
    }
}