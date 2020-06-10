using System;
using System.Collections.Generic;
using System.Text;

namespace Microservice
{
  public class ResponseService<T> where T : class
  {
    public int StatusCode { get; set; }
    public string Message { get; set; }
    public T ResponseData { get; set; }
  }
}
