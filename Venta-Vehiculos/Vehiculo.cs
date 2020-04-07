using System;
using System.Collections.Generic;
using System.Text;

namespace Venta_Vehiculos
{
    class Vehiculo
    {
        public string Marca { set; get; }
        public string Modelo { get; set; }


        public void SetVehiculo(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }

        public void VerVehiculo()
        {
          Console.WriteLine("El vehículo es {0} {1}", Marca, Modelo);
        }



    }
}
