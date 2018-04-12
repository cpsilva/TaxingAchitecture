using System;

namespace Tax.CrossCutting.Values
{
    public sealed class BusinessException : Exception
    {
        public BusinessException(string message) : base(message)
        {
        }
    }
}