using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Prueba
{
    public class PersonaINotify : INotifyPropertyChanged
    {
        //Propiedades
        //En caso de que se cambie el valor, se debe llamar al método que lanza el evento PropertyChanged
        private string _nombre;
        public string Nombre
        {
            get { return this._nombre; }
            set
            {
                if (this._nombre != value)
                {
                    this._nombre = value;
                    this.NotifyPropertyChanged("Nombre");
                }
            }
        }

        private int _edad;
        public int Edad
        {
            get { return this._edad; }
            set
            {
                if (this._edad != value)
                {
                    this._edad = value;
                    this.NotifyPropertyChanged("Edad");
                }
            }
        }

        //Constructores
        public PersonaINotify()
        {
            Nombre = "";
            Edad = 0;
        }
        public PersonaINotify(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        //Implementación de la interfaz INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public override string ToString()
        {
            return Nombre + " - " + Edad;
        }
    }
}
