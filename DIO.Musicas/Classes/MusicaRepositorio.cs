using System;
using System.Collections.Generic;
using System.Text;
using DIO.Musicas.Interface;

namespace DIO.Musicas
{
    class MusicaRepositorio : IRepositorio<Musica>
    {
        private List<Musica> listaMusica = new List<Musica>();
        public void Atualiza(int Id, Musica objecto)
        {
            listaMusica[Id] = objecto;
        }

        public void Exclui(int id)
        {
            listaMusica[id].Excluir();
        }

        public void Inserir(Musica objecto)
        {
            listaMusica.Add(objecto);
        }

        public List<Musica> Listas()
        {
            return listaMusica;
        }

        public int ProximoId()
        {
            return listaMusica.Count;
        }

        public Musica RetornaPorID(int id)
        {
            return listaMusica[id];
        }
    }
}
