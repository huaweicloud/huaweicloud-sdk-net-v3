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
    /// Response Object
    /// </summary>
    public class ShowAvailableIpResponse : SdkResponse
    {

        /// <summary>
        /// 可用ip数。
        /// </summary>
        [JsonProperty("available_ip", NullValueHandling = NullValueHandling.Ignore)]
        public int? AvailableIp { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAvailableIpResponse {\n");
            sb.Append("  availableIp: ").Append(AvailableIp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAvailableIpResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAvailableIpResponse input)
        {
            if (input == null) return false;
            if (this.AvailableIp != input.AvailableIp || (this.AvailableIp != null && !this.AvailableIp.Equals(input.AvailableIp))) return false;

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
                if (this.AvailableIp != null) hashCode = hashCode * 59 + this.AvailableIp.GetHashCode();
                return hashCode;
            }
        }
    }
}
