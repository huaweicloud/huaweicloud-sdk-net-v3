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
    /// 网关的类型。
    /// </summary>
    public class GatewayType 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("gateway_type", NullValueHandling = NullValueHandling.Ignore)]
        public GatewayTypeEnum _GatewayType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GatewayType {\n");
            sb.Append("  _gatewayType: ").Append(_GatewayType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GatewayType);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GatewayType input)
        {
            if (input == null) return false;
            if (this._GatewayType != input._GatewayType) return false;

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
                hashCode = hashCode * 59 + this._GatewayType.GetHashCode();
                return hashCode;
            }
        }
    }
}
