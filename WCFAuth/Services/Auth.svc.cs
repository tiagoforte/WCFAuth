using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web.Caching;
using System.Web.Helpers;
using WCFAuth.Models;

namespace WCFAuth.Services
{
  // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Auth" in code, svc and config file together.
  // NOTE: In order to launch WCF Test Client for testing this service, please select Auth.svc or Auth.svc.cs at the Solution Explorer and start debugging.
  public class Auth : IAuth
  {
    public Token GetToken()
    {
      string token = Guid.NewGuid().ToString();
      DateTime expires = DateTime.Now.AddMinutes(1);
      WebCache.Set($"Token_{token}", token, 1, false);

      return new Token
      {
        Value = token,
        Expires = expires
      };
    }


  }
}
