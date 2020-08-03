using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioHerencia
{
    class Avion : Vehiculo
    {
        public Avion(String avion) : base(avion)
        {

        }
        public override void Conducir()
        {
            Console.WriteLine("Salen de Buenos Aires hacia Canadá");
        }
    }
}
