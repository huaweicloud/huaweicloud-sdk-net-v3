using System;
using System.Collections.Generic;
using System.Linq;

namespace HuaweiCloud.SDK.Core
{
    public class Region
    {


        public Region(string id, params string[] endpoints)
        {
            Id = id;
            Endpoints = endpoints.ToList();
        }

        public string Id { get; set; }

        [Obsolete("As of 3.1.26, because of the support of the multi-endpoint feature, use Endpoints instead")]
        public string Endpoint
        {
            get => Endpoints == null || Endpoints.Count == 0 ? null : Endpoints[0];
            set =>
                Endpoints = new List<string>
                {
                    value
                };
        }

        public List<string> Endpoints { get; set; }

        [Obsolete("As of 3.1.26, because of the support of the multi-endpoint feature, use WithEndpointsOverride instead")]
        public Region WithEndpointOverride(string newEndpoint)
        {
            return WithEndpointsOverride(new List<string>
            {
                newEndpoint
            });
        }

        public Region WithEndpointsOverride(List<string> endpoints)
        {
            Endpoints = endpoints;
            return this;
        }
    }
}
