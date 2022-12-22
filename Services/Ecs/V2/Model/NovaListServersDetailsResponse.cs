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
    public class NovaListServersDetailsResponse : SdkResponse
    {

        /// <summary>
        /// 查询云服务器信息列表。
        /// </summary>
        [JsonProperty("servers", NullValueHandling = NullValueHandling.Ignore)]
        public List<NovaServer> Servers { get; set; }

        /// <summary>
        /// 分页查询时，查询下一页数据链接。
        /// </summary>
        [JsonProperty("servers_links", NullValueHandling = NullValueHandling.Ignore)]
        public List<PageLink> ServersLinks { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NovaListServersDetailsResponse {\n");
            sb.Append("  servers: ").Append(Servers).Append("\n");
            sb.Append("  serversLinks: ").Append(ServersLinks).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NovaListServersDetailsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NovaListServersDetailsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Servers == input.Servers ||
                    this.Servers != null &&
                    input.Servers != null &&
                    this.Servers.SequenceEqual(input.Servers)
                ) && 
                (
                    this.ServersLinks == input.ServersLinks ||
                    this.ServersLinks != null &&
                    input.ServersLinks != null &&
                    this.ServersLinks.SequenceEqual(input.ServersLinks)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Servers != null)
                    hashCode = hashCode * 59 + this.Servers.GetHashCode();
                if (this.ServersLinks != null)
                    hashCode = hashCode * 59 + this.ServersLinks.GetHashCode();
                return hashCode;
            }
        }
    }
}
