using System;

namespace EjercicioHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //Auto auto = new Auto("Fiat 147");
            //Avion avion = new Avion("T800");
            Auto auto1 = new Auto("Fiat 147");
            Auto auto2 = new Auto("Renault 12");
            Auto auto3 = new Auto("Audi A3");
            Auto auto4 = new Auto("Golf");
            Auto auto5 = new Auto("Ford Ka");
            Avion avion1 = new Avion("T800");
            Avion avion2 = new Avion("Boeing 747");
            Avion avion3 = new Avion("Airbus A320 neo");
            Avion avion4 = new Avion("Bombardier CRJ 700");
            Avion avion5 = new Avion("Airbus A380");

            //auto.Arrancar();
            //auto.Conducir();
            //auto.Parar();

            //avion.Arrancar();
            //avion.Conducir();
            //avion.Parar();
            Vehiculo[] vehiculos = new Vehiculo[10];
            vehiculos[0] = auto1;
            vehiculos[1] = auto2;
            vehiculos[2] = auto3;
            vehiculos[3] = auto4;
            vehiculos[4] = auto5;
            vehiculos[5] = avion1;
            vehiculos[6] = avion2;
            vehiculos[7] = avion3;
            vehiculos[8] = avion4;
            vehiculos[9] = avion5;

            ProbarVehiculos(vehiculos);
        }
        static public void ProbarVehiculos(Vehiculo[] vehiculos)
        {
            // Recibe un array de vehiculos y los arranca, los conduce y los para(Que haya 5 autos y 5 aviones)
            for (int i = 0; i <= 9; i++)
            {
                vehiculos[i].Arrancar();
                vehiculos[i].Conducir();
                vehiculos[i].Parar();
            }
        }
        
    }
}
