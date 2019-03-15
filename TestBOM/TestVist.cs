using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TestBOM
{
    public class TestVist
    {
        public static TestBOM.DefaultContainer InitializeConnection()
        {
            TestBOM.DefaultContainer VisitContainer;
            VisitContainer = new TestBOM.DefaultContainer(new Uri("http://alppatdevweb04.accretivehealth.local:5555/data/VisitService/v2.0"))
            {
                Credentials = new NetworkCredential("Administrator", "manage")
            };
            //Test 
          
            VisitContainer.BuildingRequest += (s, e) =>
            {
                e.Headers.Add("facilityCode", "BOMC");
                e.Headers.Add("Authorization", "Basic QWRtaW5pc3RyYXRvcjptYW5hZ2U=");
            };

            return VisitContainer;
        }
    }
}
