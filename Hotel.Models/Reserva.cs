using System;

namespace Hotel.Models
{
    public class Reserva
    {
        public string Cliente { get; set; } = string.Empty;
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaSalida { get; set; }
        public double PrecioPorNoche { get; set; }

        public int Duracion => (FechaSalida - FechaIngreso).Days;

        public double CalcularCosto() => Duracion * PrecioPorNoche;
    }
}
