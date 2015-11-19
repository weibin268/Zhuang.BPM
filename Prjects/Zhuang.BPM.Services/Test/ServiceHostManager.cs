using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;

namespace Zhuang.BPM.Services.Test
{
    public class ServiceHostManager
    {
        public static void OpenRESTfulTestHost()
        {
            ServiceHost host = new ServiceHost(typeof(RESTfulTest), new Uri("http://localhost:8088/"));

            ServiceEndpoint endpoint = host.AddServiceEndpoint(typeof(IRESTfulTest), new WebHttpBinding(), "restful");
            WebHttpBehavior httpBehavior = new WebHttpBehavior();
            endpoint.Behaviors.Add(httpBehavior);

            //ServiceMetadataBehavior behavior = new ServiceMetadataBehavior();
            //behavior.HttpGetEnabled = true;
            //host.Description.Behaviors.Add(behavior);

            host.Open();
        }
    }
}
