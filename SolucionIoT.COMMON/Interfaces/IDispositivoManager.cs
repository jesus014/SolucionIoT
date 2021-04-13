using SolucionIoT.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolucionIoT.COMMON.Interfaces
{
    public interface IDispositivoManager: IGenericManager<Dispositivo>
    {
        IEnumerable<Dispositivo> DispositivosDeUsuarioPorId(string id);
        
        IEnumerable<Dispositivo> DispositivosDeUsuarioPorEmail(string email);
        
        bool DispositivoPerteneceAUsuario(string idDispositivo, string idUsuario);
    }
}
