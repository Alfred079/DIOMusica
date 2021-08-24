using System;
using System.Collections.Generic;
using System.Text;

namespace DIO.Musicas
{
    public class Musica : EntidadeBase
    {
        //Atributos 
        private string Artista { get; set; }
        private string Titulo { get; set; }
        private string Album { get; set; }
        private int DataLancamento { get; set; }
        private Genero Genero { get; set; }
        private bool Excluido { get; set; }
        
        public Musica(int id, string artista,string titulo, string album, int dataLancamento, Genero genero)
        {
            this.Id = id;
            this.Artista = artista;
            this.Titulo = titulo;
            this.Album = album;
            this.DataLancamento = dataLancamento;
            this.Genero = genero;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string retoro = "";
            retoro += "Artista: " + this.Artista + Environment.NewLine;
            retoro += "Titulo: " + this.Titulo + Environment.NewLine;
            retoro += "Album: " + this.Album + Environment.NewLine;
            retoro += "Ano: " + this.DataLancamento + Environment.NewLine;
            retoro += "Genero: " + this.Genero + Environment.NewLine;
            retoro += "Artista: " + this.Excluido;
            return retoro;
        }

        public int retornaID()
        {
            return this.Id;
        }
        public string retornaTitulo()
        {
            return this.Titulo;
        }
        public bool retornaExcluido()
        {
            return this.Excluido;
        }
        public void Excluir()
        {
            this.Excluido = true;
        }
    }

}
