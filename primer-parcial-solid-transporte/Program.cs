using System;
using System.Collections.Generic;

namespace primer_parcial_solid_transporte
{
    class Program
    {
        static void Main(string[] args)
        {

            List<ITransporte> transportesTerrestres = new List<ITransporte>();
            List<ITransporteAereo> transportesAereo = new List<ITransporteAereo>();

            TransporteRepository transporteRepository = new TransporteRepository();

            Avion avion1 = new Avion("AVION 01",0,100,0,100);
            transportesAereo.Add(avion1);

            Avion avion2 = new Avion("AVION 02",0,100,0,100);
            transportesAereo.Add(avion2);

            Tren tren1 = new Tren("TREN 01",0,100);
            transportesTerrestres.Add(tren1);

            transporteRepository.guardar(avion1);
            transporteRepository.guardar(avion2);
            transporteRepository.guardar(tren1);

            Console.WriteLine("Inicio del viaje :)");

            foreach (ITransporteAereo transporte in transportesAereo)
            {
                    transporte.Volar(10);
                    transporte.Acelerar(10);
            }

            foreach (ITransporte transporte in transportesTerrestres)
            {
                transporte.Acelerar(10);
            }

            Console.WriteLine("Fin del viaje :)");
        }
    }
}
