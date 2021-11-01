using System;

namespace CursoEstruturasDados_OOP
{
    interface IEstruturasDados
    {
        int LimiteSuperior { get; set; }
        bool Vazia { get; set; }
        bool Cheia { get; set; }
    }
}