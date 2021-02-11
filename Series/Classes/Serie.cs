using System;
using System.Collections.Generic;
using System.Text;

namespace Series
{
    public class Serie:EntidadeBase
    {
        //Atribitos
        private Genero Genero { get; set; }

        private string Titulo { get; set; }

        private string Descricao { get; set; }

        private int Ano { get; set; }

        private bool Excluido { get; set; }
        //Metodos
        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            Id = id;
            Genero = genero;
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;
            Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Inicio: " + this.Ano;
            return retorno;
        }

        public string retornaTitulo() => this.Titulo;

        internal int retornaId() => this.Id;

        public void Excluir() => this.Excluido = true;

        public bool retornaExcluido() => this.Excluido;
    }
}
