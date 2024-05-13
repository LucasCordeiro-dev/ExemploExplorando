namespace ExemploExplorando.Models
{
    public class Pessoa
    {

        public Pessoa()
        {
            
        }
        public Pessoa(string nome,string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        private string _nome;
        private int _idade;
        public String Nome
        {
            //Indicando validaçäo simples utilizando o RETURN atraves de => (body expressions)
            get => _nome.ToUpper();

            set
            {
                //Se o valor do campo nome for VAZIO,lancando uma Excessäo
                if (value == "")
                {
                    throw new ArgumentException("O nome näo pode ser vazio");
                }

                _nome = value;
            }
        }

        public string Sobrenome { get; set; }

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        public int Idade
        {
            get => _idade;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade näo pode ser menor que zero");
                }
                _idade = value;
            }
        }

        public void Apresentar()
        {
            System.Console.WriteLine($"Nome: {NomeCompleto} Idade: {Idade}");
        }

    }
}