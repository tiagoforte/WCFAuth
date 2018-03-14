using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web.Helpers;
using WCFAuth.Models;

namespace WCFAuth.Services
{
  // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Product" in code, svc and config file together.
  // NOTE: In order to launch WCF Test Client for testing this service, please select Product.svc or Product.svc.cs at the Solution Explorer and start debugging.
  public class Product : IProduct
  {
    public Models.Transaction GetProduct(string token)
    {
      var transaction = new Models.Transaction();

      if (WebCache.Get($"Token_{token}") == null)
      {
        transaction.IsValid = false;
        transaction.Message = "Sessão expirada";
        return transaction;
      }


      transaction.IsValid = true;
      transaction.Products = new List<Models.Product>
      {
        new Models.Product { Id = Guid.NewGuid(), Name = "Frango", Price = 15.0m },
        new Models.Product { Id = Guid.NewGuid(), Name = "Peixe", Price = 10.0m },
        new Models.Product { Id = Guid.NewGuid(), Name = "Café", Price = 4.30m },
        new Models.Product { Id = Guid.NewGuid(), Name = "Pão", Price = 1.70m }
      };
      return transaction;
    }
   
  }
}
