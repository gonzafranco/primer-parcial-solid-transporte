using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primer_parcial_solid_transporte
{
    public class Avion : ITransporteAereo
    {
        private string nombre;
        private int velocidadActual;
        private int velocidadMaxima;
        private int alturaActual;
        private int alturaMaxima;

        public Avion(string nombre, int velocidadActual, int velocidadMaxima, int alturaActual, int alturaMaxima)
        {
            this.nombre = nombre;
            this.velocidadActual = velocidadActual;
            this.velocidadActual = velocidadMaxima;
            this.alturaActual = alturaActual;
            this.alturaMaxima = alturaMaxima;

        }

        public void Acelerar(int velocidad)
        {
            if ((this.velocidadActual + velocidad) <= this.velocidadMaxima)
            {
                this.velocidadActual += velocidad;
            }
        }

        public void Desacelerar(int velocidad)
        {
            if ((this.velocidadActual - velocidad) >= 0)
            {
                this.velocidadActual -= velocidad;
            }
            else
            {
                this.velocidadActual = 0;
            }
        }

        public void Volar(int altitud)
        {
            if ((this.alturaActual + altitud) < 0)
            {
                this.alturaActual = 0;
            }
            else if ((this.alturaActual + altitud) > this.alturaMaxima)
            {
                this.alturaActual = this.alturaMaxima;
            }
            else
            {
                this.alturaActual += altitud;
            }
        }


     
    }
}
