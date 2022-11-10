using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    class MainWindowVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<String> provincias;

        public ObservableCollection<String> Provincias
        {
            get { return provincias; }
            set 
            { 
                provincias = value;
                NotifyPropertyChanged("Provincias");
            }
        }

        private String provinciaSelecccionada;

        public String ProvinciaSeleccionada
        {
            get { return provinciaSelecccionada; }
            set 
            { 
                provinciaSelecccionada = value;
                NotifyPropertyChanged("ProvinciaSeleccionada");
            }
        }

        private ObservableCollection<PersonaINotify> personas;

        public ObservableCollection<PersonaINotify> Personas
        {
            get { return personas; }
            set 
            { 
                personas = value;
                NotifyPropertyChanged("Personas");
            }
        }

        private PersonaINotify personaSeleccionada;

        public PersonaINotify PersonaSeleccionada
        {
            get { return personaSeleccionada; }
            set 
            { 
                personaSeleccionada = value;
                NotifyPropertyChanged("PersonaSeleccionada");
            }
        }


        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public MainWindowVM()
        {
            Provincias = new ObservableCollection<string>();
            Personas = new ObservableCollection<PersonaINotify>();

            Provincias.Add("Alicante");
            Provincias.Add("Valencia");
            Provincias.Add("Castellón");

            Personas.Add(new PersonaINotify("Jose", 20));
            Personas.Add(new PersonaINotify("Javier", 24));
            Personas.Add(new PersonaINotify("Ian", 21));
        }

        public void AnexionarMurcia()
        {
            if (!Provincias.Contains("Murcia"))
            {
                Provincias.Add("Murcia");
            }
        }
    }
}
