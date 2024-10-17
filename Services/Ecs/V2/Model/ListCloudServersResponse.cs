using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListCloudServersResponse : SdkResponse
    {

        /// <summary>
        /// 查询云服务器信息列表。
        /// </summary>
        [JsonProperty("servers", NullValueHandling = NullValueHandling.Ignore)]
        public List<CloudServer> Servers { get; set; }

        /// <summary>
        /// 分页查询时，查询下一页数据链接。
        /// </summary>
        [JsonProperty("servers_links", NullValueHandling = NullValueHandling.Ignore)]
        public List<PageLink> ServersLinks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("request_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListCloudServersResponse {\n");
            sb.Append("  servers: ").Append(Servers).Append("\n");
            sb.Append("  serversLinks: ").Append(ServersLinks).Append("\n");
            sb.Append("  requestId: ").Append(RequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListCloudServersResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListCloudServersResponse input)
        {
            if (input == null) return false;
            if (this.Servers != input.Servers || (this.Servers != null && input.Servers != null && !this.Servers.SequenceEqual(input.Servers))) return false;
            if (this.ServersLinks != input.ServersLinks || (this.ServersLinks != null && input.ServersLinks != null && !this.ServersLinks.SequenceEqual(input.ServersLinks))) return false;
            if (this.RequestId != input.RequestId || (this.RequestId != null && !this.RequestId.Equals(input.RequestId))) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.Servers != null) hashCode = hashCode * 59 + this.Servers.GetHashCode();
                if (this.ServersLinks != null) hashCode = hashCode * 59 + this.ServersLinks.GetHashCode();
                if (this.RequestId != null) hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
