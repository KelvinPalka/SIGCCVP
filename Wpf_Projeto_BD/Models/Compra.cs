using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_Projeto_BD.Models
{
    public class Compra
    {
        public int Id_compra {  get; private set; }
        public int Qntd { get; set; }
        public double Valor { get; set; }
        public int Id_cliente {  get; set; }

        public Compra(int id_compra, int qntd, double valor, int id_cliente)
        {
            Id_compra = id_compra;
            Qntd = qntd;
            Valor = valor;
            Id_cliente = id_cliente;
        }
    }
}
