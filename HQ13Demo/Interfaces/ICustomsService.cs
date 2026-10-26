using HQ13Demo.Models;

namespace HQ13Demo.Interfaces
{
    public interface ICustomsService
    {
        CustomsClearanceResult CheckClearance(string containerNo);
    }
}
