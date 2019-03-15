using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.Serialization;
namespace TestBOM
{
    class Program
    {
 
        static void Main(string[] args)
        {

            var PatientContainer = TestVist.InitializeConnection();
            var visitInfo = PatientContainer.CreateQuery<TestBOM.Visit>("Visit").Execute().ToList();


        }
    }
}
