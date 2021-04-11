using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SolucionIoT.BIZ;
using SolucionIoT.COMMON.Entidades;
using SolucionIoT.COMMON.Interfaces;
using SolucionIoT.COMMON.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolucionIoT.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        [BindProperty]
        public Login Login { get; set; }
        [BindProperty]
        public bool EsLogin { get; set; }
        [BindProperty]
        public string Error { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {


        }
        public void OnPost()
        {
            if (EsLogin)
            {
                IUsuarioManager usuarioManager = FactoryManager.UsuarioManager();
                Usuario u = usuarioManager.Login(Login.Correo, Login.Password);
                if (u != null)
                {

                }
                else
                {
                    Error = "Usuario y/o  contraseña incorrecto";
                }
            }
            else
            {

            }

        }
    }
}
