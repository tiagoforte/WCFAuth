using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCFAuth.Models
{
  public class Transaction
  {
    public bool IsValid { get; set; }
    public string Message { get; set; }
    public List<Models.Product> Products { get; set; }
  }
}