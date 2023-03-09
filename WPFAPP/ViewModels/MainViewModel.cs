using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFAPP.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private ViewModelBase _currentChildView;
        private string _caption;

        //Propiedades
        public ViewModelBase CurrentChildView
        {
            get
            {
                return _currentChildView;
            }
            set
            {
                _currentChildView = value;
                OnPropertyChanged(nameof(CurrentChildView));
            }
        }
        public string Caption
        {
            get
            {
                return _caption;
            }
            set
            {
                _caption = value;
                OnPropertyChanged(nameof(Caption));
            }
        }

        // Comandos
        public ICommand ShowInicioViewCommand { get; }
        public ICommand ShowPrestamosViewCommand { get; }

        public MainViewModel()
        {

            //Initialize commands
            ShowInicioViewCommand = new ViewModelCommand(ExecuteShowInicioViewCommand);
            ShowPrestamosViewCommand = new ViewModelCommand(ExecuteShowPrestamosViewCommand);


            //Default view
            ExecuteShowInicioViewCommand(null);
            


        }
        private void ExecuteShowInicioViewCommand(object obj)
        {
            CurrentChildView = new InicioViewModel();
            Caption = "Inicio";
            
        }
        private void ExecuteShowPrestamosViewCommand(object obj)
        {
            CurrentChildView = new PrestamosViewModel();
            Caption = "Préstamos";

        }
    }
}
