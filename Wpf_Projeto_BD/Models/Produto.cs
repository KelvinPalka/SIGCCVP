using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_Projeto_BD.Models
{
    public class Produto
    {
        public int Id_produto { get; private set; }
        public int Cod_papel { get; private set; }
        public int Cod_tecido { get; private set; }
        public int Cod_linha { get; private set; }
        public int Cod_fio { get; private set; }
        public int Cod_Tinta { get; private set; }

        public Produto(int id_produto, int cod_papel, int cod_tecido, int cod_linha, int cod_fio, int cod_Tinta)
        {
            Id_produto = id_produto;
            Cod_papel = cod_papel;
            Cod_tecido = cod_tecido;
            Cod_linha = cod_linha;
            Cod_fio = cod_fio;
            Cod_Tinta = cod_Tinta;
        }


    }
}
