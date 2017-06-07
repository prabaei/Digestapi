using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAttrib
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("test attrib");
            rojer rojerj = new rojer();
        }
    }
    [AttributeUsage(AttributeTargets.Class)]
    public class TestAttribi : Attribute
    {
        public string message { get; set; }
        public TestAttribi()
        {
            Console.Write("don't worry");
        }
        
    }

    [TestAttribi(message ="test message")]
    public class rojer
    {

    }
}
