using System;

namespace RH.Utilities.ServiceLocator
{
    public class DoubleRegisteredServiceException : Exception
    {
        public DoubleRegisteredServiceException(Type service)
            : base($"Attempt to another register type {service}")
        {}
    }
}