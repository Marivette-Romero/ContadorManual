using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ContadorManual.Maui.Models
{
    public class Contador :INotifyPropertyChanged //agregar esto 22/09
    {
        private int _Conteo; //variable de instancia

        public event PropertyChangedEventHandler? PropertyChanged; //Linea Nueva 22/09

        //Modificamos:
        public int Conteo
        {
            get => _Conteo;
            set
            {
                if (_Conteo != value)
                {
                    _Conteo=value;
                    OnPropertyChanged(nameof(Conteo));  
                }
            }
        }
        
        public Contador() //constructor
         { 
            Conteo= 0;
        }
     
        public void Contar()
        {
            Conteo++;
        }
        public void Reiniciar()
        {
            Conteo=0;
        }

        //Nuevo metodo: 
        private void OnPropertyChanged(string propertyName)
        {
           if( PropertyChanged != null )
            {
                PropertyChanged.Invoke( this, new PropertyChangedEventArgs( propertyName ) );
            }
        }

    }
}
