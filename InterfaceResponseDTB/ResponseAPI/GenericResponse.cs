﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceResponseDTB.ResponseAPI
{
  public class GenericResponse<T> where T : class
  {
    public int StatusCode { get; set; }
    public string CustomMessage { get; set; }
    public string ExceptionMessage { get; set; }
    public T ResponseData { get; set; }
  }
}