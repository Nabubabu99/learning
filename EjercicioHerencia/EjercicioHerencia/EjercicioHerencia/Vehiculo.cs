using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioHerencia
{
    abstract class Vehiculo
    {
        public Vehiculo()
        {

        }
        public Vehiculo(String vehiculo)
        {
            this.vehiculo = vehiculo;
        }
        public void Arrancar()
        {
            Console.WriteLine($"Se arrancó el motor del {vehiculo}");
        }
        public void Parar()
        {
            Console.WriteLine($"Se paró el motor del {vehiculo}");
        }
        abstract public void Conducir();
        public virtual void Despegar()
        {  
        }
        public virtual void Volar()
        {
        }
        public virtual void Aterrizar()
        {
        }
        private String vehiculo;
    }
}
