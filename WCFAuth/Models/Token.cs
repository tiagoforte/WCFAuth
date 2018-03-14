using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCFAuth.Models
{
  public class Token
  {
    public string Value { get; set; }
    public DateTime Expires { get; set; }
  }
}