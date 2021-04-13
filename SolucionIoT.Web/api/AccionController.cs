using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SolucionIoT.BIZ;
using SolucionIoT.COMMON.Entidades;
using SolucionIoT.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolucionIoT.Web.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccionController : GenericApiController<Accion>
    {
        public AccionController() : base(FactoryManager.AccionManager())
        {
        }
    }
}
