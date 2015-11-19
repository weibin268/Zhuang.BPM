using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;
using Zhuang.BPM.Templates;
using System.Activities.DurableInstancing;
using System.Configuration;
using System.Runtime.DurableInstancing;

namespace Zhuang.BPM.ConsoleTestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkflowApplication wfApplication = new WorkflowApplication(new Activity1());

            SqlWorkflowInstanceStore instanceStore = new SqlWorkflowInstanceStore(ConfigurationManager.ConnectionStrings["ZhuangBPM"].ToString());
            wfApplication.InstanceStore = instanceStore;


            InstanceView view = instanceStore.Execute(instanceStore.CreateInstanceHandle(), new CreateWorkflowOwnerCommand(), TimeSpan.FromSeconds(30));
            instanceStore.DefaultInstanceOwner = view.InstanceOwner;
 


            wfApplication.PersistableIdle = (e) => {
                System.Console.WriteLine("persistableIdle:{0}", e.InstanceId); 

                return PersistableIdleAction.Unload;
            };

            wfApplication.Run();



            Console.ReadKey();
        }
    }
}
