﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFAuth.Models;

namespace WCFAuth.Services
{
  // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAuth" in both code and config file together.
  [ServiceContract]
  public interface IAuth
  {
    [OperationContract]
    Token GetToken();        
  }
}
