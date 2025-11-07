using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_Projeto_BD.Models
{
    public class Linha
    {
        public int Cod_linha { get; private set; }
        public string Cor { get; set; }
        public double Qntd_estocada {get; set;}
        public double Valor { get; set;}

        public int Id_estoque { get; }

        public Linha(int cod_linha, string cor, double qntd_estocada, double valor, int id_estoque)
        {
            Cod_linha = cod_linha;
            Cor = cor;
            Qntd_estocada = qntd_estocada;
            Valor = valor;
            Id_estoque = id_estoque;
        }
    }
}
