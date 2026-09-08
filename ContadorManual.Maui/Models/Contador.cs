using System;
using System.Collections.Generic;
using System.Text;

namespace ContadorManual.Maui.Models
{
    public class Contador
    {
        private int _Conteo; //variable de instancia
        public int Conteo => _Conteo;
        public Contador() //constructor
         { 
            _Conteo= 0;
        }
     
        public void Contar()
        {
            _Conteo++;
        }
        public void Reiniciar()
        {
            _Conteo=0;
        }

    }
}
