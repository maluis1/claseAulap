using System;

namespace claseAulap
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo auto = new Vehiculo();
            auto.IngresarVehiculo();
            auto.ImprimirVehiculo();
            auto.ModificarVehiculo("BMW");
            auto.ImprimirVehiculo();

        }
    }
}
