using App_Xamarin_AB.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using App_Xamarin_AB.Repository;
namespace App_Xamarin_AB.ViewModel
{
    class EmpleadosYPromedioViewModel: ClaseBase
    {
        private ObservableCollection<EmpleadosModel> _ListaEmpleados;

        public ObservableCollection<EmpleadosModel> ListaEmpleados
        {
            get { return _ListaEmpleados; }
            set { _ListaEmpleados = value; OnPropertyChanged(); }
        }

        private AmountModel _CalcularPromerdio;

        public AmountModel CalcularPromerdio
        {
            get { return _CalcularPromerdio; }
            set { _CalcularPromerdio = value; OnPropertyChanged(); }
        }

        public Repositorio Repo { get; set; }
        public EmpleadosYPromedioViewModel()
        {
            Repo = new Repositorio();
            ObtenerEmpleados();
            CalcularPromerdio = new AmountModel();
            
        }

        private async void ObtenerEmpleados()
        {
            var ListaTemporal = await Repo.ObtenerItems();
            ListaEmpleados = new ObservableCollection<EmpleadosModel>(ListaTemporal);
        }
    }
}
