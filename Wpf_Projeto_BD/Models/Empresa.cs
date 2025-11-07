using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_Projeto_BD.Models
{
    public class Empresa
    {
        public int Id_empresa {get; private set;}
        public string CNPJ {get; private set;}
        public string Nome_fantasia {get; private set;}
        public string Email {get; private set;}
        public string Telefone {get; private set;}
        public string Razao_social {get; private set;}
        public string Endereco {get; private set;}

        public Empresa(int id_empresa, string cnpj, string nome_fantasia, string email, string telefone, string razao_social, string endereco)
        {
            Id_empresa = id_empresa;
            CNPJ = cnpj;
            Nome_fantasia = nome_fantasia;
            Email = email;
            Telefone = telefone;
            Razao_social = razao_social;
            Endereco = endereco;
        }
    }
}
