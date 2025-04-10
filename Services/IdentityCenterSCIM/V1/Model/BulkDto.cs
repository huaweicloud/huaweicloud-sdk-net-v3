using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenterSCIM.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BulkDto 
    {

        /// <summary>
        /// 一个布尔值，表示服务提供商是否支持这种操作
        /// </summary>
        [JsonProperty("supported", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Supported { get; set; }

        /// <summary>
        /// 一次可操作的最大个数
        /// </summary>
        [JsonProperty("maxOperations", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxOperations { get; set; }

        /// <summary>
        /// 最大有效载荷量
        /// </summary>
        [JsonProperty("maxPayloadSize", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxPayloadSize { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BulkDto {\n");
            sb.Append("  supported: ").Append(Supported).Append("\n");
            sb.Append("  maxOperations: ").Append(MaxOperations).Append("\n");
            sb.Append("  maxPayloadSize: ").Append(MaxPayloadSize).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BulkDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BulkDto input)
        {
            if (input == null) return false;
            if (this.Supported != input.Supported || (this.Supported != null && !this.Supported.Equals(input.Supported))) return false;
            if (this.MaxOperations != input.MaxOperations || (this.MaxOperations != null && !this.MaxOperations.Equals(input.MaxOperations))) return false;
            if (this.MaxPayloadSize != input.MaxPayloadSize || (this.MaxPayloadSize != null && !this.MaxPayloadSize.Equals(input.MaxPayloadSize))) return false;

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
                if (this.Supported != null) hashCode = hashCode * 59 + this.Supported.GetHashCode();
                if (this.MaxOperations != null) hashCode = hashCode * 59 + this.MaxOperations.GetHashCode();
                if (this.MaxPayloadSize != null) hashCode = hashCode * 59 + this.MaxPayloadSize.GetHashCode();
                return hashCode;
            }
        }
    }
}
