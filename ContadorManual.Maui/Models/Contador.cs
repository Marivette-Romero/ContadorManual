using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

//22/09/2026: Actualizacion a enlace de datos a un objeto de datos.
namespace ContadorManual.Maui.Models
{
    public class Contador :INotifyPropertyChanged //agregar esto 22/09
    {
        private int _Conteo; //variable de instancia
        private int _Incremento; // 23/09/2026: Nueva variable de instancia

        public event PropertyChangedEventHandler? PropertyChanged; //Linea Nueva 22/09 : Metodo

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

        //Nuevo metodo
        public int Incremento
        {
            get => _Incremento;
            set
            {
                if (_Incremento != value)
                {
                    _Incremento = value;
                }
            }
        }

        // 23/09/2026: Nuevo Constructor
        public Contador (int ValorInicial =0 , int incremento=1)
        {
            Conteo =ValorInicial;
            Incremento =incremento;
        }

        public Contador() //constructor
         { 
            Conteo= 0;
        }
     
        public void Contar()
        {
            Conteo= Conteo +Incremento; //Modificamos 23/09/2023
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
