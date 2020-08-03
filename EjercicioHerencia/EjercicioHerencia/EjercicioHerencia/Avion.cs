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
        public override void Despegar()
        {
            Console.WriteLine("El avion hace el despegue");
        }
        public override void Volar()
        {
            Console.WriteLine("El avion está volando");
        }
        public override void Aterrizar()
        {
            Console.WriteLine("El avion aterriza");
        }
    }
}
