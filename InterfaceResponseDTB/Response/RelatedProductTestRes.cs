using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceResponseDTB.Response
{
  public class RelatedProductTestRes
  {
    public string name { get; set; }
    public List<TestDiagnosis> testDiagnosis { get; set; }
    public Product product { get; set; }
    public List<RealizingResourceTest> realizingResourceTest { get; set; }
  }
}
