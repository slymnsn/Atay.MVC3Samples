namespace Mvc3IoC.Utils
{
    using System;
    using System.Collections.Generic;
    using System.Web.Mvc;
    using Ninject;

    /// <summary>
    /// IoC örnekleme yönetimini yapacak olan Hinjet yapsıs ile ilgili bildirimler.
    /// </summary>
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernel)
        {
            this.kernel = kernel;
        }

        public object GetService(Type serviceType)
        {
            return this.GetInstance(serviceType, null);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return this.kernel.GetAll(serviceType);
        }

        private object GetInstance(Type serviceType, string key)
        {
            try
            {
                return this.kernel.Get(serviceType, key);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}