using System;
using System.ServiceModel;
using System.ServiceModel.Activation;

namespace GeoLib.WebHost
{
    public class CustomHostFactory : ServiceHostFactory
    {
        protected override ServiceHost CreateServiceHost(Type serviceType, Uri[] baseAddresses)
        {
            // The default host factory does the same thing, but the can custom it now
            ServiceHost host = new ServiceHost(serviceType, baseAddresses);
            return host;
        }
    }
}