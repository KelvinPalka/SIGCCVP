using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_Projeto_BD.Models
{
    public class Fornecedor
    {
        public string Id_fornecedor {  get; private set; }
        public string CPF_CNPJ { get; private set; }
        public string Nome { get; private set; }
        public string Email {  get; private set; }
        public string Telefone { get; private set; }

        public Fornecedor(string id_fornecedor, string cPF_CNPJ, string nome, string email, string telefone)
        {
            Id_fornecedor = id_fornecedor;
            CPF_CNPJ = cPF_CNPJ;
            Nome = nome;
            Email = email;
            Telefone = telefone;
        }
    }
}
