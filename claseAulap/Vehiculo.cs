using System;
using System.Collections.Generic;
using System.Text;

namespace claseAulap
{
    class Vehiculo
    {
        #region propiedades
        public string  Color { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Chasis { get; set; }

        #endregion
        #region Constructores
        public Vehiculo(string color,string marca, string modelo,int  chasis)
        {
            Color = color;
            Marca = marca;
            Modelo = modelo;
            Chasis = chasis;
        }
        public Vehiculo(  string modelo, int chasis)
        {
            Modelo = modelo;
            Chasis = chasis;
        }
        public Vehiculo()
        {

        }
        #endregion
        #region Metodos
       public void IngresarVehiculo()
        {
            Console.WriteLine("Digite el color del vehiculo");
            Color = Console.ReadLine();
            Console.WriteLine("Digite el marca del vehiculo");
            Marca = Console.ReadLine();
            Console.WriteLine("Digite el modelo del vehiculo");
             Modelo = Console.ReadLine();
            Console.WriteLine("Digite el chasis del vehiculo");
            Chasis = int.Parse( Console.ReadLine());
        }
        public void ImprimirVehiculo()
        {
            Console.WriteLine($"Color:{Color}");
            Console.WriteLine($"Marca:{Marca}");
            Console.WriteLine($"Modelo:{Modelo}");
            Console.WriteLine($"Chasis:{Chasis}");

        }
        public void ModificarVehiculo(string m)
        {
            Marca = m;
        }
        #endregion
    }
}
