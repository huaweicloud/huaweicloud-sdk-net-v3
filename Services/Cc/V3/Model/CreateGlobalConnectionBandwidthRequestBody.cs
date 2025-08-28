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
    /// 创建全域互联带宽实例的请求体。
    /// </summary>
    public class CreateGlobalConnectionBandwidthRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("globalconnection_bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public CreateGlobalConnectionBandwidth GlobalconnectionBandwidth { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateGlobalConnectionBandwidthRequestBody {\n");
            sb.Append("  globalconnectionBandwidth: ").Append(GlobalconnectionBandwidth).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateGlobalConnectionBandwidthRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateGlobalConnectionBandwidthRequestBody input)
        {
            if (input == null) return false;
            if (this.GlobalconnectionBandwidth != input.GlobalconnectionBandwidth || (this.GlobalconnectionBandwidth != null && !this.GlobalconnectionBandwidth.Equals(input.GlobalconnectionBandwidth))) return false;

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
                if (this.GlobalconnectionBandwidth != null) hashCode = hashCode * 59 + this.GlobalconnectionBandwidth.GetHashCode();
                return hashCode;
            }
        }
    }
}
