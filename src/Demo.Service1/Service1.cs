using Demo.Common;

namespace Demo.Service1
{
    public class Service1 : IService
    {
        public string ValuePassedIn { get; set; }

        public string DoSomeWork()
        {
            return $"This is what is the the property 'ValuePassedIn': ${ValuePassedIn}";
        }
    }
}