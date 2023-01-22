using System;
using System.Collections.Generic;

namespace RH.Utilities.ServiceLocator
{
    [AttributeUsage(AttributeTargets.Field)]
    public class InjectAttribute : Attribute
    {
        public InjectAttribute()
        {
            
        }
    }
    public class Services
    {
        private static Services _instance;
        
        private readonly Dictionary<Type, IService> _services = new();

        public Services RegisterSingle<T>(T service) where T : IService
        {
            _instance ??= new Services();
            
            if (_services.ContainsKey(typeof(T)))
                throw new Exception($"Already instantiated service {typeof(T)}");

            _services[typeof(T)] = service;

            return this;
        }

        public static T Get<T>() where T : IService =>
            _instance.GetSingle<T>();

        private T GetSingle<T>() where T : IService
        {
            if (!_services.ContainsKey(typeof(T)))
                throw new UnavailableServiceException(typeof(T));

            return (T) _services[typeof(T)];
        }
    }
}
