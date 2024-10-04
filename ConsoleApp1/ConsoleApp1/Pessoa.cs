using ConsoleApp1;
using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp1
{
    public class Pessoa
    {
        private string nome;
        public string Nome
        {
            get => nome;
            set => nome = value;
        }
        private int idade; 
        public int Idade
        {
            get => idade;
            {
                if(this.idade > 20) { return 20; }
                return this.idade;
            }
            set => idade = value;
            {
                if(value > 0)
                this.idade = value;
            }
        }
        private string telefone;
        public string Telefone
        {
            get => telefone;
            set => telefone = value;
        }
        private string endereco;    
        public string Endereco
        {
            get => endereco;
            set => endereco = value;
        }
        private string email;   
        public string Email
        {
            get => email;
            set => email = value;
        }
    }
}


