using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Practica_2__Desarrollo_web_ASP.NET_Core_.Pages
{
    public class Nomina_de_EmpleadosModel : PageModel
    {

        public string Nombre { get; set; }

        public void OnGet(string nombre)
        {
            this.Nombre = nombre;

        }
    }
}
