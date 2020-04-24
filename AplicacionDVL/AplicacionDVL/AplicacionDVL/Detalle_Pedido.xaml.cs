using AplicacionDVL.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AplicacionDVL
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Detalle_Pedido : ContentPage
    {
        public Detalle_Pedido(string json)
        {
            InitializeComponent();
            Pedido elegido = JsonConvert.DeserializeObject<Pedido>(json);

            elegido.TotalLitros += " Totales";
            elegido.OracionMagna += " Magna";
            elegido.OracionPremium += " Premium";
            elegido.OracionDiesel += " Diesel";

            Folio.SetBinding(Label.TextProperty, "Folio_Pedido");
            Folio.BindingContext = elegido;

            ValorEstacion.SetBinding(Label.TextProperty, "Nombre_Estacion");
            ValorEstacion.BindingContext = elegido;

            FechaAgendada.SetBinding(Label.TextProperty, "Fecha_Programada");
            FechaAgendada.BindingContext = elegido;

            Total.SetBinding(Label.TextProperty, "TotalLitros");
            Total.BindingContext = elegido;

            Diesel.SetBinding(Label.TextProperty, "OracionDiesel");
            Diesel.BindingContext = elegido;

            Premium.SetBinding(Label.TextProperty, "OracionPremium");
            Premium.BindingContext = elegido;

            Magna.SetBinding(Label.TextProperty, "OracionMagna");
            Magna.BindingContext = elegido;


            ValorAutanque.SetBinding(Label.TextProperty, "Autotanque");
            ValorAutanque.BindingContext = elegido;

            FechaRegistro.SetBinding(Label.TextProperty, "Fecha_Registro");
            FechaRegistro.BindingContext = elegido;
        }
    }
}