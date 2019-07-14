using System;

namespace FinalADS.Application.Clientes.ViewModels
{
    public class ClienteDto
    {
        public long id { get; set; }
        public string titulo { get; set; }
        public string resumen { get; set; }
        public string contenido { get; set; }
        public string formato { get; set; }
        public DateTime fechaenvio { get; set; }
        public DateTime fechaacept { get; set; }
        public DateTime fechapubli { get; set; }

        public int Account_id { get; set; }

        public ClienteDto()
        {
        }
    }
}
