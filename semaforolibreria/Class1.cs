using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace semaforolibreria
{
    public class Class1
    {
        private Thread thread;
        private Luz luzVerde;
        private Luz luzAmarilla;
        private Luz luzRoja;

        public string Nombre { get; set; }
        public string EstadoActual { get; private set; }

        public Class1(string nombre)
        {
            Nombre = nombre;
            luzVerde = new Luz("Luz Verde", 11);
            luzAmarilla = new Luz("Luz Amarilla", 12);
            luzRoja = new Luz("Luz Roja", 13);
        }

        public void Iniciar()
        {
            thread = new Thread(() =>
            {
                while (true)
                {
                    EstadoActual = "Verde";
                    luzVerde.Parpadear(3, 500);
                    EstadoActual = "Amarillo";
                    luzAmarilla.Encender(1000);   
                    EstadoActual = "Rojo";
                    luzRoja.Encender(1000);       
                }
            });

            thread.Start();
        }

        public void Detener()
        {
            thread?.Abort();
        }
    }
}