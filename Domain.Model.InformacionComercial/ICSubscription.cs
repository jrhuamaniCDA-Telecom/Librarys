using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Model.InformacionComercial
{
  public class ICSubscription
  {
    public List<ICSubscriptionDetail> subscription { get; set; }
  }
}
