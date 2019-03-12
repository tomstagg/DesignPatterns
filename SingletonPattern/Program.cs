using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //this won't compile
            //var singleton = new Singleton();  
            var singleton = Singleton.GetInstance();
            singleton.Name  = "bob";

            singleton.ReportValue();


            var singleton2 = Singleton.GetInstance();
            singleton2.ReportValue();
            singleton.Name = "lucy";

            singleton.ReportValue();
            singleton2.ReportValue();

        }
    }


    public class Singleton
    {
        private static Singleton _uniqueInstance;
        private static object _padlock = new object();
        public string Name { get; set; } = "";

        private Singleton()
        {

        }

        public static Singleton GetInstance()
        {
            lock (_padlock)
            {
                if (_uniqueInstance == null)
                    _uniqueInstance = new Singleton();

            }

            return _uniqueInstance;
        }

        public void ReportValue()
        {
            Console.WriteLine($"My value is: {Name}");
        }
    }
}
