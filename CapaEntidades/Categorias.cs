using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Categorias
    {
        private int idCategoria;
        private string categoria;

        public Categorias(int idCategoria, string categoris)
        {
            this.IdCategoria = idCategoria;
            this.Categoria = categoria;
        }

        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public string Categoria { get => categoria; set => categoria = value; }

    }
}
