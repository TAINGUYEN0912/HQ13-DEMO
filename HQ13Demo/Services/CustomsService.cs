using System;
using HQ13Demo.Interfaces;
using HQ13Demo.Models;

namespace HQ13Demo.Services
{
    public class CustomsService : ICustomsService
    {
        public CustomsClearanceResult CheckClearance(string containerNo)
        {
            if (string.IsNullOrWhiteSpace(containerNo))
            {
                return CustomsClearanceResult.Failed("Vui lòng nhập số container để kiểm tra.");
            }
            var container = new ContainerInfo(containerNo, "22G1", "SNP888999", "ONE");

            return CustomsClearanceResult.Success(container);
        }
    }
}
