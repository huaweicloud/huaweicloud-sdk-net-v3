using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cc.V3.Model
{
    /// <summary>
    /// 创建网络实例的请求体。
    /// </summary>
    public class CreateNetworkInstanceRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("network_instance", NullValueHandling = NullValueHandling.Ignore)]
        public CreateNetworkInstance NetworkInstance { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateNetworkInstanceRequestBody {\n");
            sb.Append("  networkInstance: ").Append(NetworkInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateNetworkInstanceRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateNetworkInstanceRequestBody input)
        {
            if (input == null) return false;
            if (this.NetworkInstance != input.NetworkInstance || (this.NetworkInstance != null && !this.NetworkInstance.Equals(input.NetworkInstance))) return false;

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
                if (this.NetworkInstance != null) hashCode = hashCode * 59 + this.NetworkInstance.GetHashCode();
                return hashCode;
            }
        }
    }
}
