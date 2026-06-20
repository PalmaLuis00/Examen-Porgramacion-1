using System;
using System.Collections.Generic;
using System.Linq;

namespace Hotel.Models
{
    public class Hotel
    {
        private List<Reserva> reservas = new List<Reserva>();

        public void RegistrarReserva(Reserva r) => reservas.Add(r);

        public void ListarReservas()
        {
            foreach (var r in reservas)
                Console.WriteLine($"{r.Cliente} - {r.Duracion} noches - Q{r.CalcularCosto()}");
        }

        public double CalcularIngresoTotal() => reservas.Sum(r => r.CalcularCosto());

       public Reserva? ReservaMayorDuracion() => reservas.OrderByDescending(r => r.Duracion).FirstOrDefault();
    }
}
