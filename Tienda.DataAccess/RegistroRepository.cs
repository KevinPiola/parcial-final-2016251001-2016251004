using Tienda.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tienda.DataAccess
{
    public class RegistroRepository : BaseRepository
    {
        public IQueryable<Registro> Registros => this.Context.Registros;

        public bool Existe(Registro registro)
        {
            Registro existente = this.Context.Registros.FirstOrDefault(x => x.RegistroId == registro.RegistroId);
            return existente != null;
        }

        public bool Guardar(Registro registro)
        {
            this.Context.Registros.Add(registro);
            return this.Context.SaveChanges() > 0;
        }

        public bool Delete(int registroId)
        {
            //Consultamos el objeto anterior
            var anterior = this.Context.Registros.FirstOrDefault(x => x.RegistroId == registroId);
            //Se elimina el objeto
            this.Context.Registros.Remove(anterior);
            //Se guardan los cambios
            return this.Context.SaveChanges() > 0;
        }
    }
    

}
