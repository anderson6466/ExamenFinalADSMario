using FinalADS.Domain.Accounts.Constants;
using Common;

namespace FinalADS.Domain.Accounts.Entities
{
    public class Autor : Entity
    {
        public virtual string Nombres { get; set; }
        public virtual string Apellidos { get; set; }
        public virtual string Institucion { get; set; }

        public virtual int Nroarticulos { get; set; }

        public Autor()
        {
        }

        

    }
}
