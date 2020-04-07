using System;
using System.Collections.Generic;
using System.Text;

namespace Venta_Vehiculos
{
    class MostrarVehiculo
    {
        static void Main(string[] args)
        {
            Vehiculo venta1 = new Vehiculo();
            Vehiculo venta2= new Vehiculo();

            Console.WriteLine("Ingrese la marca del vehiculo");
            venta1.Marca = Console.ReadLine();
            Console.WriteLine("Ingrese el modelo del vehiculo");
            venta1.Modelo = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Presione 1 para continuar, precione 2 agregar otro vehiculo");

            int validator = Int32.Parse(Console.ReadLine());
            if (validator == 1)
            {
                venta1.SetVehiculo(venta1.Marca, venta1.Modelo);
                venta1.VerVehiculo();
                return;
            }
            else if (validator == 2)
            {
                Console.WriteLine("Ingrese la marca del vehiculo");
                venta2.Marca = Console.ReadLine();
                Console.WriteLine("Ingrese el modelo del vehiculo");
                venta2.Modelo = Console.ReadLine();
                Console.Clear();

                venta1.SetVehiculo(venta1.Marca, venta1.Modelo);
                venta2.SetVehiculo(venta2.Marca, venta2.Modelo);
                venta1.VerVehiculo();
                venta2.VerVehiculo();

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid input");
                venta1.SetVehiculo(venta1.Marca, venta1.Modelo);
                venta1.VerVehiculo();
            }
        }


    }
}

