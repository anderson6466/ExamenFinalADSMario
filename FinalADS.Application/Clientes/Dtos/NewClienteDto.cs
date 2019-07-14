using System;

namespace FinalADS.Application.Clientes.Dtos
{
    public class NewClienteDto
    {

        public string Titulo { get; set; }
        public string Resumen { get; set; }
        public string Contenido { get; set; }
        public string Formato { get; set; }
        public DateTime Fechaenvio { get; set; }
        public DateTime Fechaacept { get; set; }

        public DateTime Fechapubli { get; set; }
        public int Account_id { get; set; }
        
        public NewClienteDto()
        {
            
        }
    }
}
