using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Web;
using System.Text;

namespace Zhuang.BPM.Services.Test
{
    public class RESTfulTest : IRESTfulTest
    {
        public List<User> GetUserList()
        {
            WebOperationContext.Current.OutgoingResponse.ContentType = "text/plain";

            List<User> users = new List<User>();
            users.Add(new User() { Name = "zhuang", Age = 11 });
            users.Add(new User() { Name = "wei", Age = 22 });
            users.Add(new User() { Name = "bin", Age = 33 });
            return users;
        }
    }
}
