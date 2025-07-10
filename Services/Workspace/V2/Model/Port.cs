using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 私有IP信息。
    /// </summary>
    public class Port 
    {

        /// <summary>
        /// 私有IP唯一标识。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 私有IP地址。
        /// </summary>
        [JsonProperty("ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string IpAddress { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Port {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  ipAddress: ").Append(IpAddress).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Port);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Port input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.IpAddress != input.IpAddress || (this.IpAddress != null && !this.IpAddress.Equals(input.IpAddress))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IpAddress != null) hashCode = hashCode * 59 + this.IpAddress.GetHashCode();
                return hashCode;
            }
        }
    }
}
