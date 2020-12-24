namespace HuaweiCloud.SDK.Core
{
    public class Region
    {
        public string Id { get; set; }

        public string Endpoint { get; set; }

        public Region(string id, string endpoint)
        {
            Id = id;
            Endpoint = endpoint;
        }

        public Region WithEndpointResolver(string newEndpoint)
        {
            Endpoint = newEndpoint;
            return this;
        }
    }
}