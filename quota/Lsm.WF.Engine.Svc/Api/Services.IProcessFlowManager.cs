﻿using DoE.Lsm.Annotations.Api;
using DoE.Lsm.WF.Engine.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DoE.Lsm.WF.Engine.Api
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(Namespace ="")]
    public interface IProcessFlowManager
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        [OperationContract(AsyncPattern =true)]
        [WebInvoke(Method         = "POST",
                   BodyStyle      = WebMessageBodyStyle.Bare,
                   RequestFormat  = WebMessageFormat.Json,
                   ResponseFormat = WebMessageFormat.Json,
                   UriTemplate    = "/ProcessRequest")]
        [RequestTokenHandler]
        IAsyncResult BeginProcessRequest(ProcessCase context, AsyncCallback callback, object state);

        ProcessCase EndProcessRequest(ProcessCase context);
    }
}
