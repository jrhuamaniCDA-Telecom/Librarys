using Domain.Model.InformacionComercial;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContratoObtenerProductosClienteDiagnostico
{
  public class Response
  {
    public string idSubscriber { get; set; }
    public string idDomicilio { get; set; }
    public ICResponse data { get; set; }
  }
}
