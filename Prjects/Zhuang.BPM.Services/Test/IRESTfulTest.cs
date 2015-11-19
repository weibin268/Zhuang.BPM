using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Zhuang.BPM.Services.Test
{
    [ServiceContract]
    public interface IRESTfulTest
    {
        [OperationContract]
        [WebGet(UriTemplate = "user/xml", ResponseFormat = WebMessageFormat.Xml)]
        List<User> GetUserList();
     
    }

    [DataContract]
    public class User
    {
        [DataMember]
        public string Name{get;set;}

        [DataMember]
        public int Age { get; set; }
    }
}
