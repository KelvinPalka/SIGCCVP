using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_Projeto_BD.Models
{
    public class Despesa
    {
        public string Id_despesa { get; private set; }
        public string Descricao { get; set; }
        public string Data_despesa { get; set; }
        public string Data_vencimento { get; set; }
        public string Data_pagamento { get; set; }
        public string Tipo { get; set; }
        public double Valor { get; set; }
        public string Forma_de_pagamento { get; set; }

        public Despesa(string id_despesa, string descricao, string data_despesa, string data_vencimento, string data_pagamento, string tipo, double valor, string forma_de_pagamento)
        {
            Id_despesa = id_despesa;
            Descricao = descricao;
            Data_despesa = data_despesa;
            Data_vencimento = data_vencimento;
            Data_pagamento = data_pagamento;
            Tipo = tipo;
            Valor = valor;
            Forma_de_pagamento = forma_de_pagamento;
        }
    }
}