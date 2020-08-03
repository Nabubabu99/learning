using System;

namespace EjercicioHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //Auto auto = new Auto("Fiat 147");
            //Avion avion = new Avion("T800");
            //Auto auto1 = new Auto("Fiat 147");
            //Auto auto2 = new Auto("Renault 12");
            //Auto auto3 = new Auto("Audi A3");
            //Auto auto4 = new Auto("Golf");
            //Auto auto5 = new Auto("Ford Ka");
            //Avion avion1 = new Avion("T800");
            //Avion avion2 = new Avion("Boeing 747");
            //Avion avion3 = new Avion("Airbus A320 neo");
            //Avion avion4 = new Avion("Bombardier CRJ 700");
            //Avion avion5 = new Avion("Airbus A380");

            //auto.Arrancar();
            //auto.Conducir();
            //auto.Parar();

            //avion.Arrancar();
            //avion.Conducir();
            //avion.Parar();
            var vehiculos = new Vehiculo[10];
            vehiculos[0] = new Auto("Fiat 147");
            vehiculos[1] = new Auto("Renault 12");
            vehiculos[2] = new Auto("Audi A3");
            vehiculos[3] = new Auto("Golf");
            vehiculos[4] = new Auto("Ford Ka");
            vehiculos[5] = new Avion("T800");
            vehiculos[6] = new Avion("Boeing 747");
            vehiculos[7] = new Avion("Airbus A320 neo");
            vehiculos[8] = new Avion("Bombardier CRJ 700");
            vehiculos[9] = new Avion("Airbus A380");

            ProbarVehiculos(vehiculos);
        }
        static public void ProbarVehiculos(Vehiculo[] vehiculos)
        {
            // Recibe un array de vehiculos y los arranca, los conduce y los para(Que haya 5 autos y 5 aviones)
            for (int i = 0; i <= 9; i++)
            {
                vehiculos[i].Arrancar();
                vehiculos[i].Conducir();
                vehiculos[i].Despegar();
                vehiculos[i].Volar();
                vehiculos[i].Aterrizar();
                vehiculos[i].Parar();
            }
        }
    }
}
