using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Tickets
    {
        public int NumeroTicket { get; set; }
        public DateTime Fecha { get; set; }
        public string CodigoUsuario { get; set; }
        public string IdentidadCliente { get; set; }
        public string TipoSoporte { get; set; }
        public string DescripcionSolicitud { get; set; }
        public string DescripcionRespuesta { get; set; }
        public decimal Precio { get; set; }
        public decimal Impuesto { get; set; }
        public decimal Descuento { get; set; }
        public decimal Total { get; set; }

        public Tickets()
        {
        }

        public Tickets(int numeroTicket, DateTime fecha, string codigoUsuario, string identidadCliente, 
            string tipoSoporte, string descripcionSolicitud, string descripcionRespuesta, decimal precio, 
            decimal impuesto, decimal descuento, decimal total)
        {
            NumeroTicket = numeroTicket;
            Fecha = fecha;
            CodigoUsuario = codigoUsuario;
            IdentidadCliente = identidadCliente;
            TipoSoporte = tipoSoporte;
            DescripcionSolicitud = descripcionSolicitud;
            DescripcionRespuesta = descripcionRespuesta;
            Precio = precio;
            Impuesto = impuesto;
            Descuento = descuento;
            Total = total;
        }
    }
}
