using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SegundaTarea
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pincipal : ContentPage
    {
        public IList<Listado> listados { get; private set; }
        public Pincipal()
        {
            InitializeComponent();

            listados = new List<Listado>();
            listados.Add(new Listado()
            {
                Nombre = "Pescado Frito",
                Categoria = "Frituras",
                Detalle = "Carne, Lechuga, Tomate, Papa",
                Precio = "S/. 28",
                url = "Pescado.png"
            });

 

            listados.Add(new Listado()
            {
                Nombre = "Pizza Familiar",
                Categoria = "Pizza",
                Detalle = "Carne, Lechuga, Tomate, Papa",
                Precio = "S/. 26",
                url = "Pizza.png"
            });

            listados.Add(new Listado()
            {
                Nombre = "Hamburguesa Clasica",
                Categoria = "Hamburguesa",
                Detalle = "Carne, Lechuga, Tomate, Papa",
                Precio = "S/. 16",
                url = "burger.png"
            });

            listados.Add(new Listado()
            {
                Nombre = "Ceviche Mixto",
                Categoria = "Ceviche",
                Detalle = "Pota",
                Precio = "S/. 35",
                url = "Ceviche.png" +
                "" +
                ""
            });


            listados.Add(new Listado()
            {
                Nombre = "Papitas Fritas",
                Categoria = "Frituras",
                Detalle = "Papas",
                Precio = "S/. 18",
                url = "PorcionPapitas.png" 
              
            });


            listados.Add(new Listado()
            {
                Nombre = "Inka Kola",
                Categoria = "Gaseosa",
                Detalle = "Pota",
                Precio = "S/. 12",
                url = "Inka.png" 
            
            });



            BindingContext = this;
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var listados = ((ListView)sender).SelectedItem as Listado;
            if (listados == null)
                return;
            await DisplayAlert("SELECT SOFFE", listados.Nombre, "ok");

        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            ((ListView)sender).SelectedItem = null;

        }
    }
}