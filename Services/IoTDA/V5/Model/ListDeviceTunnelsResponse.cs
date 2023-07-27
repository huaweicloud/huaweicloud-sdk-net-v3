using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListDeviceTunnelsResponse : SdkResponse
    {

        /// <summary>
        /// 隧道信息列表。
        /// </summary>
        [JsonProperty("tunnels", NullValueHandling = NullValueHandling.Ignore)]
        public List<TunnelInfo> Tunnels { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDeviceTunnelsResponse {\n");
            sb.Append("  tunnels: ").Append(Tunnels).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDeviceTunnelsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDeviceTunnelsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Tunnels == input.Tunnels ||
                    this.Tunnels != null &&
                    input.Tunnels != null &&
                    this.Tunnels.SequenceEqual(input.Tunnels)
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
                if (this.Tunnels != null)
                    hashCode = hashCode * 59 + this.Tunnels.GetHashCode();
                return hashCode;
            }
        }
    }
}
