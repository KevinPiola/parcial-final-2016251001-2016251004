using System;
using System.Collections.Generic;
using System.Text;

namespace Tienda.DataAccess
{
    public class BaseRepository
    {
        public TiendaDBContext Context;

        public BaseRepository()
        {
            this.Context = new TiendaDBContext();
        }
    }
}
