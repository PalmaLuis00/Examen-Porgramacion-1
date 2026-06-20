using System;

namespace Hotel.App
{
    class Program
    {
        static void Main()
        {
            global::Hotel.Models.Hotel hotel = new global::Hotel.Models.Hotel();

            var r1 = new global::Hotel.Models.Reserva
            {
                Cliente = "Luis",
                FechaIngreso = DateTime.Now,
                FechaSalida = DateTime.Now.AddDays(3),
                PrecioPorNoche = 200
            };

            hotel.RegistrarReserva(r1);

            hotel.ListarReservas();
            Console.WriteLine($"Ingreso total: Q{hotel.CalcularIngresoTotal()}");
            Console.WriteLine($"Reserva más larga: {hotel.ReservaMayorDuracion()?.Cliente}");
        }
    }
}