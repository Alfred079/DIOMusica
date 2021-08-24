using System;
using System.Collections.Generic;
using System.Text;

namespace DIO.Musicas.Interface
{
    interface IRepositorio<T>
    {
        List<T> Listas();
        T RetornaPorID(int id);
        void Inserir(T entidade);
        void Exclui(int id);
        void Atualiza(int Id, T enridade);
        int ProximoId();
    }
}
