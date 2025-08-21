using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rgc.V1.Model
{
    /// <summary>
    /// 操作控制策略的请求体。
    /// </summary>
    public class EnableControlOperateReqBody 
    {

        /// <summary>
        /// 控制策略ID。
        /// </summary>
        [JsonProperty("identifier", NullValueHandling = NullValueHandling.Ignore)]
        public string Identifier { get; set; }

        /// <summary>
        /// 组织单元的ID信息。
        /// </summary>
        [JsonProperty("target_identifier", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetIdentifier { get; set; }

        /// <summary>
        /// 策略参数。
        /// </summary>
        [JsonProperty("parameters", NullValueHandling = NullValueHandling.Ignore)]
        public List<EnableControlParameters> Parameters { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnableControlOperateReqBody {\n");
            sb.Append("  identifier: ").Append(Identifier).Append("\n");
            sb.Append("  targetIdentifier: ").Append(TargetIdentifier).Append("\n");
            sb.Append("  parameters: ").Append(Parameters).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EnableControlOperateReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EnableControlOperateReqBody input)
        {
            if (input == null) return false;
            if (this.Identifier != input.Identifier || (this.Identifier != null && !this.Identifier.Equals(input.Identifier))) return false;
            if (this.TargetIdentifier != input.TargetIdentifier || (this.TargetIdentifier != null && !this.TargetIdentifier.Equals(input.TargetIdentifier))) return false;
            if (this.Parameters != input.Parameters || (this.Parameters != null && input.Parameters != null && !this.Parameters.SequenceEqual(input.Parameters))) return false;

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
                if (this.Identifier != null) hashCode = hashCode * 59 + this.Identifier.GetHashCode();
                if (this.TargetIdentifier != null) hashCode = hashCode * 59 + this.TargetIdentifier.GetHashCode();
                if (this.Parameters != null) hashCode = hashCode * 59 + this.Parameters.GetHashCode();
                return hashCode;
            }
        }
    }
}
