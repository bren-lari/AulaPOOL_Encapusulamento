using System;

namespace Csharp.Classes
{
    public class Cartão
    {
        private string numero;

        public string Numero{
            get{return numero;}
            set{numero = value;}
        }

        private string nomeTitular;
        public string NomeTitular{
            get{return nomeTitular;}
            set{nomeTitular = value;}
        }

        private string bandeira;

        public string Bandeira{
            get{return bandeira;}
            set{bandeira = value;}
        }

        protected string token = "qwertyui";
        public string Token{
            get{return token;}
        }
        

        private string cvv;

        public string Cvv{
            get{return cvv;}
            set{cvv = value;}
        }

        protected float limite = 5000;
        public float Limite{
            get{return limite = 500;}
            set{limite = value;}
        }

        // metodos

        public string RegistrarCompra(bool validado){
            return "";
        }

        public void ExibirNome(string nome){
            System.Console.WriteLine($"O nome digitado foi: {nomeTitular} ");
    }
        public string ExibirNumeroCartao(string numero){
            return "";
    }
}
}