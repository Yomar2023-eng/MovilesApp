using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace SegundaTarea
{
   public class Listado
    {
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public string Detalle { get; set; }
        
        public string Precio  { get; set; }

        public string url { get; set; }

        public override string ToString()
        {
            return Categoria;
        }
    }

   
}
