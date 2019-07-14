using FinalADS.Domain.Clientes.Constants;
using Common;
using System;

namespace FinalADS.Domain.Clientes.Entities
{
    public class Articulo : Entity
    {   
        public virtual string Titulo { get; set; }
        public virtual string Resumen { get; set; }
        public virtual string Contenido { get; set; }
        public virtual string Formato { get; set; }
        public virtual DateTime Fechaenvio { get; set; }
        public virtual DateTime Fechaacept { get; set; }
        public virtual DateTime Fechapubli { get; set; }

        public virtual int Account_id { get; set; }
        
        public Articulo()
        {
        }
       
    }
}
