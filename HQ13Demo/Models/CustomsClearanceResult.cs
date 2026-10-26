using System;

namespace HQ13Demo.Models
{
    public class CustomsClearanceResult
    {
        public bool IsSuccess { get; }
        public string Message { get; }
        public ContainerInfo Container { get; }

        private CustomsClearanceResult(bool isSuccess, string message, ContainerInfo container)
        {
            IsSuccess = isSuccess;
            Message = message;
            Container = container;
        }

        public static CustomsClearanceResult Success(ContainerInfo container)
        {
            return new CustomsClearanceResult(true, "Thành công", container);
        }

        public static CustomsClearanceResult Failed(string reason)
        {
            return new CustomsClearanceResult(false, reason, null);
        }
    }
}
