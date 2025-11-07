using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_Projeto_BD.Models
{
    public class Entrega
    {
        public int Id_entrega {  get;  private set; }
        public string Data_Entrega { get; private set; }
        public string Status_entrega { get; set; }
        public int Id_transportadora { get; private set; }
        public int Id_pedido { get; private set; }

        public Entrega(int id_entrega, string data_Entrega, string status_entrega, int id_transportadora, int id_pedido)
        {
            Id_entrega = id_entrega;
            Data_Entrega = data_Entrega;
            Status_entrega = status_entrega;
            Id_transportadora = id_transportadora;
            Id_pedido = id_pedido;
        }
    }
}
