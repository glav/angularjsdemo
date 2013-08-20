using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Glav.AgularJSDemo.Web.Controllers
{
    public class ExampleApiController : ApiController
    {
        public string GetStuff()
        {
            //Delay to simulate some work taking some time to execute
            System.Threading.Thread.Sleep(2000);

            return string.Format("Time from Server: {0}", DateTime.Now.ToShortTimeString());
        }
        public string PostStuff(string blob)
        {
            //Delay to simulate some work taking some time to execute
            System.Threading.Thread.Sleep(2000);

            if (!string.IsNullOrWhiteSpace(blob) && 
                    (blob.ToLowerInvariant().Contains("die") 
                        || blob.ToLowerInvariant().Contains("fail")))
            {
                throw new Exception("Sorry, I blew up!");
            }

            return string.Format("You posted '{0}' at {1}", blob, DateTime.Now.ToShortTimeString());
        }
    }
}
