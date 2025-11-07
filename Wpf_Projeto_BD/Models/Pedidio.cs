using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_Projeto_BD.Models
{
    public class Pedidio
    {
        public int Id_pedido { get; private set; }
        public string Data_pedido { get; set; }
        public string Data_entrega { get; private set; }
        public int Qntd {  get; set; }
        public double Valor { get; set; }
        public string Status_pedido { get; set; }
        public string Descricao { get; set; }
        public int Id_cliente { get; private set; }
        public int Id_produto { get; private set; }

        public Pedidio(int id_pedido, string data_pedido, string data_entrega, int qntd, double valor, string status_pedido, string descricao, int id_cliente, int id_produto)
        {
            Id_pedido = id_pedido;
            Data_pedido = data_pedido;
            Data_entrega = data_entrega;
            Qntd = qntd;
            Valor = valor;
            Status_pedido = status_pedido;
            Descricao = descricao;
            Id_cliente = id_cliente;
            Id_produto = id_produto;
        }


    }
}
