using Demo.Common;
using Demo.Service1.Models;

namespace Demo.Service1
{
    public class Service1abc : IService1abc
    {
        public Model1 md1 { get; set; }

        public string ValuePassedIn { get; set; }

        public string DoSomeWork()
        {
            return DemoStringText.CombineStrings("This is what is the the property 'ValuePassedIn':", ValuePassedIn);
        }
        public string DoSomeMoreWork()
        {
            return DemoStringText.CombineStrings("This is what is the the property 'ValuePassedIn':", ValuePassedIn,"More Text here");
        }
    }
}