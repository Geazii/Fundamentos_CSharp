namespace ExemploConstrutores.Models
{
    public class Pessoa
    {
        private string nome;
        private string sobrenome;

        //criação de dois construtores - atalho "ctor" Os parâmetros são opcionais
        public Pessoa()
        {
            nome = string.Empty;
            sobrenome = string.Empty;
        }

        public Pessoa(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
        }

        public void Apresentar()
        {
            System.Console.WriteLine($"Olá, meu nome é: {nome}{sobrenome}");
        }
    }
}