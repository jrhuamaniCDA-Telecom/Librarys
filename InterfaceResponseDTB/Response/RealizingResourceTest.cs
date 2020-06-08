using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceResponseDTB.Response
{
  public class RealizingResourceTest
  {
    public string name { get; set; }
    public List<Characteristic> characteristic { get; set; }
    public List<TestMeasure> testMeasure { get; set; }
    public List<TestDiagnosis> testDiagnosis { get; set; }
    public List<RelatedServiceTest> relatedServiceTest { get; set; }
  }
}
