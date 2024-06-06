using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowProxyIpgroupResponse : SdkResponse
    {

        /// <summary>
        /// 允许访问控制或者不允许 true | false。
        /// </summary>
        [JsonProperty("enable_ip_group", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableIpGroup { get; set; }

        /// <summary>
        /// 白名单或者黑名单 &#39;white&#39; | &#39;black&#39;
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ip_group", NullValueHandling = NullValueHandling.Ignore)]
        public ProxyIpGroupDetail IpGroup { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowProxyIpgroupResponse {\n");
            sb.Append("  enableIpGroup: ").Append(EnableIpGroup).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  ipGroup: ").Append(IpGroup).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowProxyIpgroupResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowProxyIpgroupResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EnableIpGroup == input.EnableIpGroup ||
                    (this.EnableIpGroup != null &&
                    this.EnableIpGroup.Equals(input.EnableIpGroup))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.IpGroup == input.IpGroup ||
                    (this.IpGroup != null &&
                    this.IpGroup.Equals(input.IpGroup))
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
                if (this.EnableIpGroup != null)
                    hashCode = hashCode * 59 + this.EnableIpGroup.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.IpGroup != null)
                    hashCode = hashCode * 59 + this.IpGroup.GetHashCode();
                return hashCode;
            }
        }
    }
}
