using Demo.Common;
using Demo.Service1.Models;

namespace Demo.Service1
{
    public interface IService1abc : IService
    {
        Model1 md1 { get; set; }
    }
}
