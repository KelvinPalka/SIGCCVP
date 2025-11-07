using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_Projeto_BD.Models
{
    public class Transportadora
    {
        public int Id_transportadora {  get; private set; }
        public string CNPJ {  get; private set; }
        public string Nome_fantasia { get; private set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Razao_social { get; set; }
        public string Endereco { get; set; }

        public Transportadora(int id_transportadora, string cNPJ, string nome_fantasia, string email, string telefone, string razao_social, string endereco)
        {
            Id_transportadora = id_transportadora;
            CNPJ = cNPJ;
            Nome_fantasia = nome_fantasia;
            Email = email;
            Telefone = telefone;
            Razao_social = razao_social;
            Endereco = endereco;
        }
    }
}
