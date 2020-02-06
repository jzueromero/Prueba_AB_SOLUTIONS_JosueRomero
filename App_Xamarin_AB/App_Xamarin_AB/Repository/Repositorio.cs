using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using App_Xamarin_AB.Model;
using Newtonsoft.Json;

namespace App_Xamarin_AB.Repository
{
    public class Repositorio
    {
        HttpClient Cliente;
        string Controlador;
        List<EmpleadosModel> ListaItems { get; set; }

        public Repositorio()
        {
            Cliente = new HttpClient();
            Controlador = "Employees/";
        }

        public async Task<List<EmpleadosModel>> ObtenerItems()
        {
            ListaItems = new List<EmpleadosModel>();

            var uri = new Uri(string.Format(Servidor.URL + Controlador, string.Empty));
            try
            {
                var response = await Cliente.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    ListaItems = JsonConvert.DeserializeObject<List<EmpleadosModel>>(content);
                }
            }
            catch (Exception ex)
            {
            }

            return ListaItems;
        }
    }
}
