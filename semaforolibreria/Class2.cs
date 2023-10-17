using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace semaforolibreria
{
    internal class Luz
    {
        private string nombre;
        private int pin;

        public Luz(string nombre, int pin)
        {
            this.nombre = nombre;
            this.pin = pin;
        }

        public void Encender(int duracion)
        {
            Console.WriteLine($"{nombre} encendida");

            Thread.Sleep(duracion);

            Console.WriteLine($"{nombre} apagada");
        }

        public void Parpadear(int veces, int intervalo)
        {
            for (int i = 0; i < veces; i++)
            {
                Encender(intervalo);
                Thread.Sleep(intervalo);
            }
        }
    }
}