using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiraAtividade.Classe
{
     class Email
    {
        private string _email;
        private string _dominio;

        public Email(string email, string dominio)
        {
            _email = email;
            _dominio = dominio;
        }

        public string getEmail() => _email;
        public string getDominio() => _dominio;

    }
}
