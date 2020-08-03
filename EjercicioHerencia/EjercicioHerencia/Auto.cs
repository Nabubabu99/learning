using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioHerencia
{
    class Auto : Vehiculo
    {
        public Auto(String auto) : base(auto)
        {

        }
        public override void Conducir()
        {
            Console.WriteLine("Lo conducen por ruta 4 y llegan a Concordia");
        }
    }
}
