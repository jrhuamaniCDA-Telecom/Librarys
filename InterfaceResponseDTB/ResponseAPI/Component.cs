using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceResponseDTB.ResponseAPI
{
  public class Component
  {
    public string code { get; set; }
    public string codeStatus { get; set; }
    public string label { get; set; }
    public string name { get; set; }
    public List<Detail> details { get; set; }
    public List<WorkFlow> workFlows { get; set; }
  }
}
