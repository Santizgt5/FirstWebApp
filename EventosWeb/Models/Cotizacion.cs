using System;
using System.ComponentModel.DataAnnotations;

namespace EventosWeb.Models
{
    public class Cotizacion
    {

        public int Id { get; set; }
        public string Necesidad { get; set; }
        public string Tipo { get; set; }
        public string Lugar { get; set; }

        [DataType(DataType.Date)]
        public DateTime Cuando { get; set; }
        public int NDeInvitados { get; set; }
        public string Descripcion { get; set; }

      




    }
}
