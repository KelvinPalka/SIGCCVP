using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_Projeto_BD.Models
{
    public class Estoque
    {
        public int Id_estoque {  get; set; }
        public string Data {  get; set; }
        public string Local_armazenamento { get; set; }

        public Estoque(int id_estoque, string data, string local_armazenamento)
        {
            Id_estoque = id_estoque;
            Data = data;
            Local_armazenamento = local_armazenamento;
        }
    }
}
