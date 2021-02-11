using System;
using System.Collections.Generic;
using System.Text;
using Series.Interfaces;

namespace Series.Classes
{
    /*public class FilmeRepositorio : IRepositorio<Filme>
    {
        void IRepositorio<Filme>.Atualiza(int id, ThreadStaticAttribute entidade)
        {
            throw new NotImplementedException();
        }

        void IRepositorio<Filme>.Exclui(int id)
        {
            throw new NotImplementedException();
        }

        void IRepositorio<Filme>.Insere(Filme entidade)
        {
            throw new NotImplementedException();
        }

        List<Filme> IRepositorio<Filme>.Lista()
        {
            throw new NotImplementedException();
        }

        int IRepositorio<Filme>.ProximoId()
        {
            throw new NotImplementedException();
        }

        Filme IRepositorio<Filme>.RetornaPorId(int id)
        {
            throw new NotImplementedException();
        }
    }*/

    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();
        public void Atualiza(int id, Serie objeto) => listaSerie[id] = objeto;

        public void Exclui(int id) => listaSerie[id].Excluir();

        public void Insere(Serie objeto) => listaSerie.Add(objeto);

        public List<Serie> Lista() => listaSerie;

        public int ProximoId() => listaSerie.Count;

        public Serie RetornaPorId(int id) => listaSerie[id];
    }
}
