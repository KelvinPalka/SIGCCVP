using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_Projeto_BD.Models
{
    public class Papel
    {
        public int Cod_papel {  get; private set; }
        public int Qntd_estocada { get; set; }
        public double Valor { get; set; }
        public int Id_estoque {  get; private set; }

        public Papel(int cod_papel, int qntd_estocada, double valor, int id_estoque)
        {
            Cod_papel = cod_papel;
            Qntd_estocada = qntd_estocada;
            Valor = valor;
            Id_estoque = id_estoque;
        }
    }
}
