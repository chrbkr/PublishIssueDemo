using ProjectB.Properties;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Configuration;

namespace ProjectB
{
    public class ConfigReader
    {

        public string GetEndpoint()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(GetType().Assembly.Location);
            ClientSection clientSection = (ClientSection)config.GetSection("system.serviceModel/client");

            IEnumerable<ChannelEndpointElement> configEndpoints = clientSection
                .Endpoints
                .OfType<ChannelEndpointElement>();

            EndpointAddress endpointAddress = new EndpointAddress(new UriBuilder(configEndpoints
                .First()
                .Address).Uri);

            return endpointAddress.ToString();
        }
    }
}
