using System;
using System.Collections.Generic;
using System.Text;
using Domain.Model.InformacionComercial;

namespace InterfaceResponseOPEN
{
  public class ResponseOPEN
  {
    public string idSubscriber { get; set; }
    public string idDomicilio { get; set; }
    public ICResponse data { get; set; }
  }
}
