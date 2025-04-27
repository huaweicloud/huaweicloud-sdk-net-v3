using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dns.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateEndpointRequestBody 
    {

        /// <summary>
        /// 待创建的终端节点名称。 取值范围：1-64个字符，支持数字、字母、中文、_（下划线）、-（中划线）、.（点）。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 终端节点方向。 取值： inbound，表示入站终端节点。 outbound，表示出站终端节点。
        /// </summary>
        [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
        public string Direction { get; set; }

        /// <summary>
        /// 当前子网所在的region。
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 终端节点的IP地址和子网信息。最少需要添加2个IP地址，最多可以添加6个IP地址。
        /// </summary>
        [JsonProperty("ipaddresses", NullValueHandling = NullValueHandling.Ignore)]
        public List<IpaddressInfo> Ipaddresses { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateEndpointRequestBody {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  direction: ").Append(Direction).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  ipaddresses: ").Append(Ipaddresses).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateEndpointRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateEndpointRequestBody input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Direction != input.Direction || (this.Direction != null && !this.Direction.Equals(input.Direction))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.Ipaddresses != input.Ipaddresses || (this.Ipaddresses != null && input.Ipaddresses != null && !this.Ipaddresses.SequenceEqual(input.Ipaddresses))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Direction != null) hashCode = hashCode * 59 + this.Direction.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.Ipaddresses != null) hashCode = hashCode * 59 + this.Ipaddresses.GetHashCode();
                return hashCode;
            }
        }
    }
}
